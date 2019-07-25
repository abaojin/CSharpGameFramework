﻿using System;

using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_WaitUntil : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.WaitUntil o;
			System.Func<System.Boolean> a1;
			LuaDelegation.checkDelegate(l,2,out a1);
			o=new UnityEngine.WaitUntil(a1);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_keepWaiting(IntPtr l) {
		try {
			UnityEngine.WaitUntil self=(UnityEngine.WaitUntil)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.keepWaiting);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.WaitUntil");
		addMember(l,"keepWaiting",get_keepWaiting,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.WaitUntil),typeof(UnityEngine.CustomYieldInstruction));
	}
}
