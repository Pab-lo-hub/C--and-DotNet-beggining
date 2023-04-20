using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            sbyte mySbyte = 127;
            sbyte mySecondSbyte = -128;
            byte myByte = 255;
            byte mySecondByte = 0;

            short myShort = -32768;
            ushort myUShort = 65535;

            int myInt = 2147483647;
            int mySecondInt = -2147483648;
        }
    }
}