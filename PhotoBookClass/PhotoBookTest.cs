using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoBookClass
{
    public static class PhotoBookTest
    {
        public static void Main() { 
        PhotoBook defPhotoBook = new PhotoBook();
            Console.WriteLine($"{defPhotoBook.GetNumberPages()}");
        

        PhotoBook photoBook24 = new PhotoBook();
            photoBook24.SetPgs(24);
            Console.WriteLine($"{photoBook24.Pgs}");

        BigPhotoBook largePhotoBook = new BigPhotoBook();
            Console.WriteLine($"{largePhotoBook.numPages}");
    }

}
}