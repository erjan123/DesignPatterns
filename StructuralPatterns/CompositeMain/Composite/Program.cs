using Composite.TheoreticalCompositeExample;
using System;
using System.IO;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent<string> album = new Composite<string>("Album");
            IComponent<string> point = album;
            string[] s;
            string command, parameter;
            // Create and manipulate a structure
            StreamReader instream = new StreamReader("Composite.dat");
            do
            {
                string t = instream.ReadLine();
                Console.WriteLine("\t\t\t\t" + t);
                s = t.Split();

                command = s[0];
                if (s.Length > 1) parameter = s[1]; else parameter = null;
                switch (command)
                {
                    case "AddSet":
                        IComponent<string> c = new Composite<string>(parameter);
                        point.Add(c);
                        point = c;
                        break;
                    case "AddPhoto":
                        point.Add(new Component<string>(parameter));
                        break;
                    case "Remove":
                        point = point.Remove(parameter);
                        break;
                    case "Find":
                        point = album.Find(parameter);
                        break;
                    case "Display":
                        Console.WriteLine(album.Display(0));
                        break;
                    case "Quit":
                        break;
                }
            } while (!command.Equals("Quit"));
        }
    }
}
