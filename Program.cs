using System;

namespace Inheritance_DeBord_Joshua
{
    class Program
    {
        static void Main(string[] args)
        {
            FPS myFPS = new FPS("E", "Minecraft");

            Console.WriteLine(myFPS.Describe());
            myFPS.PlayGame();
            FPS csGo = new FPS("M", "CS:GO");
            Console.WriteLine(csGo.Describe());
            csGo.PlayGame();

        }
    }
}
