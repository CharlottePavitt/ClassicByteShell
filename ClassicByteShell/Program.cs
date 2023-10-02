using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using api.ClassicByte.Application;


namespace ClassicByteShell
{
    class Program
    {
        static void Main(String[] args)
        {
            ClassicByteApplication ca = new ClassicByteApplication();
            Console.WriteLine("ClassicByte Bytecat Workstation \n 版权所有 Copyright <c> 2023 ClassicByte Inc.");
            RunObject r1 = new RunObject(ca.runCode,args);

        }
    }
}
