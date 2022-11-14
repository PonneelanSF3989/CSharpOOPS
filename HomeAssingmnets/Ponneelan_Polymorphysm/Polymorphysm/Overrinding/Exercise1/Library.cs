using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1
{
    public abstract class Library
    {
        private  static int s_libraryID = 1000;
        public   string LibraryID { get; set; }

        public abstract string BookName { get; set; }
        
        public abstract string AuthorName { get; set; }
        
        public abstract int BookID {get; set;}

        public Library()
        {
            s_libraryID++;
            LibraryID = "LibID" + s_libraryID;
        }
        public abstract void SetBookIfno();
        public abstract void Display();
        
        
        
         
    }
}