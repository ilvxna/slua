﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Random : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Random o;
		if(matchType(l,1)){
			o=new UnityEngine.Random();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Range(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.Single),typeof(System.Single))){
				System.Single a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Single ret=UnityEngine.Random.Range(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(System.Int32),typeof(System.Int32))){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.Int32 ret=UnityEngine.Random.Range(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_seed(IntPtr l) {
		pushValue(l,UnityEngine.Random.seed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_seed(IntPtr l) {
		System.Int32 v;
		checkType(l,2,out v);
		UnityEngine.Random.seed=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_value(IntPtr l) {
		pushValue(l,UnityEngine.Random.value);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_insideUnitSphere(IntPtr l) {
		pushValue(l,UnityEngine.Random.insideUnitSphere);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_insideUnitCircle(IntPtr l) {
		pushValue(l,UnityEngine.Random.insideUnitCircle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onUnitSphere(IntPtr l) {
		pushValue(l,UnityEngine.Random.onUnitSphere);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rotation(IntPtr l) {
		pushValue(l,UnityEngine.Random.rotation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rotationUniform(IntPtr l) {
		pushValue(l,UnityEngine.Random.rotationUniform);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Random");
		addMember(l,Range, "Range");
		addMember(l,get_seed, "get_seed");
		addMember(l,set_seed, "set_seed");
		addMember(l,get_value, "get_value");
		addMember(l,get_insideUnitSphere, "get_insideUnitSphere");
		addMember(l,get_insideUnitCircle, "get_insideUnitCircle");
		addMember(l,get_onUnitSphere, "get_onUnitSphere");
		addMember(l,get_rotation, "get_rotation");
		addMember(l,get_rotationUniform, "get_rotationUniform");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Random));
		LuaDLL.lua_pop(l, 1);
	}
}
