﻿using System;

using SLua;
using System.Collections.Generic;
public class Lua_GameFrameworkMessage_Msg_CL_RemoveFriend : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			GameFrameworkMessage.Msg_CL_RemoveFriend o;
			o=new GameFrameworkMessage.Msg_CL_RemoveFriend();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_m_FriendGuid(IntPtr l) {
		try {
			GameFrameworkMessage.Msg_CL_RemoveFriend self=(GameFrameworkMessage.Msg_CL_RemoveFriend)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.m_FriendGuid);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_m_FriendGuid(IntPtr l) {
		try {
			GameFrameworkMessage.Msg_CL_RemoveFriend self=(GameFrameworkMessage.Msg_CL_RemoveFriend)checkSelf(l);
			System.UInt64 v;
			checkType(l,2,out v);
			self.m_FriendGuid=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"GameFrameworkMessage.Msg_CL_RemoveFriend");
		addMember(l,"m_FriendGuid",get_m_FriendGuid,set_m_FriendGuid,true);
		createTypeMetatable(l,constructor, typeof(GameFrameworkMessage.Msg_CL_RemoveFriend));
	}
}
