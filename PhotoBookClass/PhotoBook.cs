using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoBookClass
{
    internal class PhotoBook
    {

        private int numPages;

        public int GetNumberPages()
        {
            return numPages;
        }

        public PhotoBook()
        {
                numPages = 16;
        }

        //public PhotoBook(int pages)
        //{
        //   //numPages = pages;
           
        //}


        internal int Pgs { get; set; }
       

        public void SetPgs(int pgs)
        {
            Pgs = pgs;
        }




    }
}
