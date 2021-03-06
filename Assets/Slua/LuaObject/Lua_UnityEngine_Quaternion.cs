﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Quaternion : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Quaternion o;
		if(matchType(l,1,typeof(System.Single),typeof(System.Single),typeof(System.Single),typeof(System.Single))){
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			o=new UnityEngine.Quaternion(a1,a2,a3,a4);
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Set(IntPtr l) {
		try{
			UnityEngine.Quaternion self=checkSelf<UnityEngine.Quaternion>(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			System.Single a4;
			checkType(l,5,out a4);
			self.Set(a1,a2,a3,a4);
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Dot(IntPtr l) {
		try{
			UnityEngine.Quaternion a1;
			checkType(l,1,out a1);
			UnityEngine.Quaternion a2;
			checkType(l,2,out a2);
			System.Single ret=UnityEngine.Quaternion.Dot(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AngleAxis(IntPtr l) {
		try{
			System.Single a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Quaternion ret=UnityEngine.Quaternion.AngleAxis(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ToAngleAxis(IntPtr l) {
		try{
			UnityEngine.Quaternion self=checkSelf<UnityEngine.Quaternion>(l);
			System.Single a1;
			UnityEngine.Vector3 a2;
			self.ToAngleAxis(out a1,out a2);
			pushValue(l,a1);
			pushValue(l,a2);
			setBack(l,self);
			return 2;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FromToRotation(IntPtr l) {
		try{
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Quaternion ret=UnityEngine.Quaternion.FromToRotation(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetFromToRotation(IntPtr l) {
		try{
			UnityEngine.Quaternion self=checkSelf<UnityEngine.Quaternion>(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,3,out a2);
			self.SetFromToRotation(a1,a2);
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LookRotation(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Quaternion ret=UnityEngine.Quaternion.LookRotation(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector3))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Quaternion ret=UnityEngine.Quaternion.LookRotation(a1);
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
	static public int SetLookRotation(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.Vector3))){
				UnityEngine.Quaternion self=checkSelf<UnityEngine.Quaternion>(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				self.SetLookRotation(a1);
				setBack(l,self);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3))){
				UnityEngine.Quaternion self=checkSelf<UnityEngine.Quaternion>(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,3,out a2);
				self.SetLookRotation(a1,a2);
				setBack(l,self);
				return 0;
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
	static public int Slerp(IntPtr l) {
		try{
			UnityEngine.Quaternion a1;
			checkType(l,1,out a1);
			UnityEngine.Quaternion a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.Quaternion ret=UnityEngine.Quaternion.Slerp(a1,a2,a3);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Lerp(IntPtr l) {
		try{
			UnityEngine.Quaternion a1;
			checkType(l,1,out a1);
			UnityEngine.Quaternion a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.Quaternion ret=UnityEngine.Quaternion.Lerp(a1,a2,a3);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RotateTowards(IntPtr l) {
		try{
			UnityEngine.Quaternion a1;
			checkType(l,1,out a1);
			UnityEngine.Quaternion a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.Quaternion ret=UnityEngine.Quaternion.RotateTowards(a1,a2,a3);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Inverse(IntPtr l) {
		try{
			UnityEngine.Quaternion a1;
			checkType(l,1,out a1);
			UnityEngine.Quaternion ret=UnityEngine.Quaternion.Inverse(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Angle(IntPtr l) {
		try{
			UnityEngine.Quaternion a1;
			checkType(l,1,out a1);
			UnityEngine.Quaternion a2;
			checkType(l,2,out a2);
			System.Single ret=UnityEngine.Quaternion.Angle(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Euler(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.Single),typeof(System.Single),typeof(System.Single))){
				System.Single a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Quaternion ret=UnityEngine.Quaternion.Euler(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector3))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Quaternion ret=UnityEngine.Quaternion.Euler(a1);
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
	static public int op_Multiply(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Quaternion),typeof(UnityEngine.Quaternion))){
				UnityEngine.Quaternion a1;
				checkType(l,1,out a1);
				UnityEngine.Quaternion a2;
				checkType(l,2,out a2);
				UnityEngine.Quaternion ret=a1*a2;
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Quaternion),typeof(UnityEngine.Vector3))){
				UnityEngine.Quaternion a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 ret=a1*a2;
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
	static public int op_Equality(IntPtr l) {
		try{
			UnityEngine.Quaternion a1;
			checkType(l,1,out a1);
			UnityEngine.Quaternion a2;
			checkType(l,2,out a2);
			System.Boolean ret=(a1==a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Inequality(IntPtr l) {
		try{
			UnityEngine.Quaternion a1;
			checkType(l,1,out a1);
			UnityEngine.Quaternion a2;
			checkType(l,2,out a2);
			System.Boolean ret=(a1!=a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_kEpsilon(IntPtr l) {
		pushValue(l,UnityEngine.Quaternion.kEpsilon);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_x(IntPtr l) {
		UnityEngine.Quaternion o = checkSelf<UnityEngine.Quaternion>(l);
		pushValue(l,o.x);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_x(IntPtr l) {
		UnityEngine.Quaternion o = checkSelf<UnityEngine.Quaternion>(l);
		System.Single v;
		checkType(l,2,out v);
		o.x=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_y(IntPtr l) {
		UnityEngine.Quaternion o = checkSelf<UnityEngine.Quaternion>(l);
		pushValue(l,o.y);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_y(IntPtr l) {
		UnityEngine.Quaternion o = checkSelf<UnityEngine.Quaternion>(l);
		System.Single v;
		checkType(l,2,out v);
		o.y=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_z(IntPtr l) {
		UnityEngine.Quaternion o = checkSelf<UnityEngine.Quaternion>(l);
		pushValue(l,o.z);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_z(IntPtr l) {
		UnityEngine.Quaternion o = checkSelf<UnityEngine.Quaternion>(l);
		System.Single v;
		checkType(l,2,out v);
		o.z=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_w(IntPtr l) {
		UnityEngine.Quaternion o = checkSelf<UnityEngine.Quaternion>(l);
		pushValue(l,o.w);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_w(IntPtr l) {
		UnityEngine.Quaternion o = checkSelf<UnityEngine.Quaternion>(l);
		System.Single v;
		checkType(l,2,out v);
		o.w=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_identity(IntPtr l) {
		pushValue(l,UnityEngine.Quaternion.identity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_eulerAngles(IntPtr l) {
		UnityEngine.Quaternion o = checkSelf<UnityEngine.Quaternion>(l);
		pushValue(l,o.eulerAngles);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_eulerAngles(IntPtr l) {
		UnityEngine.Quaternion o = checkSelf<UnityEngine.Quaternion>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.eulerAngles=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Quaternion");
		addMember(l,Set, "Set");
		addMember(l,Dot, "Dot");
		addMember(l,AngleAxis, "AngleAxis");
		addMember(l,ToAngleAxis, "ToAngleAxis");
		addMember(l,FromToRotation, "FromToRotation");
		addMember(l,SetFromToRotation, "SetFromToRotation");
		addMember(l,LookRotation, "LookRotation");
		addMember(l,SetLookRotation, "SetLookRotation");
		addMember(l,Slerp, "Slerp");
		addMember(l,Lerp, "Lerp");
		addMember(l,RotateTowards, "RotateTowards");
		addMember(l,Inverse, "Inverse");
		addMember(l,Angle, "Angle");
		addMember(l,Euler, "Euler");
		addMember(l,op_Multiply, "op_Multiply");
		addMember(l,op_Equality, "op_Equality");
		addMember(l,op_Inequality, "op_Inequality");
		addMember(l,get_kEpsilon, "get_kEpsilon");
		addMember(l,get_x, "get_x");
		addMember(l,set_x, "set_x");
		addMember(l,get_y, "get_y");
		addMember(l,set_y, "set_y");
		addMember(l,get_z, "get_z");
		addMember(l,set_z, "set_z");
		addMember(l,get_w, "get_w");
		addMember(l,set_w, "set_w");
		addMember(l,get_identity, "get_identity");
		addMember(l,get_eulerAngles, "get_eulerAngles");
		addMember(l,set_eulerAngles, "set_eulerAngles");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Quaternion));
		LuaDLL.lua_pop(l, 1);
	}
}
