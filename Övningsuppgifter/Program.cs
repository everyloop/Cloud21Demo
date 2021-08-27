using System;

namespace Övningsuppgifter
{
    class Program
    {
        static void Main(string[] args)
        {
            byte myByte = 100; // 0x64
            int myInt = myByte; // 0x00000064

            int myOtherInt = 260; // 0x00000104
            byte myOtherByte = (byte)myOtherInt; //0x04

            float myFloat = 5.8f;
            byte myThirdByte = (byte)myFloat;

            byte myFourthByte = Convert.ToByte(myFloat);

            float myOtherFloat = float.Parse("234,4");
        }
    }
}
