using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderVisualizer.DirectoryClasses
{
    internal class DirectoryManager
    {
        public static MyDirectory extractDirectoryFiles(string directoryPath) 
        {

                string dirName = Path.GetFileName(directoryPath);
                MyFolder root = new MyFolder(dirName);

                string[] directories = Directory.GetDirectories(directoryPath); // returns an array of all directories paths

                foreach (string dirPath in directories)
                {
                    MyDirectory folder = extractDirectoryFiles(dirPath); // recursive step (since it is a directory, so it might contain other files)
                    root.add(folder);
                }

                string[] files = Directory.GetFiles(directoryPath); // returns an array of all files paths

                foreach (string filePath in files)
                {
                    FileInfo fileInfo = new FileInfo(filePath);

                    string fileName = fileInfo.Name;
                    string fileExtention = fileInfo.Extension;
                    int fileSize = (int)fileInfo.Length / (1024 * 1024);

                    root.add(new MyFile(fileName, fileExtention, fileSize));
                }

            return root;

        }

        public static (List<string>, List<int>) extractDirectoryInfo(MyDirectory mainDirectory, string directoryName)
        {

            List<string> names = new List<string>();
            List<int> sizes = new List<int>();

            MyDirectory selectedDirectory = mainDirectory.findDirectory(directoryName);

            if (selectedDirectory == null)
            {
                return (names, sizes);
            }


            if (selectedDirectory is MyFolder)
            {
                foreach (MyDirectory file in ((MyFolder)selectedDirectory).getFiles())
                {
                    names.Add(file.getName());
                    sizes.Add(file.getSize());
                }
            }
            else if (selectedDirectory is MyFile)
            {
                names.Add(selectedDirectory.getName());
                sizes.Add(selectedDirectory.getSize());
            }

            return (names, sizes);
        }

    }
}
