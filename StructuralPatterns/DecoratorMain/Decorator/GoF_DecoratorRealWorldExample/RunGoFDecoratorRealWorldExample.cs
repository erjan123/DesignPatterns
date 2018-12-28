using DoFactory.GangOfFour.Decorator.RealWorld;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.GoF_DecoratorRealWorldExample
{
    public static class RunGoFDecoratorRealWorldExample
    {
        public static void Run()
        {
            // Create book
            Book book = new Book("Worley", "Inside ASP.NET", 10);
            book.Display();

            // Create video
            Video video = new Video("Spielberg", "Jaws", 23, 92);
            video.Display();

            // Make video borrowable, then borrow and display
            Console.WriteLine("\nMaking video borrowable:");

            Borrowable borrowvideo = new Borrowable(video);
            borrowvideo.BorrowItem("Customer #1");
            borrowvideo.BorrowItem("Customer #2");

            borrowvideo.Display();

            // Wait for user
            Console.ReadKey();
        }
    }
}
