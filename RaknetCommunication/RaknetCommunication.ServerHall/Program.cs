using RaknetCommunication.SwigRaknetCS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerHall
{
    class Program
    {
        static void Main(string[] args)
        {
            //string errorMsg = "";
            //bool flag = SwigRaknetCSPreInit.JudgeRaknetRun(out errorMsg);
            //if (!flag)
            //{
            //    Console.WriteLine(errorMsg);
            //    Console.ReadLine();
            //    return;
            //}

            //Console.WriteLine("Server测试通过");

            //new RakPeerInterfaceTest().Do();

            //Console.ReadLine();


            Console.WriteLine(Environment.NewLine + "******************【我的世界】大厅服务器");
            Console.WriteLine("* 服务器正在启动.......");

            #region 初始化

            #region 注册包体
            PackageConfig.Register();
            #endregion


            #endregion
        }
    }
}
