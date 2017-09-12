using RaknetCommunication.SwigRaknetCS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaknetCommunication.ClientTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string errorMsg = "";
            bool flag = SwigRaknetCSPreInit.JudgeRaknetRun(out errorMsg);
            if (!flag)
            {
                Console.WriteLine(errorMsg);
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Client测试通过");

            new RakPeerInterfaceTest().Do();

            Console.Read();
        }
    }
}
