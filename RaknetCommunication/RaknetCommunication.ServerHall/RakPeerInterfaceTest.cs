using RakNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RaknetCommunication.ServerHall
{
    public class RakPeerInterfaceTest
    {
        public void Do()
        {

            ushort serverPort = 60003;

            RakPeerInterface testServer = RakPeerInterface.GetInstance();
            NatPunchthroughServer natPunchthroughServer = new NatPunchthroughServer();
            testServer.AttachPlugin(natPunchthroughServer);
            var result = testServer.Startup(1, new SocketDescriptor(serverPort, "127.0.0.1"), 1);
            testServer.SetMaximumIncomingConnections(1);
            //testServer.setP



            ThreadPool.QueueUserWorkItem(o =>
            {
                while (true)
                {
                    //Console.WriteLine("连接数：" + testServer.NumberOfConnections());

                    using (Packet testPacket = testServer.Receive())
                    {
                        if (testPacket != null && testPacket.data.Count() > 0)
                        {
                            Console.WriteLine("Data[0]:" + testPacket.data[0]);
                        }
                        if (testPacket != null && testPacket.data[0] == (byte)DefaultMessageIDTypes.ID_USER_PACKET_ENUM)
                        {
                            var systemAddress = testPacket.systemAddress; //此为发送者的systemAddress，设置Send()的broadcast参数为true实现广播，发送给其他玩家信息

                            var statistics = testServer.GetStatistics(systemAddress);

                            var guid = testPacket.guid; //发送者的唯一标识，如果使用Router2 pilugin ，则只能用这个作为唯一标识

                            //var str = systemAddress.FromString();

                            using (BitStream bitStream = new BitStream())
                            {

                                string holdingString = "";
                                float holdingString2 = 0;

                                //bitStream.Reset();
                                bitStream.Write(testPacket.data, testPacket.length);
                                bitStream.IgnoreBytes(1);

                                bitStream.Read(out holdingString);
                                bitStream.ReadFloat16(out holdingString2, 10, 100); //lossy



                                Console.WriteLine(" -----   Data: " + holdingString);
                            }
                        }
                        //testServer.DeallocatePacket(testPacket);
                    }
                    Thread.Sleep(1);
                    SystemAddress sa = RakNet.RakNet.UNASSIGNED_SYSTEM_ADDRESS;
                }

            });

            //Console.WriteLine("Send and receive loop using BitStream.\nBitStream read done into RakString");

            Console.Read();
            testServer.Shutdown(300);
            RakPeerInterface.DestroyInstance(testServer);
        }
    }
}
