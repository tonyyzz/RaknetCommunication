using System;
using System.Collections.Generic;


namespace BaseCommon
{
	public enum MainCommand
	{
		/// <summary>
		/// 错误
		/// </summary>
		MC_ERROR = 0,
		/// <summary>
		/// 账号
		/// </summary>
		MC_ACCOUNT = 1,
		/// <summary>
		/// 通告
		/// </summary>
		MC_ANNUNCIATE = 2,
		/// <summary>
		/// 资源
		/// </summary>
		MC_RESOURCE = 3,
		/// <summary>
		/// 评论
		/// </summary>
		MC_COMMENT = 4,
		/// <summary>
		/// 房间
		/// </summary>
		MC_HOUSE = 5,
		/// <summary>
		/// 朋友
		/// </summary>
		MC_FRIEND = 6,
		/// <summary>
		/// avatar
		/// </summary>
		MC_AVATAR = 7,
		/// <summary>
		/// p2p通讯
		/// </summary>
		MC_P2P = 8,
		/// <summary>
		/// udpAgent
		/// </summary>
		MC_UDPAGENT = 9,
	}
	public enum SecondCommand //不要超过 32767 因为会溢出，会和short转换
	{
		#region 错误相关
		SC_ERROR_hall = 1, //大厅服务器错误
		#endregion

		#region 账户相关
		SC_ACCOUNT_login = 100, //登录
		SC_ACCOUNT_login_ret = 101,
		SC_ACCOUNT_playerInfo = 102, //玩家粗略信息
		SC_ACCOUNT_playerInfo_ret = 103,
		SC_ACCOUNT_playerAttention = 104, //玩家关注
		SC_ACCOUNT_playerAttention_ret = 105,
		SC_ACCOUNT_playerDetail = 106, //玩家详细信息
		SC_ACCOUNT_playerDetail_ret = 107,
		SC_ACCOUNT_playerEditSex = 108, //更新性别
		SC_ACCOUNT_playerEditSex_ret = 109,
		SC_ACCOUNT_playerEditDescription = 110, //更新介绍
		SC_ACCOUNT_playerEditDescription_ret = 111,
		SC_ACCOUNT_playerEditName = 112, //更新名称
		SC_ACCOUNT_playerEditName_ret = 113,
		#endregion

		#region 通告相关
		SC_ANNUNCIATE_list = 300, //通告列表
		SC_ANNUNCIATE_list_ret = 301,
		#endregion

		#region 资源相关
		SC_RESOURCE_tagList = 400, //资源标签列表
		SC_RESOURCE_tagList_ret = 401,
		SC_RESOURCE_list = 402, //资源列表
		SC_RESOURCE_list_ret = 403,
		SC_RESOURCE_detail = 404, //资源详情
		SC_RESOURCE_detail_ret = 405,
		SC_RESOURCE_upload = 406, //资源上传接口
		SC_RESOURCE_upload_ret = 407,
		SC_RESOURCE_pointsLike = 408, //资源点赞接口
		SC_RESOURCE_pointsLike_ret = 409,
		SC_RESOURCE_score = 410, //资源评分接口
		SC_RESOURCE_score_ret = 411,
		SC_RESOURCE_download = 412, //资源下载接口
		SC_RESOURCE_download_ret = 413,
		#endregion

		#region 评论相关
		SC_COMMENT_list = 600, //评论列表
		SC_COMMENT_list_ret = 601,
		SC_COMMENT_operate = 602, //评论操作
		SC_COMMENT_operate_ret = 603,
		SC_COMMENT_replyOperate = 604, //评论回复操作
		SC_COMMENT_replyOperate_ret = 605,
		#endregion

		#region 房间相关
		SC_HOUSE_create = 800, //创建房间
		SC_HOUSE_create_ret = 801,
		SC_HOUSE_list = 802, //房间列表
		SC_HOUSE_list_ret = 803,
		SC_HOUSE_info = 804, //房间信息
		SC_HOUSE_info_ret = 805,
		SC_HOUSE_join = 806, //房间加入
		SC_HOUSE_join_ret = 807,
		SC_HOUSE_portSet = 808, //房间udp端口设置
		SC_HOUSE_portSet_ret = 809,
		SC_HOUSE_close = 810, //房间关闭
		SC_HOUSE_close_ret = 8011,
		#endregion

		#region 朋友相关
		SC_FRIEND_list = 1000, //朋友列表
		SC_FRIEND_list_ret = 1001,
		SC_FRIEND_searchAdd = 1002, //搜索添加好友
		SC_FRIEND_searchAdd_ret = 1003,
		SC_FRIEND_requestAdd = 1004, //好友申请添加
		SC_FRIEND_requestAdd_ret = 1005,
		SC_FRIEND_requestList = 1006, //好友申请列表
		SC_FRIEND_requestList_ret = 1007,
		SC_FRIEND_requestAgreeOrDisagree = 1008, //好友申请接受/拒绝
		SC_FRIEND_requestAgreeOrDisagree_ret = 1009,
		SC_FRIEND_detail = 1010, //朋友详情
		SC_FRIEND_detail_ret = 1011,
		SC_FRIEND_delete = 1012, //朋友删除
		SC_FRIEND_delete_ret = 1013,
		SC_FRIEND_recommend = 1014, //好友推荐列表
		SC_FRIEND_recommend_ret = 1015,
		SC_FRIEND_chat = 1016, //好友聊天
		SC_FRIEND_chat_ret = 1017,
		SC_FRIEND_chat_ret_other = 1018, //另一方接收消息
		#endregion

		#region avatar相关
		SC_AVATAR_backpackGoods = 1200, //玩家背包物品
		SC_AVATAR_backpackGoods_ret = 1201,
		SC_AVATAR_disguiseSet = 1202, //设置玩家装扮
		SC_AVATAR_disguiseSet_ret = 1203,
		SC_AVATAR_changeModelSex = 1204, //切换model性别
		SC_AVATAR_changeModelSex_ret = 1205,
		#endregion

		#region p2p通讯
		SC_P2P_MsgDfToServer = 1400,
		SC_P2P_msgPlayerLoginUdpServer = 1401,
		SC_P2P_msgTextToServer = 1402, //文本消息
		SC_P2P_msgTextToClient = 1403,
		SC_P2P_msgTextToClientRet = 1404,
		SC_P2P_msgPlayerInfoToClient = 1405,
		SC_P2P_msgPlayerLeaveToServer = 1406, //玩家离开房间（不是房主操作）
		SC_P2P_msgPlayerLeaveToClient = 1407, //玩家离开房间（不是房主操作）
		SC_P2P_msgServerCloseToClient = 1408,
		#endregion

		#region uspAgent
		SC_UDPAGENT_login = 1600, //登录代理服务器
		SC_UDPAGENT_test = 1601,
		SC_UDPAGENT_testToUdpServer = 1602,
		SC_UDPAGENT_testUdpServerToUdpAgentServer = 1603,
		SC_UDPAGENT_testUdpAgentServerToUdpClient = 1604,
		#endregion
	}

	/// <summary>
	/// 错误消息
	/// </summary>
	public enum Error
	{
		/// <summary>
		/// 已经在登录中
		/// </summary>
		login_isIn = 1,
		/// <summary>
		/// 评论字数超出范围
		/// </summary>
		comment_outofLength = 2,
		/// <summary>
		/// 回复字数超出范围
		/// </summary>
		reply_outofLength = 3,
	}
}
