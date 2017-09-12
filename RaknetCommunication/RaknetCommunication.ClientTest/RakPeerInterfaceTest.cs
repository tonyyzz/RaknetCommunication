using RakNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RaknetCommunication.ClientTest
{
    public class RakPeerInterfaceTest
    {
        public void Do()
        {



            ushort clientPort = 60004;
            ushort serverPort = 60003;



            RakPeerInterface testClient = RakPeerInterface.GetInstance();
            NatPunchthroughClient natPunchthroughClient = new NatPunchthroughClient();
            testClient.AttachPlugin(natPunchthroughClient);
            var startUpResult = testClient.Startup(1, new SocketDescriptor(clientPort, "127.0.0.1"), 1);
            var connectResult = testClient.Connect("127.0.0.1", serverPort, "", 0);



            ConsoleCloseHandler.serverPort = serverPort;
            ConsoleCloseHandler.testClient = testClient;
            ConsoleCloseHandler.SetConsoleCtrlHandler(ConsoleCloseHandler.cancelHandler, true);

            while (true)
            {
                Console.WriteLine("请输入");
                string str = Console.ReadLine();

                if (str == "0")
                {
                    Console.WriteLine("断开连接");
                    testClient.CloseConnection(new AddressOrGUID(new SystemAddress("127.0.0.1", serverPort)), true);
                    Thread.Sleep(10);
                    RakPeerInterface.DestroyInstance(testClient);
                    return;
                }

                using (BitStream bitStream = new BitStream())
                {
                    String sendString = string.Format(@"{0}", str);
                    bitStream.Write((byte)DefaultMessageIDTypes.ID_USER_PACKET_ENUM);

                    bitStream.Write(sendString);

                    //bitStream.WriteFloat16(66, 10, 100);

                    var f = bitStream.GetData();

                    //var ff = bitStream.GetNumberOfBitsUsed();
                    var ff2 = bitStream.GetNumberOfBytesUsed();
                    //bitStream

                    //bool t = false;

                    //var falg = bitStream.Serialize(true, ref t);

                    //bitStream.Write

                    var ffff = PacketLogger.BaseIDTOString(2);

                    //var time= RakNet.RakNet.GetTimeUS();

                    NetworkIDObject networkIDObject = new NetworkIDObject();
                    networkIDObject.SetNetworkIDManager(new NetworkIDManager());
                    var gg = networkIDObject.GetNetworkID();  //yes
                    var dd = networkIDObject.GetNetworkIDManager();


                    //bitStream

                    //RakString testRakString = new RakString("Test RakString");
                    //rakStringTestSendBitStream.Write((byte)DefaultMessageIDTypes.ID_USER_PACKET_ENUM);
                    //rakStringTestSendBitStream.Write(testRakString);

                    //SystemAddress sa = RakNet.RakNet.UNASSIGNED_SYSTEM_ADDRESS;
                    testClient.Send(bitStream, PacketPriority.IMMEDIATE_PRIORITY, PacketReliability.RELIABLE_ORDERED, (char)0, new AddressOrGUID(new SystemAddress("127.0.0.1", serverPort)), false);
                    //testClient.Send(str, str.Length + 1, PacketPriority.LOW_PRIORITY, 
                    //    PacketReliability.RELIABLE_ORDERED, (char)0, 
                    //    new AddressOrGUID(new SystemAddress("127.0.0.1", serverPort)), false);




                }
            }

        }
    }
}
