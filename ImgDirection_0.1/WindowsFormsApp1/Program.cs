using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Security.AccessControl;
using System.Security.Principal;
using System.IO;

namespace WindowsFormsApp1
{
    static class Program
    {
        public const string mainTitle = "Image Piler";
        public const string curVersion = "ver0.11";

        /**
         * 180505 - 1. EXIF successful
         *      EXIF orientation id : 0x112
         *      Note that EXIF orientation id includes the 'flip' information.
         *      
         *      core code if changing EXIF id : 
         *      
                 *      var prop = loadedImage.GetPropertyItem(exifOrientationID);
                 *      prop.Id = exifOrientationID;
                        prop.Value[0] = 0x06;
                        loadedImage.SetPropertyItem(prop);
                        loadedImage.Save("save name");
         *      
         *      */
                    

        /**
         * 180504 - Tried methods :
         * 1. Creating a new bitmap image that swaps the width and the height of the original image
         *      and by using the 'Graphics' of c#, changes the transform, rotates, and change the position back to is original point.
         *      but this resulted in incorrect position - which is actually my mathmatical problem.
         *      Forgot about what the quality of the rotated image was like. Worth trying once again if everythingelse doest not work out.
         * 2. The 'Image' component is able to use its own method; (Image).RotateFlip(RotateFlipType)
         *      But when it's rotated, an image of 3Mb is enlarged into a 15Mb image file or 18Mb image file. Dumb
         * 
         * 3. Currently Trying to change the EXIF property - which contains the information of images such as the date taken, or the camera, distance of focal point, and so on.
         *      This is a meta data of images, and called as 'EXIF'. And fortuantely, this contains 'Orientation' property. but so far, it's impossible to set only the 
         *      orientation property in which i want it to be changed as.
         *      So i need more work on this on 180505
         *      */

        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }

        

    }

    
}
