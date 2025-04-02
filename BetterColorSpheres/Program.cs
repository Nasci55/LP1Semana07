using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace BetterColorSpheres
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Color color1 = new Color(30, 255, 140);
            Sphere sphere = new Sphere(color1, 5);


            sphere.Throw();
            sphere.Throw();
            sphere.Pop();
            sphere.Throw();

            System.Console.Write($"The ball with the color {color1.GetGrey}");
            System.Console.Write($" was thrown: {sphere.GetTimesThrown} times");
        }
    }
}
