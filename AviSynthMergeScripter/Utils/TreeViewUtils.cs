using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace AviSynthMergeScripter.Utils {

    /// <summary>
    /// Утилиты для работы с деревом TreeView, содержащим пути к папкам и файлам.
    /// </summary>
    public static class TreeViewUtils {

        /// <summary>
        /// Загрузка папки и ее дерева подпапок (и файлов) в список.
        /// Эта папка будет являться единственным корневым узлом списка.
        /// В поле "ToolTipText" каждого узла сохраняется полный путь к папке или файлу.
        /// </summary>
        /// <param name="treeView">Список, в который загружается дерево папок (и файлов).</param>
        /// <param name="inputFolderPath">Путь к загружаемой папке.</param>
        /// <param name="loadFiles">Флаг, указывающий, требуется ли загружать файлы в список.</param>
        /// <param name="searchPattern">Шаблон для поиска файлов.</param>
        public static void LoadFolderToTreeView(TreeView treeView, string inputFolderPath, bool loadFiles, string searchPattern) {
            treeView.Nodes.Clear();
            if (!PathUtils.IsValidPath(inputFolderPath)) {
                throw new FormatException("Некорректный формат пути.");
            }
            if (!Directory.Exists(inputFolderPath)) {
                throw new FormatException("Путь не существует.");
            }
            try {
                TreeNode node = new TreeNode(PathUtils.GetLastName(inputFolderPath));
                node.ToolTipText = PathUtils.GetFormattedPath(inputFolderPath);
                treeView.Nodes.Add(node);
                LoadFolderToNode(node, inputFolderPath, loadFiles, searchPattern);
            }
            catch (Exception e) {
                treeView.Nodes.Clear();
                throw e;
            }
        }

        /// <summary>
        /// Добавление дочерних узлов и соответствующих им подпапок (и файлов) для указанного узла (рекурсивно).
        /// </summary>
        /// <param name="node">Узел, для которого требуется добавить подпапки (и файлы).</param>
        /// <param name="folderPath">Путь к папке.</param>
        /// <param name="loadFiles">Флаг, указывающий, требуется ли загружать файлы в список.</param>
        /// <param name="searchPattern">Шаблон для поиска файлов.</param>
        private static void LoadFolderToNode(TreeNode node, string folderPath, bool loadFiles, string searchPattern) {
            try {
                foreach (string subFolderPath in Directory.GetDirectories(folderPath)) {
                    TreeNode subNode = new TreeNode(PathUtils.GetLastName(subFolderPath));
                    subNode.ToolTipText = PathUtils.GetFormattedPath(subFolderPath);
                    node.Nodes.Add(subNode);
                    LoadFolderToNode(subNode, subFolderPath, loadFiles, searchPattern);
                }
                if (loadFiles) {
                    foreach (string filePath in Directory.GetFiles(folderPath, searchPattern)) {
                        TreeNode subNode = new TreeNode(PathUtils.GetLastName(filePath));
                        subNode.ToolTipText = filePath;
                        node.Nodes.Add(subNode);
                    }
                }
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// Установка значения поля "Checked" для дочерних узлов на всех подуровнях указанного узла (рекурсивно).
        /// Значение поля "Checked" для дочерних узлов устанавливается такое же как в указанном узле.
        /// </summary>
        /// <param name="node">Узел, для дочерних узлов которого требуется установить значение поля "Checked".</param>
        /// <param name="action">Тип действия, вызывающего метод.</param>
        public static void SetCheckStateOfChildNodes(TreeNode node, TreeViewAction action) {
            if ((action == TreeViewAction.ByKeyboard) || (action == TreeViewAction.ByMouse)) {
                foreach (TreeNode childNode in node.Nodes) {
                    childNode.Checked = node.Checked;
                    SetCheckStateOfChildNodes(childNode, action);
                }
            }
        }
        
        /// <summary>
        /// Установка значения поля "Checked" для родительских узлов на всех надуровнях указанного узла (рекурсивно).
        /// Значение поля "Checked" для родительских узлов устанавливается true, если 
        /// </summary>
        /// <param name="node">Узел, для родительских узлов которого требуется установить значение поля "Checked".</param>
        /// <param name="action">Тип действия, вызывающего метод.</param>
        public static void SetCheckStateOfParentNodes(TreeNode node, TreeViewAction action) {
            if ((action == TreeViewAction.ByKeyboard) || (action == TreeViewAction.ByMouse)) {
                if (node.Parent != null) {
                    if (GetCheckStateOfChildNodes(node.Parent)) {
                        node.Parent.Checked = true;
                        SetCheckStateOfParentNodes(node.Parent, TreeViewAction.ByKeyboard);
                    }
                }
            }
        }

        /// <summary>
        /// Определение значений полей "Checked" для дочерних узлов на всех подуровнях указанного узла (рекурсивно).
        /// </summary>
        /// <param name="node">Узел, для дочерних узлов которого требуется определить значения полей "Checked".</param>
        /// <returns>Возвращает true, если среди дочерних узлов есть хотя бы один узел со значением поля "Checked" равным true.</returns>
        private static bool GetCheckStateOfChildNodes(TreeNode node) {
            foreach (TreeNode childNode in node.Nodes) {
                if (childNode.Checked || GetCheckStateOfChildNodes(childNode)) {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Выбор в виде списка отмеченных путей из дерева.
        /// Пути могут указывать и на папки, и на файлы.
        /// Значение пути загружается из поля "ToolTipText" каждого узла.
        /// </summary>
        /// <param name="treeView">Обрабатываемое дерево.</param>
        /// <returns>Список отмеченных путей из дерева. null, если дерево не содержит узлов, или если не отмечен корневой узел дерева.</returns>
        public static List<string> GetCheckedPathes(TreeView treeView) {
            if (treeView.Nodes.Count == 0) {
                return null;
            }
            if (!treeView.Nodes[0].Checked) {
                return null;
            }
            List<string> list = new List<string>();
            AddCheckedPathesToList(treeView.Nodes[0], list);
            return list;
        }

        /// <summary>
        /// Добавление отмеченных путей в список для указанного узла дерева (рекурсивно).
        /// </summary>
        /// <param name="node">Обрабатываемый узел дерева.</param>
        /// <param name="list">Список, в который требуется добавлять отмеченные пути.</param>
        private static void AddCheckedPathesToList(TreeNode node, List<string> list) {
            if (node.Checked) {
                list.Add(node.ToolTipText);
                foreach (TreeNode childNode in node.Nodes) {
                    if (childNode.Checked) {
                        AddCheckedPathesToList(childNode, list);
                    }
                }
            }
        }

        /// <summary>
        /// Выбор в виде списка отмеченных путей к папкам из дерева.
        /// Выбираются пути, указывающие только на папки.
        /// Значение пути загружается из поля "ToolTipText" каждого узла.
        /// </summary>
        /// <param name="treeView">Обрабатываемое дерево.</param>
        /// <returns>Список отмеченных путей к папкам из дерева. null, если дерево не содержит узлов, или если не отмечен корневой узел дерева.</returns>
        public static List<string> GetCheckedFolders(TreeView treeView) {
            List<string> list = GetCheckedPathes(treeView);
            if ((list == null) || (list.Count == 0)) {
                return null;
            }
            List<string> foldersPathesList = new List<string>();
            foreach (string path in list) {
                if (Directory.Exists(path)) {
                    foldersPathesList.Add(path);
                }
            }
            return foldersPathesList;
        }

        /// <summary>
        /// Выбор в виде списка отмеченных путей к файлам из дерева.
        /// Выбираются пути, указывающие только на файлы.
        /// Значение пути загружается из поля "ToolTipText" каждого узла.
        /// </summary>
        /// <param name="treeView">Обрабатываемое дерево.</param>
        /// <returns>Список отмеченных путей к файлам из дерева. null, если дерево не содержит узлов, или если не отмечен корневой узел дерева.</returns>
        public static List<string> GetCheckedFiles(TreeView treeView) {
            List<string> list = GetCheckedPathes(treeView);
            if ((list == null) || (list.Count == 0)) {
                return null;
            }
            List<string> filesPathesList = new List<string>();
            foreach (string path in list) {
                if (File.Exists(path)) {
                    filesPathesList.Add(path);
                }
            }
            return filesPathesList;
        }

    }

}
