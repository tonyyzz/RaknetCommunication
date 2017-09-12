using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BaseCommon
{
    //! 消息头
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct MsgHead
    {
        //! 消息长度
        public int msgLen;
        //! 消息主id
        public short msgmainid;
        //! 消息副id
        public short msgsecondid;

    };

    public class Package
    {
        ////! 消息头
        //public MsgHead m_MsgHead;
        ////! 消息数据
        //protected AutoBuffer m_Buffer = new AutoBuffer(1024 * 4);
        ////! 读消息位置
        //protected int m_iPosition;

        protected Session session = null;

        public Package() { }

        //! 发包实例化
        public Package(MainCommand mainid, SecondCommand secondid)
        {
            //m_MsgHead.msgLen = 4;
            //m_MsgHead.msgmainid = (short)mainid;
            //m_MsgHead.msgsecondid = (short)secondid;

            //m_iPosition = 0;
            //Write(m_MsgHead.msgLen);
            //Write(m_MsgHead.msgmainid);
            //Write(m_MsgHead.msgsecondid);

        }
        //! 接收包实例化
        public Package(byte[] buffer, int msgLen, MainCommand mainid, SecondCommand secondid)
        {
            //if (buffer != null && buffer.Length > 0)
            //    m_Buffer.WriteBuffer(buffer, 0, buffer.Length);
            //m_iPosition = 0;

            //if (buffer != null)
            //{
            //    m_MsgHead.msgLen = ReadInt();
            //    m_MsgHead.msgmainid = ReadShort();
            //    m_MsgHead.msgsecondid = ReadShort();
            //}


        }

        //public virtual void ReadPackage() { }
        //public virtual void WritePackage() { }

        public virtual Package Clone()
        {
            return null;
        }

        public virtual void Excute()
        {
            //string str = ReadString();
            //Console.WriteLine("执行包体逻辑:" + str);
        }

        public void Write(int value)
        {
           // m_Buffer.Write(value);

        }

        public void Write(string value)
        {
            //if (string.IsNullOrEmpty(value))
            //    value = string.Empty;

            //m_Buffer.Write(value);

        }


        public int ReadInt()
        {
            //m_iPosition += sizeof(int);
            //return BitConverter.ToInt32(m_Buffer.m_Buffer, m_iPosition - sizeof(int));

            return 1;
        }
    }
}
