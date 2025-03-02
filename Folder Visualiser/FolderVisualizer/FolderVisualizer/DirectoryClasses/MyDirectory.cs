using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderVisualizer.DirectoryClasses
{
    internal interface MyDirectory
    {
        public void display(int depth);

        public string getName();

        public int getSize();

        public MyDirectory findDirectory(string name);

        public static MyDirectory extractFiles(string path)
        {
            return DirectoryManager.extractDirectoryFiles(path);
        }

        public static (List<string>, List<int>) extractInfo(MyDirectory mainDirectory, string directoryName)
        {
            return DirectoryManager.extractDirectoryInfo(mainDirectory, directoryName);
        }


    }
}
