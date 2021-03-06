﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ProceduralMaterial : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.ProceduralMaterial o;
		if(matchType(l,1)){
			o=new UnityEngine.ProceduralMaterial();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetProceduralPropertyDescriptions(IntPtr l) {
		try{
			UnityEngine.ProceduralMaterial self=checkSelf<UnityEngine.ProceduralMaterial>(l);
			UnityEngine.ProceduralPropertyDescription[] ret=self.GetProceduralPropertyDescriptions();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int HasProceduralProperty(IntPtr l) {
		try{
			UnityEngine.ProceduralMaterial self=checkSelf<UnityEngine.ProceduralMaterial>(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.HasProceduralProperty(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetProceduralBoolean(IntPtr l) {
		try{
			UnityEngine.ProceduralMaterial self=checkSelf<UnityEngine.ProceduralMaterial>(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.GetProceduralBoolean(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetProceduralBoolean(IntPtr l) {
		try{
			UnityEngine.ProceduralMaterial self=checkSelf<UnityEngine.ProceduralMaterial>(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.SetProceduralBoolean(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetProceduralFloat(IntPtr l) {
		try{
			UnityEngine.ProceduralMaterial self=checkSelf<UnityEngine.ProceduralMaterial>(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Single ret=self.GetProceduralFloat(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetProceduralFloat(IntPtr l) {
		try{
			UnityEngine.ProceduralMaterial self=checkSelf<UnityEngine.ProceduralMaterial>(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetProceduralFloat(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetProceduralVector(IntPtr l) {
		try{
			UnityEngine.ProceduralMaterial self=checkSelf<UnityEngine.ProceduralMaterial>(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Vector4 ret=self.GetProceduralVector(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetProceduralVector(IntPtr l) {
		try{
			UnityEngine.ProceduralMaterial self=checkSelf<UnityEngine.ProceduralMaterial>(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Vector4 a2;
			checkType(l,3,out a2);
			self.SetProceduralVector(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetProceduralColor(IntPtr l) {
		try{
			UnityEngine.ProceduralMaterial self=checkSelf<UnityEngine.ProceduralMaterial>(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Color ret=self.GetProceduralColor(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetProceduralColor(IntPtr l) {
		try{
			UnityEngine.ProceduralMaterial self=checkSelf<UnityEngine.ProceduralMaterial>(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Color a2;
			checkType(l,3,out a2);
			self.SetProceduralColor(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetProceduralEnum(IntPtr l) {
		try{
			UnityEngine.ProceduralMaterial self=checkSelf<UnityEngine.ProceduralMaterial>(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 ret=self.GetProceduralEnum(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetProceduralEnum(IntPtr l) {
		try{
			UnityEngine.ProceduralMaterial self=checkSelf<UnityEngine.ProceduralMaterial>(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetProceduralEnum(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetProceduralTexture(IntPtr l) {
		try{
			UnityEngine.ProceduralMaterial self=checkSelf<UnityEngine.ProceduralMaterial>(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Texture2D ret=self.GetProceduralTexture(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetProceduralTexture(IntPtr l) {
		try{
			UnityEngine.ProceduralMaterial self=checkSelf<UnityEngine.ProceduralMaterial>(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Texture2D a2;
			checkType(l,3,out a2);
			self.SetProceduralTexture(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsProceduralPropertyCached(IntPtr l) {
		try{
			UnityEngine.ProceduralMaterial self=checkSelf<UnityEngine.ProceduralMaterial>(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.IsProceduralPropertyCached(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CacheProceduralProperty(IntPtr l) {
		try{
			UnityEngine.ProceduralMaterial self=checkSelf<UnityEngine.ProceduralMaterial>(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.CacheProceduralProperty(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ClearCache(IntPtr l) {
		try{
			UnityEngine.ProceduralMaterial self=checkSelf<UnityEngine.ProceduralMaterial>(l);
			self.ClearCache();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RebuildTextures(IntPtr l) {
		try{
			UnityEngine.ProceduralMaterial self=checkSelf<UnityEngine.ProceduralMaterial>(l);
			self.RebuildTextures();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RebuildTexturesImmediately(IntPtr l) {
		try{
			UnityEngine.ProceduralMaterial self=checkSelf<UnityEngine.ProceduralMaterial>(l);
			self.RebuildTexturesImmediately();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int StopRebuilds(IntPtr l) {
		try{
			UnityEngine.ProceduralMaterial.StopRebuilds();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetGeneratedTextures(IntPtr l) {
		try{
			UnityEngine.ProceduralMaterial self=checkSelf<UnityEngine.ProceduralMaterial>(l);
			UnityEngine.Texture[] ret=self.GetGeneratedTextures();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetGeneratedTexture(IntPtr l) {
		try{
			UnityEngine.ProceduralMaterial self=checkSelf<UnityEngine.ProceduralMaterial>(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.ProceduralTexture ret=self.GetGeneratedTexture(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cacheSize(IntPtr l) {
		UnityEngine.ProceduralMaterial o = checkSelf<UnityEngine.ProceduralMaterial>(l);
		pushValue(l,o.cacheSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cacheSize(IntPtr l) {
		UnityEngine.ProceduralMaterial o = checkSelf<UnityEngine.ProceduralMaterial>(l);
		UnityEngine.ProceduralCacheSize v;
		checkType(l,2,out v);
		o.cacheSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_animationUpdateRate(IntPtr l) {
		UnityEngine.ProceduralMaterial o = checkSelf<UnityEngine.ProceduralMaterial>(l);
		pushValue(l,o.animationUpdateRate);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_animationUpdateRate(IntPtr l) {
		UnityEngine.ProceduralMaterial o = checkSelf<UnityEngine.ProceduralMaterial>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.animationUpdateRate=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isProcessing(IntPtr l) {
		UnityEngine.ProceduralMaterial o = checkSelf<UnityEngine.ProceduralMaterial>(l);
		pushValue(l,o.isProcessing);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isCachedDataAvailable(IntPtr l) {
		UnityEngine.ProceduralMaterial o = checkSelf<UnityEngine.ProceduralMaterial>(l);
		pushValue(l,o.isCachedDataAvailable);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isLoadTimeGenerated(IntPtr l) {
		UnityEngine.ProceduralMaterial o = checkSelf<UnityEngine.ProceduralMaterial>(l);
		pushValue(l,o.isLoadTimeGenerated);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isLoadTimeGenerated(IntPtr l) {
		UnityEngine.ProceduralMaterial o = checkSelf<UnityEngine.ProceduralMaterial>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.isLoadTimeGenerated=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_loadingBehavior(IntPtr l) {
		UnityEngine.ProceduralMaterial o = checkSelf<UnityEngine.ProceduralMaterial>(l);
		pushValue(l,o.loadingBehavior);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isSupported(IntPtr l) {
		pushValue(l,UnityEngine.ProceduralMaterial.isSupported);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_substanceProcessorUsage(IntPtr l) {
		pushValue(l,UnityEngine.ProceduralMaterial.substanceProcessorUsage);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_substanceProcessorUsage(IntPtr l) {
		UnityEngine.ProceduralProcessorUsage v;
		checkType(l,2,out v);
		UnityEngine.ProceduralMaterial.substanceProcessorUsage=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_preset(IntPtr l) {
		UnityEngine.ProceduralMaterial o = checkSelf<UnityEngine.ProceduralMaterial>(l);
		pushValue(l,o.preset);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_preset(IntPtr l) {
		UnityEngine.ProceduralMaterial o = checkSelf<UnityEngine.ProceduralMaterial>(l);
		System.String v;
		checkType(l,2,out v);
		o.preset=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isReadable(IntPtr l) {
		UnityEngine.ProceduralMaterial o = checkSelf<UnityEngine.ProceduralMaterial>(l);
		pushValue(l,o.isReadable);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isReadable(IntPtr l) {
		UnityEngine.ProceduralMaterial o = checkSelf<UnityEngine.ProceduralMaterial>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.isReadable=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ProceduralMaterial");
		addMember(l,GetProceduralPropertyDescriptions, "GetProceduralPropertyDescriptions");
		addMember(l,HasProceduralProperty, "HasProceduralProperty");
		addMember(l,GetProceduralBoolean, "GetProceduralBoolean");
		addMember(l,SetProceduralBoolean, "SetProceduralBoolean");
		addMember(l,GetProceduralFloat, "GetProceduralFloat");
		addMember(l,SetProceduralFloat, "SetProceduralFloat");
		addMember(l,GetProceduralVector, "GetProceduralVector");
		addMember(l,SetProceduralVector, "SetProceduralVector");
		addMember(l,GetProceduralColor, "GetProceduralColor");
		addMember(l,SetProceduralColor, "SetProceduralColor");
		addMember(l,GetProceduralEnum, "GetProceduralEnum");
		addMember(l,SetProceduralEnum, "SetProceduralEnum");
		addMember(l,GetProceduralTexture, "GetProceduralTexture");
		addMember(l,SetProceduralTexture, "SetProceduralTexture");
		addMember(l,IsProceduralPropertyCached, "IsProceduralPropertyCached");
		addMember(l,CacheProceduralProperty, "CacheProceduralProperty");
		addMember(l,ClearCache, "ClearCache");
		addMember(l,RebuildTextures, "RebuildTextures");
		addMember(l,RebuildTexturesImmediately, "RebuildTexturesImmediately");
		addMember(l,StopRebuilds, "StopRebuilds");
		addMember(l,GetGeneratedTextures, "GetGeneratedTextures");
		addMember(l,GetGeneratedTexture, "GetGeneratedTexture");
		addMember(l,get_cacheSize, "get_cacheSize");
		addMember(l,set_cacheSize, "set_cacheSize");
		addMember(l,get_animationUpdateRate, "get_animationUpdateRate");
		addMember(l,set_animationUpdateRate, "set_animationUpdateRate");
		addMember(l,get_isProcessing, "get_isProcessing");
		addMember(l,get_isCachedDataAvailable, "get_isCachedDataAvailable");
		addMember(l,get_isLoadTimeGenerated, "get_isLoadTimeGenerated");
		addMember(l,set_isLoadTimeGenerated, "set_isLoadTimeGenerated");
		addMember(l,get_loadingBehavior, "get_loadingBehavior");
		addMember(l,get_isSupported, "get_isSupported");
		addMember(l,get_substanceProcessorUsage, "get_substanceProcessorUsage");
		addMember(l,set_substanceProcessorUsage, "set_substanceProcessorUsage");
		addMember(l,get_preset, "get_preset");
		addMember(l,set_preset, "set_preset");
		addMember(l,get_isReadable, "get_isReadable");
		addMember(l,set_isReadable, "set_isReadable");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.ProceduralMaterial),typeof(UnityEngine.Material));
		LuaDLL.lua_pop(l, 1);
	}
}
