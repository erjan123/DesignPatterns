using PhotoDecorator.ConcreteClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoDecorator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            // Application.Run(new Photo());
            // Application.Run acts as a simple client
            Photo photo;
            TaggedPhoto foodTaggedPhoto, colorTaggedPhoto, tag;
            BorderedPhoto composition;
            // Compose a photo with two TaggedPhotos and a blue BorderedPhoto
            photo = new Photo();
            Application.Run(photo);

            foodTaggedPhoto = new TaggedPhoto(photo, "Food");
            colorTaggedPhoto = new TaggedPhoto(foodTaggedPhoto, "Yellow");
            composition = new BorderedPhoto(colorTaggedPhoto, Color.Blue);
            Application.Run(composition);

            Console.WriteLine(colorTaggedPhoto.ListTaggedPhotos());
            // Compose a photo with one TaggedPhoto and a yellow BorderedPhoto
            photo = new Photo();
            tag = new TaggedPhoto(photo, "Jug");
            composition = new BorderedPhoto(tag, Color.Yellow);
            Application.Run(composition);
        }
    }
}
