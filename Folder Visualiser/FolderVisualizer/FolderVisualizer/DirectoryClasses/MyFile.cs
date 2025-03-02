using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderVisualizer.DirectoryClasses
{
    internal class MyFile : MyDirectory
    {
        protected string name;
        protected int size;
        protected string extension;

        public MyFile(string name, string extention, int size)
        {
            this.name = name;
            this.size = size;
            extension = extention;
        }

        public void display(int depth)
        {
            System.Diagnostics.Debug.WriteLine(new string('-', depth) + name);
        }

        public string getName()
        {
            return name;
        }
        
        public int getSize() 
        { 
            return size;
        }

        public MyDirectory findDirectory(string name)
        {
            if (this.name == name)
            {
                return this;
            }

            return null;
        }


    }
}
