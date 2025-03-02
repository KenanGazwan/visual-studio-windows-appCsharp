using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderVisualizer.DirectoryClasses
{
    internal class MyFolder : MyDirectory
    {
        protected string name;

        List<MyDirectory> directoriesList = new List<MyDirectory>();
        
        public MyFolder(string name)
        {
            this.name = name;
        }

        public void add(MyDirectory directory)
        {
            directoriesList.Add(directory);
        }

        public void remove(MyDirectory directory)
        {
            directoriesList.Remove(directory);
        }

        public void display(int depth)
        {

            System.Diagnostics.Debug.WriteLine(new string('-', depth) + name);

            foreach (MyDirectory directory in directoriesList)
            {
                directory.display(depth + 2);
            }
        }

        public string getName()
        {
            return name;
        }

        public int getSize()
        {
            int size = 0;

            foreach (MyDirectory directory in directoriesList)
            {
                size += directory.getSize();
            }

            return size;
        }

        public MyDirectory findDirectory(string name)
        {

            if (this.name == name) // Main Case 
            {
                return this;
            }

            foreach (MyDirectory directory in directoriesList)
            {
                MyDirectory dirFound = directory.findDirectory(name);

                if (directory is MyFolder)
                {

                    if (dirFound != null)
                    {
                        return dirFound;
                    }
                }

                else if (directory is MyFile)
                {
                    if (dirFound != null)
                    {
                        return dirFound;
                    }
                }


            }

            return null;
        }

        public List<MyDirectory> getFiles()
        {
            return directoriesList;
        }



    }
}
