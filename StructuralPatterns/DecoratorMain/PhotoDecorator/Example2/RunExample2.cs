using PhotoDecorator.ConcreteClasses;
using System;
using System.Drawing;

using System.Windows.Forms;

namespace PhotoDecorator.Example2
{
    public static class ExampleProgram2
    {
        public static void RunExample2()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Photo2 photo;
            TaggedPhoto2 foodTaggedPhoto, colorTaggedPhoto, tag;
            BorderedPhoto2 composition;
            // Compose a photo with two TaggedPhotos and a blue BorderedPhoto
            photo = new Photo2();
            Application.Run(photo);

            foodTaggedPhoto = new TaggedPhoto2(photo, "Food");
            colorTaggedPhoto = new TaggedPhoto2(foodTaggedPhoto, "Yellow");
            composition = new BorderedPhoto2(colorTaggedPhoto, Color.Blue);
            Application.Run(composition);

            Console.WriteLine(colorTaggedPhoto.ListTaggedPhotos());
            // Compose a photo with one TaggedPhoto and a yellow BorderedPhoto
            photo = new Photo2();
            tag = new TaggedPhoto2(photo, "Jug");
            composition = new BorderedPhoto2(tag, Color.Yellow);
            Application.Run(composition);
        }
    }
}
