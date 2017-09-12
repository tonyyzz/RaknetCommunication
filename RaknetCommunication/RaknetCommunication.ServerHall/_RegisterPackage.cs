using BaseCommon;
using ServerHall.package;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerHall
{
	class PackageConfig
	{
		/// <summary>
		/// 注册包体
		/// </summary>
		public static void Register()
		{
			#region ------------账号------------
			PackageManage.Instance.RegisterPackage((short)MainCommand.MC_ACCOUNT, (short)SecondCommand.SC_ACCOUNT_login, new PlayerLoginPacket());
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_ACCOUNT, (short)SecondCommand.SC_ACCOUNT_playerInfo, new PlayerInfoPacket());
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_ACCOUNT, (short)SecondCommand.SC_ACCOUNT_playerAttention, new PlayerAttentionPacket());
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_ACCOUNT, (short)SecondCommand.SC_ACCOUNT_playerDetail, new PlayerDetailPacket());
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_ACCOUNT, (short)SecondCommand.SC_ACCOUNT_playerEditSex, new PlayerEditSexPacket());
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_ACCOUNT, (short)SecondCommand.SC_ACCOUNT_playerEditDescription, new PlayerEditDescriptionPacket());
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_ACCOUNT, (short)SecondCommand.SC_ACCOUNT_playerEditName, new PlayerEditNamePacket());
			#endregion

			//#region ------------通告------------
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_ANNUNCIATE, (short)SecondCommand.SC_ANNUNCIATE_list, new AnnunciateListPacket());
			//#endregion

			//#region ------------资源------------
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_RESOURCE, (short)SecondCommand.SC_RESOURCE_tagList, new ResourceTagListPacket());
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_RESOURCE, (short)SecondCommand.SC_RESOURCE_list, new ResourceListPacket());
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_RESOURCE, (short)SecondCommand.SC_RESOURCE_detail, new ResourceDetailPacket());
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_RESOURCE, (short)SecondCommand.SC_RESOURCE_upload, new ResourceUploadPacket());
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_RESOURCE, (short)SecondCommand.SC_RESOURCE_download, new ResourceDownloadPacket());
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_RESOURCE, (short)SecondCommand.SC_RESOURCE_pointsLike, new ResourcePointsLikePacket());
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_RESOURCE, (short)SecondCommand.SC_RESOURCE_score, new ResourceScorePacket());
			//#endregion

			//#region ------------评论------------
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_COMMENT, (short)SecondCommand.SC_COMMENT_list, new CommentListPacket());
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_COMMENT, (short)SecondCommand.SC_COMMENT_operate, new CommentOperatePacket());
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_COMMENT, (short)SecondCommand.SC_COMMENT_replyOperate, new CommentReplyOperatePacket());
			//#endregion

			//#region ------------房间------------
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_HOUSE, (short)SecondCommand.SC_HOUSE_create, new HouseCreatePacket());
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_HOUSE, (short)SecondCommand.SC_HOUSE_list, new HouseListPacket());
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_HOUSE, (short)SecondCommand.SC_HOUSE_info, new HouseInfoPacket());
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_HOUSE, (short)SecondCommand.SC_HOUSE_join, new HouseJoinPacket());
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_HOUSE, (short)SecondCommand.SC_HOUSE_portSet, new HousePortSetPacket());
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_HOUSE, (short)SecondCommand.SC_HOUSE_close, new HouseClosePacket());
			//#endregion

			//#region ------------朋友------------
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_FRIEND, (short)SecondCommand.SC_FRIEND_list, new FriendListPacket());
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_FRIEND, (short)SecondCommand.SC_FRIEND_searchAdd, new FriendSearchAddListPacket());
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_FRIEND, (short)SecondCommand.SC_FRIEND_requestAdd, new FriendRequestAddPacket());
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_FRIEND, (short)SecondCommand.SC_FRIEND_requestList, new FriendRequestListPacket());
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_FRIEND, (short)SecondCommand.SC_FRIEND_requestAgreeOrDisagree, new FriendReqAgreeOrDisagreePacket());
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_FRIEND, (short)SecondCommand.SC_FRIEND_detail, new FriendDetailPacket());
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_FRIEND, (short)SecondCommand.SC_FRIEND_delete, new FriendDeletePacket());
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_FRIEND, (short)SecondCommand.SC_FRIEND_recommend, new FriendRecommendPacket());
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_FRIEND, (short)SecondCommand.SC_FRIEND_chat, new FriendChatPacket());
			//#endregion

			//#region ------------avatar------------
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_AVATAR, (short)SecondCommand.SC_AVATAR_backpackGoods, new AvatarBackpackGoodsPacket());
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_AVATAR, (short)SecondCommand.SC_AVATAR_disguiseSet, new AvatarDisguiseSetPacket());
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_AVATAR, (short)SecondCommand.SC_AVATAR_changeModelSex, new AvatarChangeModelSexPacket());
			//#endregion

			//#region udpAgent
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_UDPAGENT, (short)SecondCommand.SC_UDPAGENT_login, new UdpAgentLoginPacket());
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_UDPAGENT, (short)SecondCommand.SC_UDPAGENT_test, new UdpAgentTestPacket());
			//PackageManage.Instance.RegisterPackage((short)MainCommand.MC_UDPAGENT, (short)SecondCommand.SC_UDPAGENT_testUdpServerToUdpAgentServer, new UdpAgentTestUdpServerToUdpAgentServerPacket());
			//#endregion
		}
	}
}
