﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_NavMeshAgent : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.NavMeshAgent o;
		if(matchType(l,1)){
			o=new UnityEngine.NavMeshAgent();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetDestination(IntPtr l) {
		try{
			UnityEngine.NavMeshAgent self=checkSelf<UnityEngine.NavMeshAgent>(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.SetDestination(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ActivateCurrentOffMeshLink(IntPtr l) {
		try{
			UnityEngine.NavMeshAgent self=checkSelf<UnityEngine.NavMeshAgent>(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.ActivateCurrentOffMeshLink(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CompleteOffMeshLink(IntPtr l) {
		try{
			UnityEngine.NavMeshAgent self=checkSelf<UnityEngine.NavMeshAgent>(l);
			self.CompleteOffMeshLink();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Warp(IntPtr l) {
		try{
			UnityEngine.NavMeshAgent self=checkSelf<UnityEngine.NavMeshAgent>(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.Warp(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Move(IntPtr l) {
		try{
			UnityEngine.NavMeshAgent self=checkSelf<UnityEngine.NavMeshAgent>(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			self.Move(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Stop(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.Boolean))){
				UnityEngine.NavMeshAgent self=checkSelf<UnityEngine.NavMeshAgent>(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				self.Stop(a1);
				return 0;
			}
			else if(matchType(l,2)){
				UnityEngine.NavMeshAgent self=checkSelf<UnityEngine.NavMeshAgent>(l);
				self.Stop();
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
	static public int Resume(IntPtr l) {
		try{
			UnityEngine.NavMeshAgent self=checkSelf<UnityEngine.NavMeshAgent>(l);
			self.Resume();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ResetPath(IntPtr l) {
		try{
			UnityEngine.NavMeshAgent self=checkSelf<UnityEngine.NavMeshAgent>(l);
			self.ResetPath();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetPath(IntPtr l) {
		try{
			UnityEngine.NavMeshAgent self=checkSelf<UnityEngine.NavMeshAgent>(l);
			UnityEngine.NavMeshPath a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.SetPath(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FindClosestEdge(IntPtr l) {
		try{
			UnityEngine.NavMeshAgent self=checkSelf<UnityEngine.NavMeshAgent>(l);
			UnityEngine.NavMeshHit a1;
			System.Boolean ret=self.FindClosestEdge(out a1);
			pushValue(l,ret);
			pushValue(l,a1);
			return 2;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Raycast(IntPtr l) {
		try{
			UnityEngine.NavMeshAgent self=checkSelf<UnityEngine.NavMeshAgent>(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.NavMeshHit a2;
			System.Boolean ret=self.Raycast(a1,out a2);
			pushValue(l,ret);
			pushValue(l,a2);
			return 2;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculatePath(IntPtr l) {
		try{
			UnityEngine.NavMeshAgent self=checkSelf<UnityEngine.NavMeshAgent>(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.NavMeshPath a2;
			checkType(l,3,out a2);
			System.Boolean ret=self.CalculatePath(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SamplePathPosition(IntPtr l) {
		try{
			UnityEngine.NavMeshAgent self=checkSelf<UnityEngine.NavMeshAgent>(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			UnityEngine.NavMeshHit a3;
			System.Boolean ret=self.SamplePathPosition(a1,a2,out a3);
			pushValue(l,ret);
			pushValue(l,a3);
			return 2;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetLayerCost(IntPtr l) {
		try{
			UnityEngine.NavMeshAgent self=checkSelf<UnityEngine.NavMeshAgent>(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetLayerCost(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetLayerCost(IntPtr l) {
		try{
			UnityEngine.NavMeshAgent self=checkSelf<UnityEngine.NavMeshAgent>(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Single ret=self.GetLayerCost(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_destination(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		pushValue(l,o.destination);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_destination(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.destination=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_stoppingDistance(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		pushValue(l,o.stoppingDistance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_stoppingDistance(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		System.Single v;
		checkType(l,2,out v);
		o.stoppingDistance=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_velocity(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		pushValue(l,o.velocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_velocity(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.velocity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_nextPosition(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		pushValue(l,o.nextPosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_nextPosition(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.nextPosition=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_steeringTarget(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		pushValue(l,o.steeringTarget);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_desiredVelocity(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		pushValue(l,o.desiredVelocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_remainingDistance(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		pushValue(l,o.remainingDistance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_baseOffset(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		pushValue(l,o.baseOffset);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_baseOffset(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		System.Single v;
		checkType(l,2,out v);
		o.baseOffset=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isOnOffMeshLink(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		pushValue(l,o.isOnOffMeshLink);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_currentOffMeshLinkData(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		pushValue(l,o.currentOffMeshLinkData);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_nextOffMeshLinkData(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		pushValue(l,o.nextOffMeshLinkData);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_autoTraverseOffMeshLink(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		pushValue(l,o.autoTraverseOffMeshLink);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_autoTraverseOffMeshLink(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.autoTraverseOffMeshLink=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_autoBraking(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		pushValue(l,o.autoBraking);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_autoBraking(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.autoBraking=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_autoRepath(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		pushValue(l,o.autoRepath);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_autoRepath(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.autoRepath=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasPath(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		pushValue(l,o.hasPath);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pathPending(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		pushValue(l,o.pathPending);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isPathStale(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		pushValue(l,o.isPathStale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pathStatus(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		pushValue(l,o.pathStatus);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pathEndPosition(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		pushValue(l,o.pathEndPosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_path(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		pushValue(l,o.path);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_path(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		UnityEngine.NavMeshPath v;
		checkType(l,2,out v);
		o.path=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_walkableMask(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		pushValue(l,o.walkableMask);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_walkableMask(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.walkableMask=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_speed(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		pushValue(l,o.speed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_speed(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		System.Single v;
		checkType(l,2,out v);
		o.speed=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angularSpeed(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		pushValue(l,o.angularSpeed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angularSpeed(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		System.Single v;
		checkType(l,2,out v);
		o.angularSpeed=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_acceleration(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		pushValue(l,o.acceleration);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_acceleration(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		System.Single v;
		checkType(l,2,out v);
		o.acceleration=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_updatePosition(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		pushValue(l,o.updatePosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_updatePosition(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.updatePosition=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_updateRotation(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		pushValue(l,o.updateRotation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_updateRotation(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.updateRotation=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_radius(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		pushValue(l,o.radius);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_radius(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		System.Single v;
		checkType(l,2,out v);
		o.radius=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_height(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		pushValue(l,o.height);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_height(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		System.Single v;
		checkType(l,2,out v);
		o.height=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_obstacleAvoidanceType(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		pushValue(l,o.obstacleAvoidanceType);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_obstacleAvoidanceType(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		UnityEngine.ObstacleAvoidanceType v;
		checkType(l,2,out v);
		o.obstacleAvoidanceType=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_avoidancePriority(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		pushValue(l,o.avoidancePriority);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_avoidancePriority(IntPtr l) {
		UnityEngine.NavMeshAgent o = checkSelf<UnityEngine.NavMeshAgent>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.avoidancePriority=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.NavMeshAgent");
		addMember(l,SetDestination, "SetDestination");
		addMember(l,ActivateCurrentOffMeshLink, "ActivateCurrentOffMeshLink");
		addMember(l,CompleteOffMeshLink, "CompleteOffMeshLink");
		addMember(l,Warp, "Warp");
		addMember(l,Move, "Move");
		addMember(l,Stop, "Stop");
		addMember(l,Resume, "Resume");
		addMember(l,ResetPath, "ResetPath");
		addMember(l,SetPath, "SetPath");
		addMember(l,FindClosestEdge, "FindClosestEdge");
		addMember(l,Raycast, "Raycast");
		addMember(l,CalculatePath, "CalculatePath");
		addMember(l,SamplePathPosition, "SamplePathPosition");
		addMember(l,SetLayerCost, "SetLayerCost");
		addMember(l,GetLayerCost, "GetLayerCost");
		addMember(l,get_destination, "get_destination");
		addMember(l,set_destination, "set_destination");
		addMember(l,get_stoppingDistance, "get_stoppingDistance");
		addMember(l,set_stoppingDistance, "set_stoppingDistance");
		addMember(l,get_velocity, "get_velocity");
		addMember(l,set_velocity, "set_velocity");
		addMember(l,get_nextPosition, "get_nextPosition");
		addMember(l,set_nextPosition, "set_nextPosition");
		addMember(l,get_steeringTarget, "get_steeringTarget");
		addMember(l,get_desiredVelocity, "get_desiredVelocity");
		addMember(l,get_remainingDistance, "get_remainingDistance");
		addMember(l,get_baseOffset, "get_baseOffset");
		addMember(l,set_baseOffset, "set_baseOffset");
		addMember(l,get_isOnOffMeshLink, "get_isOnOffMeshLink");
		addMember(l,get_currentOffMeshLinkData, "get_currentOffMeshLinkData");
		addMember(l,get_nextOffMeshLinkData, "get_nextOffMeshLinkData");
		addMember(l,get_autoTraverseOffMeshLink, "get_autoTraverseOffMeshLink");
		addMember(l,set_autoTraverseOffMeshLink, "set_autoTraverseOffMeshLink");
		addMember(l,get_autoBraking, "get_autoBraking");
		addMember(l,set_autoBraking, "set_autoBraking");
		addMember(l,get_autoRepath, "get_autoRepath");
		addMember(l,set_autoRepath, "set_autoRepath");
		addMember(l,get_hasPath, "get_hasPath");
		addMember(l,get_pathPending, "get_pathPending");
		addMember(l,get_isPathStale, "get_isPathStale");
		addMember(l,get_pathStatus, "get_pathStatus");
		addMember(l,get_pathEndPosition, "get_pathEndPosition");
		addMember(l,get_path, "get_path");
		addMember(l,set_path, "set_path");
		addMember(l,get_walkableMask, "get_walkableMask");
		addMember(l,set_walkableMask, "set_walkableMask");
		addMember(l,get_speed, "get_speed");
		addMember(l,set_speed, "set_speed");
		addMember(l,get_angularSpeed, "get_angularSpeed");
		addMember(l,set_angularSpeed, "set_angularSpeed");
		addMember(l,get_acceleration, "get_acceleration");
		addMember(l,set_acceleration, "set_acceleration");
		addMember(l,get_updatePosition, "get_updatePosition");
		addMember(l,set_updatePosition, "set_updatePosition");
		addMember(l,get_updateRotation, "get_updateRotation");
		addMember(l,set_updateRotation, "set_updateRotation");
		addMember(l,get_radius, "get_radius");
		addMember(l,set_radius, "set_radius");
		addMember(l,get_height, "get_height");
		addMember(l,set_height, "set_height");
		addMember(l,get_obstacleAvoidanceType, "get_obstacleAvoidanceType");
		addMember(l,set_obstacleAvoidanceType, "set_obstacleAvoidanceType");
		addMember(l,get_avoidancePriority, "get_avoidancePriority");
		addMember(l,set_avoidancePriority, "set_avoidancePriority");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.NavMeshAgent),typeof(UnityEngine.Behaviour));
		LuaDLL.lua_pop(l, 1);
	}
}
