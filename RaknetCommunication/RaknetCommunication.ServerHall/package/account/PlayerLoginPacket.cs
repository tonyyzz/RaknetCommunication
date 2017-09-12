using BaseCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerHall.package
{
	/// <summary>
	/// 大厅登录
	/// </summary>
	class PlayerLoginPacket : Package
	{
		public PlayerLoginPacket() { }
		public PlayerLoginPacket(byte[] buffer, int msgLen, MainCommand mainid, SecondCommand secondid) : base(buffer, msgLen, mainid, secondid)
		{
			//自定义接收数据的缓冲区大小
			//m_Buffer = new AutoBuffer(1024 * 1024);
		}
		public override Package Clone()
		{
			Package pack = new PlayerLoginPacket(null, 0,
				MainCommand.MC_ACCOUNT, SecondCommand.SC_ACCOUNT_login);
			return pack;
		}
		//public override void ReadPackage() { }
		//public override void WritePackage() { }
		public override void Excute()
		{
			int pid = ReadInt();//玩家Id

			//if (pid <= 0)
			//{
			//	return;
			//}
			//Model.PlayerModel player = PlayerManager.playerOnlineList.FirstOrDefault(m => m.Id == pid);
			//if (player == null)
			//{
			//	player = BLL.PlayerBLL.QuerySingle(pid);
			//}
			//if (player == null)
			//{
			//	Console.WriteLine("不存在该玩家：{0}", pid);
			//	return;
			//}
			//if (player != null && player.online)
			//{
			//	//该玩家已经在线，请更换其他账号
			//	Console.WriteLine(" tcp - 玩家【{0}】已经在登录中，请稍后再试！", player.Id);
			//	Package pack2 = new Package(MainCommand.MC_ERROR, SecondCommand.SC_ERROR_hall);
			//	pack2.Write((int)Error.login_isIn);
			//	TcpServerManager.Instance.Send(session.ConnId, pack2);
			//	return;
			//}
			//session.player = player;
			//player.Online(session);
			//Console.WriteLine(string.Format(@" tcp - -------------玩家【{0}】在【{1}】时上线了----------------", player.Id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));

			//int modelSexInt = player.ModelSex;
			//if (!new List<int> { 1, 2 }.Any(m => m == modelSexInt))
			//{
			//	modelSexInt = 1;
			//}

			//Package pack = new Package(MainCommand.MC_ACCOUNT, SecondCommand.SC_ACCOUNT_login_ret);
			//pack.Write(player.Id);
			//pack.Write(player.Name);
			//pack.Write(player.Sex);
			////pack.Write(playerModel.HeadImg);
			//pack.Write(player.Money);
			//pack.Write(player.Level);
			//pack.Write(modelSexInt); //模型性别 1：男，2：女

			////装扮信息
			////var modelSexInt = player.ModelSex;
			////if (new List<int>() { 1, 2 }.Any(m => m == modelSexInt))
			////{
			////	modelSexInt = 1;
			////}
			////var disguiseModel = BLL.PlayerDisguiseBLL.GetPlayerDisguise(player.Id, modelSexInt);
			////pack.Write(disguiseModel != null ? 1 : 0); //是否有装扮
			////if (disguiseModel != null)
			////{
			////	pack.Write(disguiseModel);
			////}
			//player.SendMsg(pack);
		}
	}
}
