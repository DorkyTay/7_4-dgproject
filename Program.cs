using System;

namespace _7_4_dgproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from 7_4dgproject");

            // Testing the classes
            // Create 2 Dating Profiles
            DatingProfile datingProfile1 = new DatingProfile("Paul", "Hopkins", 25, "Male");
            datingProfile1.WriteBio("Nice guy with a big heart.");

            DatingProfile datingProfile2 = new DatingProfile("Denise", "Smith", 24, "Female");
            datingProfile2.WriteBio("Looking for fun loving guy to build a legacy with.");

            datingProfile1.SendMessage("Hi Denise, Wanna meet?", "Zoom chat tonight?", datingProfile2);
            datingProfile2.ReadMessage();
        }
    }
}