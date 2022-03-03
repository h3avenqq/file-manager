using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file_manager
{
    public partial class Form1 : Form
    {
        private string inputBoxMsg = "Введите имя файла:";
        private string inputBoxTitle = "Переименовывание";

        private string path;
        private string copyFilePath;

        private bool move = false;
        private bool file = false;
        public Form1()
        {
            InitializeComponent();
            
            FillDriveNodes();
        }

        private void FillDriveNodes()
        {
            try
            {
                foreach(DriveInfo drive in DriveInfo.GetDrives())
                {
                    TreeNode treeNode = new TreeNode { Text = drive.Name };
                    FillTreeNode(treeNode, drive.Name);
                    treeView.Nodes.Add(treeNode);
                }
            }
            catch(Exception ex)
            {}
        }

        private void FillTreeNode(TreeNode treeNode, string path)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(path);
                foreach(var dir in dirs)
                {
                    TreeNode dirNode = new TreeNode();
                    dirNode.Text = dir.Remove(0, dir.LastIndexOf("\\") + 1);
                    treeNode.Nodes.Add(dirNode);
                }
                
            }
            catch (Exception ex)
            {}
        }

        private void FillTreeNodeFile(TreeNode treeNode, string path)
        {
            try
            {
                string[] files = Directory.GetFiles(path);
                foreach (var file in files)
                {
                    TreeNode fileNode = new TreeNode();
                    fileNode.Text = file.Remove(0, file.LastIndexOf("\\") + 1);
                    treeNode.Nodes.Add(fileNode);
                }
            }
            catch (Exception ex)
            { }
        }

        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            string[] dirs;
            string[] files;
            try
            {
                if (Directory.Exists(e.Node.FullPath))
                {
                    dirs = Directory.GetDirectories(e.Node.FullPath);
                    if (dirs.Length != 0)
                    {
                        for (int i = 0; i < dirs.Length; i++)
                        {
                            TreeNode dirNode = new TreeNode(new DirectoryInfo(dirs[i]).Name);
                            FillTreeNode(dirNode, dirs[i]);
                            e.Node.Nodes.Add(dirNode);
                        }
                    }

                    files = Directory.GetFiles(e.Node.FullPath);
                    if(files.Length != 0)
                    {
                        for(int i =0;i < files.Length; i++)
                        {
                            TreeNode fNode = new TreeNode(new FileInfo(files[i]).Name);
                            FillTreeNodeFile(fNode, files[i]);
                            e.Node.Nodes.Add(fNode);
                        }
                    }
                }
            }
            catch (Exception ex)
            {}
        }

        private void treeView_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            string[] dirs;
            string[] files;
            try
            {
                if (Directory.Exists(e.Node.FullPath))
                {
                    dirs = Directory.GetDirectories(e.Node.FullPath);
                    if (dirs.Length != 0)
                    {
                        for (int i = 0; i < dirs.Length; i++)
                        {
                            TreeNode dirNode = new TreeNode(new DirectoryInfo(dirs[i]).Name);
                            FillTreeNode(dirNode, dirs[i]);
                            e.Node.Nodes.Add(dirNode);
                        }
                    }
                }

                files = Directory.GetFiles(e.Node.FullPath);
                if (files.Length != 0)
                {
                    for (int i = 0; i < files.Length; i++)
                    {
                        TreeNode fNode = new TreeNode(new FileInfo(files[i]).Name);
                        FillTreeNodeFile(fNode, files[i]);
                        e.Node.Nodes.Add(fNode);
                    }
                }
            }
            catch (Exception ex)
            {}
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            path = e.Node.FullPath;
            CheckFlag();
        }

        private void toolStripMenuRename_Click(object sender, EventArgs e)
        {
            try
            {
                string[] textPath = path.Split('\\');
                string parentDir = path.TrimEnd(textPath[textPath.Length - 1].ToCharArray());
                string newName = Interaction.InputBox(inputBoxMsg, inputBoxTitle);

                Directory.Move(path, parentDir + newName);
                treeView.SelectedNode.Name = newName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripMenuDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.Delete(path,true);
                treeView.Refresh();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripMenuPaste_Click(object sender, EventArgs e)
        {
            try
            {
                if (file)
                    CopyOrMoveFile();
                else
                    CopyOrMoveFolder();

                treeView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripMenuCopy_Click(object sender, EventArgs e)
        {
            copyFilePath = path;
            move = false;
        }

        private void toolStripMenuCut_Click(object sender, EventArgs e)
        {
            copyFilePath = path;
            move = true;
        }

        private void CheckFlag()
        {
            FileAttributes attr = File.GetAttributes(path);
            if (attr.HasFlag(FileAttributes.Directory))
                file = false;
            else
                file = true;
        }

        private void CopyOrMoveFile()
        {
            string[] pathText = copyFilePath.Split('\\');
            path += "\\" + pathText[pathText.Length - 1];
            if (move)
            {
                File.Move(copyFilePath, path);
            }
            else
            {
                File.Copy(copyFilePath, path);
            }
        }

        private void CopyOrMoveFolder()
        {
            string[] Name = copyFilePath.Split('\\');
            path += "\\" + Name[Name.Length - 1];
            if (move)
            {
                Directory.Move(copyFilePath, path);
            }
            else
            {
                CopyFolder(copyFilePath,path);
            }
        }

        private static void CopyFolder(string sourceDirName, string destDirName)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            DirectoryInfo[] dirs = dir.GetDirectories();

            Directory.CreateDirectory(destDirName);

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string tempPath = Path.Combine(destDirName, file.Name);
                file.CopyTo(tempPath, false);
            }

            foreach (DirectoryInfo subdir in dirs)
            {
                string tempPath = Path.Combine(destDirName, subdir.Name);
                CopyFolder(subdir.FullName, tempPath);
            }
        }

        private void toolStripMenuItemInfo_Click(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                MessageBox.Show($"Время создания: {fileInfo.CreationTime} \nРазмер: " +
                    $"{Math.Round(fileInfo.Length / 1024.0 / 1024.0,1)} МБ");
            }
        }
    }
}
