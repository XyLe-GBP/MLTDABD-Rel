﻿using AssetStudio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using static AssetStudioGUI.Exporter;
using Font = AssetStudio.Font;
using Object = AssetStudio.Object;
using MLTDABD_Rel.Properties;

namespace AssetStudioGUI
{
    internal enum ExportType
    {
        Convert,
        Raw,
        Dump
    }

    internal static class Studio
    {
        public static AssetsManager assetsManager = new AssetsManager();
        public static ScriptDumper scriptDumper = new ScriptDumper();
        public static List<AssetItem> exportableAssets = new List<AssetItem>();
        public static List<AssetItem> visibleAssets = new List<AssetItem>();
        internal static Action<string> StatusStripUpdate = x => { };

        public static void ExtractFile(string[] fileNames)
        {
            ThreadPool.QueueUserWorkItem(state =>
            {
                int extractedCount = 0;
                Progress.Reset();
                for (var i = 0; i < fileNames.Length; i++)
                {
                    var fileName = fileNames[i];
                    var type = ImportHelper.CheckFileType(fileName, out var reader);
                    if (type == FileType.BundleFile)
                        extractedCount += ExtractBundleFile(fileName, reader);
                    else if (type == FileType.WebFile)
                        extractedCount += ExtractWebDataFile(fileName, reader);
                    else
                        reader.Dispose();
                    Progress.Report(i + 1, fileNames.Length);
                }

                StatusStripUpdate($"Finished extracting {extractedCount} files.");
            });
        }

        private static int ExtractBundleFile(string bundleFileName, EndianBinaryReader reader)
        {
            StatusStripUpdate($"Decompressing {Path.GetFileName(bundleFileName)} ...");
            var bundleFile = new BundleFile(reader, bundleFileName);
            reader.Dispose();
            if (bundleFile.fileList.Length > 0)
            {
                var extractPath = bundleFileName + "_unpacked\\";
                return ExtractStreamFile(extractPath, bundleFile.fileList);
            }
            return 0;
        }

        private static int ExtractWebDataFile(string webFileName, EndianBinaryReader reader)
        {
            StatusStripUpdate($"Decompressing {Path.GetFileName(webFileName)} ...");
            var webFile = new WebFile(reader);
            reader.Dispose();
            if (webFile.fileList.Length > 0)
            {
                var extractPath = webFileName + "_unpacked\\";
                return ExtractStreamFile(extractPath, webFile.fileList);
            }
            return 0;
        }

        private static int ExtractStreamFile(string extractPath,StreamFile[] fileList)
        {
            int extractedCount = 0;
            foreach (var file in fileList)
            {
                var filePath = extractPath + file.fileName;
                if (!Directory.Exists(extractPath))
                {
                    Directory.CreateDirectory(extractPath);
                }
                if (!File.Exists(filePath) && file.stream is MemoryStream stream)
                {
                    File.WriteAllBytes(filePath, stream.ToArray());
                    extractedCount += 1;
                }
                file.stream.Dispose();
            }
            return extractedCount;
        }

        public static (string, List<TreeNode>) BuildAssetData()
        {
            StatusStripUpdate("Building asset list...");

            string productName = null;
            var assetsNameHash = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var objectCount = assetsManager.assetsFileList.Sum(x => x.Objects.Count);
            var objectAssetItemDic = new Dictionary<Object, AssetItem>(objectCount);
            int i = 0;
            Progress.Reset();
            foreach (var assetsFile in assetsManager.assetsFileList)
            {
                var tempExportableAssets = new List<AssetItem>();
                Dictionary<long, string> containers = null;
                foreach (var asset in assetsFile.Objects)
                {
                    var assetItem = new AssetItem(asset);
                    objectAssetItemDic.Add(asset, assetItem);
                    assetItem.UniqueID = " #" + i;
                    var exportable = false;
                    switch (asset)
                    {
                        case GameObject m_GameObject:
                            assetItem.Text = m_GameObject.m_Name;
                            break;
                        case Texture2D m_Texture2D:
                            if (!string.IsNullOrEmpty(m_Texture2D.m_StreamData?.path))
                                assetItem.FullSize = asset.byteSize + m_Texture2D.m_StreamData.size;
                            assetItem.Text = m_Texture2D.m_Name;
                            exportable = true;
                            break;
                        case AudioClip m_AudioClip:
                            if (!string.IsNullOrEmpty(m_AudioClip.m_Source))
                                assetItem.FullSize = asset.byteSize + m_AudioClip.m_Size;
                            assetItem.Text = m_AudioClip.m_Name;
                            exportable = true;
                            break;
                        case VideoClip m_VideoClip:
                            if (!string.IsNullOrEmpty(m_VideoClip.m_OriginalPath))
                                assetItem.FullSize = asset.byteSize + (long)m_VideoClip.m_Size;
                            assetItem.Text = m_VideoClip.m_Name;
                            exportable = true;
                            break;
                        case Shader m_Shader:
                            assetItem.Text = m_Shader.m_ParsedForm?.m_Name ?? m_Shader.m_Name;
                            exportable = true;
                            break;
                        case Mesh _:
                        case TextAsset _:
                        case AnimationClip _:
                        case Font _:
                        case MovieTexture _:
                        case Sprite _:
                            assetItem.Text = ((NamedObject)asset).m_Name;
                            exportable = true;
                            break;
                        case Animator m_Animator:
                            if (m_Animator.m_GameObject.TryGet(out var gameObject))
                            {
                                assetItem.Text = gameObject.m_Name;
                            }
                            exportable = true;
                            break;
                        case MonoBehaviour m_MonoBehaviour:
                            if (m_MonoBehaviour.m_Name == "" && m_MonoBehaviour.m_Script.TryGet(out var m_Script))
                            {
                                assetItem.Text = m_Script.m_ClassName;
                            }
                            else
                            {
                                assetItem.Text = m_MonoBehaviour.m_Name;
                            }
                            exportable = true;
                            break;
                        case PlayerSettings m_PlayerSettings:
                            productName = m_PlayerSettings.productName;
                            break;
                        case AssetBundle m_AssetBundle:
                            containers = new Dictionary<long, string>();
                            foreach (var m_Container in m_AssetBundle.m_Container)
                            {
                                containers[m_Container.Value.asset.m_PathID] = m_Container.Key;
                            }
                            assetItem.Text = m_AssetBundle.m_Name;
                            break;
                        case NamedObject m_NamedObject:
                            assetItem.Text = m_NamedObject.m_Name;
                            break;
                    }
                    if (assetItem.Text == "")
                    {
                        assetItem.Text = assetItem.TypeString + assetItem.UniqueID;
                    }
                    //处理同名文件
                    if (!assetsNameHash.Add(assetItem.TypeString + assetItem.Text))
                    {
                        assetItem.Text += assetItem.UniqueID;
                    }
                    //处理非法文件名
                    assetItem.Text = FixFileName(assetItem.Text);
                    if (Settings.Default.displayAll || exportable)
                    {
                        tempExportableAssets.Add(assetItem);
                    }
                    Progress.Report(++i, objectCount);
                }
                foreach (var item in tempExportableAssets)
                {
                    if (containers != null)
                    {
                        if (containers.TryGetValue(item.Asset.m_PathID, out var container))
                        {
                            if (!string.IsNullOrEmpty(container))
                            {
                                item.Container = container;
                            }
                        }
                    }
                    item.SetSubItems();
                }
                exportableAssets.AddRange(tempExportableAssets);
                tempExportableAssets.Clear();
                containers?.Clear();
            }
            visibleAssets = exportableAssets;
            assetsNameHash.Clear();

            StatusStripUpdate("Building tree structure...");

            var treeNodeCollection = new List<TreeNode>();
            var treeNodeDictionary = new Dictionary<GameObject, GameObjectTreeNode>();
            var assetsFileCount = assetsManager.assetsFileList.Count;
            int j = 0;
            Progress.Reset();
            foreach (var assetsFile in assetsManager.assetsFileList)
            {
                var fileNode = new GameObjectTreeNode(assetsFile.fileName); //RootNode

                foreach (var obj in assetsFile.Objects)
                {
                    if (obj is GameObject m_GameObject)
                    {
                        if (!treeNodeDictionary.TryGetValue(m_GameObject, out var currentNode))
                        {
                            currentNode = new GameObjectTreeNode(m_GameObject);
                            treeNodeDictionary.Add(m_GameObject, currentNode);
                        }

                        foreach (var pptr in m_GameObject.m_Components)
                        {
                            if (pptr.TryGet(out var m_Component))
                            {
                                objectAssetItemDic[m_Component].TreeNode = currentNode;
                                if (m_Component is MeshFilter m_MeshFilter)
                                {
                                    if (m_MeshFilter.m_Mesh.TryGet(out var m_Mesh))
                                    {
                                        objectAssetItemDic[m_Mesh].TreeNode = currentNode;
                                    }
                                }
                                else if (m_Component is SkinnedMeshRenderer m_SkinnedMeshRenderer)
                                {
                                    if (m_SkinnedMeshRenderer.m_Mesh.TryGet(out var m_Mesh))
                                    {
                                        objectAssetItemDic[m_Mesh].TreeNode = currentNode;
                                    }
                                }
                            }
                        }

                        var parentNode = fileNode;

                        if (m_GameObject.m_Transform != null)
                        {
                            if (m_GameObject.m_Transform.m_Father.TryGet(out var m_Father))
                            {
                                if (m_Father.m_GameObject.TryGet(out var parentGameObject))
                                {
                                    if (!treeNodeDictionary.TryGetValue(parentGameObject, out parentNode))
                                    {
                                        parentNode = new GameObjectTreeNode(parentGameObject);
                                        treeNodeDictionary.Add(parentGameObject, parentNode);
                                    }
                                }
                            }
                        }

                        parentNode.Nodes.Add(currentNode);
                    }
                }

                if (fileNode.Nodes.Count > 0)
                {
                    treeNodeCollection.Add(fileNode);
                }

                Progress.Report(++j, assetsFileCount);
            }
            treeNodeDictionary.Clear();

            objectAssetItemDic.Clear();

            return (productName, treeNodeCollection);
        }

        public static Dictionary<string, SortedDictionary<int, TypeTreeItem>> BuildClassStructure()
        {
            var typeMap = new Dictionary<string, SortedDictionary<int, TypeTreeItem>>();
            foreach (var assetsFile in assetsManager.assetsFileList)
            {
                if (typeMap.TryGetValue(assetsFile.unityVersion, out var curVer))
                {
                    foreach (var type in assetsFile.m_Types.Where(x => x.m_Nodes != null))
                    {
                        var key = type.classID;
                        if (type.m_ScriptTypeIndex >= 0)
                        {
                            key = -1 - type.m_ScriptTypeIndex;
                        }
                        curVer[key] = new TypeTreeItem(key, type.m_Nodes);
                    }
                }
                else
                {
                    var items = new SortedDictionary<int, TypeTreeItem>();
                    foreach (var type in assetsFile.m_Types.Where(x => x.m_Nodes != null))
                    {
                        var key = type.classID;
                        if (type.m_ScriptTypeIndex >= 0)
                        {
                            key = -1 - type.m_ScriptTypeIndex;
                        }
                        items.Add(key, new TypeTreeItem(key, type.m_Nodes));
                    }
                    typeMap.Add(assetsFile.unityVersion, items);
                }
            }

            return typeMap;
        }

        public static string FixFileName(string str)
        {
            if (str.Length >= 260) return Path.GetRandomFileName();
            return Path.GetInvalidFileNameChars().Aggregate(str, (current, c) => current.Replace(c, '_'));
        }

        public static void ExportAssets(string savePath, List<AssetItem> toExportAssets, ExportType exportType)
        {
            ThreadPool.QueueUserWorkItem(state =>
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

                int toExportCount = toExportAssets.Count;
                int exportedCount = 0;
                int i = 0;
                Progress.Reset();
                foreach (var asset in toExportAssets)
                {
                    string exportPath;
                    switch (Settings.Default.assetGroupOption)
                    {
                        case 0: //type name
                            exportPath = Path.Combine(savePath, asset.TypeString);
                            break;
                        case 1: //container path
                            if (!string.IsNullOrEmpty(asset.Container))
                            {
                                exportPath = Path.Combine(savePath, Path.GetDirectoryName(asset.Container));
                            }
                            else
                            {
                                exportPath = savePath;
                            }
                            break;
                        case 2: //source file
                            exportPath = Path.Combine(savePath, asset.SourceFile.fullName + "_export");
                            break;
                        default:
                            exportPath = savePath;
                            break;
                    }
                    exportPath += Path.DirectorySeparatorChar;
                    StatusStripUpdate($"Exporting {asset.TypeString}: {asset.Text}");
                    try
                    {
                        switch (exportType)
                        {
                            case ExportType.Raw:
                                if (ExportRawFile(asset, exportPath))
                                {
                                    exportedCount++;
                                }
                                break;
                            case ExportType.Dump:
                                if (ExportDumpFile(asset, exportPath))
                                {
                                    exportedCount++;
                                }
                                break;
                            case ExportType.Convert:
                                if (ExportConvertFile(asset, exportPath))
                                {
                                    exportedCount++;
                                }
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Export {asset.Type}:{asset.Text} error\r\n{ex.Message}\r\n{ex.StackTrace}");
                    }

                    Progress.Report(++i, toExportCount);
                }

                var statusText = exportedCount == 0 ? "Nothing exported." : $"Finished exporting {exportedCount} assets.";

                if (toExportCount > exportedCount)
                {
                    statusText += $" {toExportCount - exportedCount} assets skipped (not extractable or files already exist)";
                }

                StatusStripUpdate(statusText);

                if (Settings.Default.openAfterExport && exportedCount > 0)
                {
                    Process.Start(savePath);
                }
            });
        }

        public static void ExportSplitObjects(string savePath, TreeNodeCollection nodes)
        {
            ThreadPool.QueueUserWorkItem(state =>
            {
                var count = nodes.Cast<TreeNode>().Sum(x => x.Nodes.Count);
                int k = 0;
                Progress.Reset();
                foreach (GameObjectTreeNode node in nodes)
                {
                    //遍历一级子节点
                    foreach (GameObjectTreeNode j in node.Nodes)
                    {
                        //收集所有子节点
                        var gameObjects = new List<GameObject>();
                        CollectNode(j, gameObjects);
                        //跳过一些不需要导出的object
                        if (gameObjects.All(x => x.m_SkinnedMeshRenderer == null && x.m_MeshFilter == null))
                        {
                            Progress.Report(++k, count);
                            continue;
                        }
                        //处理非法文件名
                        var filename = FixFileName(j.Text);
                        //每个文件存放在单独的文件夹
                        var targetPath = $"{savePath}{filename}\\";
                        //重名文件处理
                        for (int i = 1; ; i++)
                        {
                            if (Directory.Exists(targetPath))
                            {
                                targetPath = $"{savePath}{filename} ({i})\\";
                            }
                            else
                            {
                                break;
                            }
                        }
                        Directory.CreateDirectory(targetPath);
                        //导出FBX
                        StatusStripUpdate($"Exporting {filename}.fbx");
                        try
                        {
                            ExportGameObject(j.gameObject, targetPath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Export GameObject:{j.Text} error\r\n{ex.Message}\r\n{ex.StackTrace}");
                        }

                        Progress.Report(++k, count);
                        StatusStripUpdate($"Finished exporting {filename}.fbx");
                    }
                }
                if (Settings.Default.openAfterExport)
                {
                    Process.Start(savePath);
                }
                StatusStripUpdate("Finished");
            });
        }

        private static void CollectNode(GameObjectTreeNode node, List<GameObject> gameObjects)
        {
            gameObjects.Add(node.gameObject);
            foreach (GameObjectTreeNode i in node.Nodes)
            {
                CollectNode(i, gameObjects);
            }
        }

        public static void ExportAnimatorWithAnimationClip(AssetItem animator, List<AssetItem> animationList, string exportPath)
        {
            ThreadPool.QueueUserWorkItem(state =>
            {
                Progress.Reset();
                StatusStripUpdate($"Exporting {animator.Text}");
                try
                {
                    ExportAnimator(animator, exportPath, animationList);
                    if (Settings.Default.openAfterExport)
                    {
                        Process.Start(exportPath);
                    }
                    Progress.Report(1, 1);
                    StatusStripUpdate($"Finished exporting {animator.Text}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Export Animator:{animator.Text} error\r\n{ex.Message}\r\n{ex.StackTrace}");
                    StatusStripUpdate("Error in export");
                }
            });
        }

        public static void ExportObjectsWithAnimationClip(string exportPath, TreeNodeCollection nodes, List<AssetItem> animationList = null)
        {
            ThreadPool.QueueUserWorkItem(state =>
            {
                var gameObjects = new List<GameObject>();
                GetSelectedParentNode(nodes, gameObjects);
                if (gameObjects.Count > 0)
                {
                    var count = gameObjects.Count;
                    int i = 0;
                    Progress.Reset();
                    foreach (var gameObject in gameObjects)
                    {
                        StatusStripUpdate($"Exporting {gameObject.m_Name}");
                        try
                        {
                            ExportGameObject(gameObject, exportPath, animationList);
                            StatusStripUpdate($"Finished exporting {gameObject.m_Name}");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Export GameObject:{gameObject.m_Name} error\r\n{ex.Message}\r\n{ex.StackTrace}");
                            StatusStripUpdate("Error in export");
                        }

                        Progress.Report(++i, count);
                    }
                    if (Settings.Default.openAfterExport)
                    {
                        Process.Start(exportPath);
                    }
                }
                else
                {
                    StatusStripUpdate("No Object can be exported.");
                }
            });
        }

        public static void ExportObjectsMergeWithAnimationClip(string exportPath, List<GameObject> gameObjects, List<AssetItem> animationList = null)
        {
            ThreadPool.QueueUserWorkItem(state =>
            {
                var name = Path.GetFileName(exportPath);
                Progress.Reset();
                StatusStripUpdate($"Exporting {name}");
                try
                {
                    ExportGameObjectMerge(gameObjects, exportPath, animationList);
                    Progress.Report(1, 1);
                    StatusStripUpdate($"Finished exporting {name}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Export Model:{name} error\r\n{ex.Message}\r\n{ex.StackTrace}");
                    StatusStripUpdate("Error in export");
                }
                if (Settings.Default.openAfterExport)
                {
                    Process.Start(Path.GetDirectoryName(exportPath));
                }
            });
        }

        public static void GetSelectedParentNode(TreeNodeCollection nodes, List<GameObject> gameObjects)
        {
            foreach (GameObjectTreeNode i in nodes)
            {
                if (i.Checked)
                {
                    gameObjects.Add(i.gameObject);
                }
                else
                {
                    GetSelectedParentNode(i.Nodes, gameObjects);
                }
            }
        }

        public static string GetScriptString(ObjectReader reader)
        {
            if (scriptDumper == null)
            {
                var openFolderDialog = new OpenFolderDialog();
                openFolderDialog.Title = "Select Assembly Folder";
                if (openFolderDialog.ShowDialog() == DialogResult.OK)
                {
                    scriptDumper = new ScriptDumper(openFolderDialog.Folder);
                }
                else
                {
                    scriptDumper = new ScriptDumper();
                }
            }

            return scriptDumper.DumpScript(reader);
        }
    }
}
