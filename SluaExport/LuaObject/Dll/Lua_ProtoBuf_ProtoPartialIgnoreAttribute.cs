﻿using System;

using SLua;
using System.Collections.Generic;
public class Lua_ProtoBuf_ProtoPartialIgnoreAttribute : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			ProtoBuf.ProtoPartialIgnoreAttribute o;
			System.String a1;
			checkType(l,2,out a1);
			o=new ProtoBuf.ProtoPartialIgnoreAttribute(a1);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_MemberName(IntPtr l) {
		try {
			ProtoBuf.ProtoPartialIgnoreAttribute self=(ProtoBuf.ProtoPartialIgnoreAttribute)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.MemberName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"ProtoBuf.ProtoPartialIgnoreAttribute");
		addMember(l,"MemberName",get_MemberName,null,true);
		createTypeMetatable(l,constructor, typeof(ProtoBuf.ProtoPartialIgnoreAttribute),typeof(ProtoBuf.ProtoIgnoreAttribute));
	}
}
