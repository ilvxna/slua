﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Behaviour : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Behaviour o;
		if(matchType(l,1)){
			o=new UnityEngine.Behaviour();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enabled(IntPtr l) {
		UnityEngine.Behaviour o = checkSelf<UnityEngine.Behaviour>(l);
		pushValue(l,o.enabled);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enabled(IntPtr l) {
		UnityEngine.Behaviour o = checkSelf<UnityEngine.Behaviour>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.enabled=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Behaviour");
		addMember(l,get_enabled, "get_enabled");
		addMember(l,set_enabled, "set_enabled");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Behaviour),typeof(UnityEngine.Component));
		LuaDLL.lua_pop(l, 1);
	}
}
