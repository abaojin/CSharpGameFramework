﻿using System;

using SLua;
using System.Collections.Generic;
public class Lua_GameFrameworkMessage_ServerShutdown : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			GameFrameworkMessage.ServerShutdown o;
			o=new GameFrameworkMessage.ServerShutdown();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"GameFrameworkMessage.ServerShutdown");
		createTypeMetatable(l,constructor, typeof(GameFrameworkMessage.ServerShutdown));
	}
}
