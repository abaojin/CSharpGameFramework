﻿using System;

using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Physics : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Physics o;
			o=new UnityEngine.Physics();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Raycast_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				var ret=UnityEngine.Physics.Raycast(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(LuaOut))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				UnityEngine.RaycastHit a2;
				var ret=UnityEngine.Physics.Raycast(a1,out a2);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a2);
				return 3;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.Physics.Raycast(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(float))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.Physics.Raycast(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(float),typeof(int))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Physics.Raycast(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(LuaOut))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit a3;
				var ret=UnityEngine.Physics.Raycast(a1,a2,out a3);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a3);
				return 3;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(float))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Physics.Raycast(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(LuaOut),typeof(float))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				UnityEngine.RaycastHit a2;
				System.Single a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Physics.Raycast(a1,out a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a2);
				return 3;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(float),typeof(int),typeof(UnityEngine.QueryTriggerInteraction))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.QueryTriggerInteraction a4;
				checkEnum(l,4,out a4);
				var ret=UnityEngine.Physics.Raycast(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(float),typeof(int))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Physics.Raycast(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(LuaOut),typeof(float))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit a3;
				System.Single a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Physics.Raycast(a1,a2,out a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a3);
				return 3;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(LuaOut),typeof(float),typeof(int))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				UnityEngine.RaycastHit a2;
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Physics.Raycast(a1,out a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a2);
				return 3;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(float),typeof(int),typeof(UnityEngine.QueryTriggerInteraction))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				UnityEngine.QueryTriggerInteraction a5;
				checkEnum(l,5,out a5);
				var ret=UnityEngine.Physics.Raycast(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(LuaOut),typeof(float),typeof(int))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit a3;
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				var ret=UnityEngine.Physics.Raycast(a1,a2,out a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a3);
				return 3;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(LuaOut),typeof(float),typeof(int),typeof(UnityEngine.QueryTriggerInteraction))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				UnityEngine.RaycastHit a2;
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				UnityEngine.QueryTriggerInteraction a5;
				checkEnum(l,5,out a5);
				var ret=UnityEngine.Physics.Raycast(a1,out a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a2);
				return 3;
			}
			else if(argc==6){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit a3;
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				UnityEngine.QueryTriggerInteraction a6;
				checkEnum(l,6,out a6);
				var ret=UnityEngine.Physics.Raycast(a1,a2,out a3,a4,a5,a6);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a3);
				return 3;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RaycastAll_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				var ret=UnityEngine.Physics.RaycastAll(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.Physics.RaycastAll(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(float))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.Physics.RaycastAll(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(float))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Physics.RaycastAll(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(float),typeof(int))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Physics.RaycastAll(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(float),typeof(int))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Physics.RaycastAll(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(float),typeof(int),typeof(UnityEngine.QueryTriggerInteraction))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.QueryTriggerInteraction a4;
				checkEnum(l,4,out a4);
				var ret=UnityEngine.Physics.RaycastAll(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==5){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				UnityEngine.QueryTriggerInteraction a5;
				checkEnum(l,5,out a5);
				var ret=UnityEngine.Physics.RaycastAll(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RaycastNonAlloc_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				UnityEngine.RaycastHit[] a2;
				checkArray(l,2,out a2);
				var ret=UnityEngine.Physics.RaycastNonAlloc(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(UnityEngine.RaycastHit[]))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit[] a3;
				checkArray(l,3,out a3);
				var ret=UnityEngine.Physics.RaycastNonAlloc(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(UnityEngine.RaycastHit[]),typeof(float))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				UnityEngine.RaycastHit[] a2;
				checkArray(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Physics.RaycastNonAlloc(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(UnityEngine.RaycastHit[]),typeof(float))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit[] a3;
				checkArray(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Physics.RaycastNonAlloc(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(UnityEngine.RaycastHit[]),typeof(float),typeof(int))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				UnityEngine.RaycastHit[] a2;
				checkArray(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Physics.RaycastNonAlloc(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(UnityEngine.RaycastHit[]),typeof(float),typeof(int))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit[] a3;
				checkArray(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				var ret=UnityEngine.Physics.RaycastNonAlloc(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(UnityEngine.RaycastHit[]),typeof(float),typeof(int),typeof(UnityEngine.QueryTriggerInteraction))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				UnityEngine.RaycastHit[] a2;
				checkArray(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				UnityEngine.QueryTriggerInteraction a5;
				checkEnum(l,5,out a5);
				var ret=UnityEngine.Physics.RaycastNonAlloc(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==6){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit[] a3;
				checkArray(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				UnityEngine.QueryTriggerInteraction a6;
				checkEnum(l,6,out a6);
				var ret=UnityEngine.Physics.RaycastNonAlloc(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Linecast_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.Physics.Linecast(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(LuaOut))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit a3;
				var ret=UnityEngine.Physics.Linecast(a1,a2,out a3);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a3);
				return 3;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(int))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Physics.Linecast(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(LuaOut),typeof(int))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit a3;
				System.Int32 a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Physics.Linecast(a1,a2,out a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a3);
				return 3;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(int),typeof(UnityEngine.QueryTriggerInteraction))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.QueryTriggerInteraction a4;
				checkEnum(l,4,out a4);
				var ret=UnityEngine.Physics.Linecast(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==5){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit a3;
				System.Int32 a4;
				checkType(l,4,out a4);
				UnityEngine.QueryTriggerInteraction a5;
				checkEnum(l,5,out a5);
				var ret=UnityEngine.Physics.Linecast(a1,a2,out a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a3);
				return 3;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OverlapSphere_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.Physics.OverlapSphere(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Physics.OverlapSphere(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==4){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.QueryTriggerInteraction a4;
				checkEnum(l,4,out a4);
				var ret=UnityEngine.Physics.OverlapSphere(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OverlapSphereNonAlloc_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Collider[] a3;
				checkArray(l,3,out a3);
				var ret=UnityEngine.Physics.OverlapSphereNonAlloc(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==4){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Collider[] a3;
				checkArray(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Physics.OverlapSphereNonAlloc(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==5){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Collider[] a3;
				checkArray(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				UnityEngine.QueryTriggerInteraction a5;
				checkEnum(l,5,out a5);
				var ret=UnityEngine.Physics.OverlapSphereNonAlloc(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OverlapCapsule_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Physics.OverlapCapsule(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==4){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Physics.OverlapCapsule(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==5){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				UnityEngine.QueryTriggerInteraction a5;
				checkEnum(l,5,out a5);
				var ret=UnityEngine.Physics.OverlapCapsule(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OverlapCapsuleNonAlloc_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Collider[] a4;
				checkArray(l,4,out a4);
				var ret=UnityEngine.Physics.OverlapCapsuleNonAlloc(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==5){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Collider[] a4;
				checkArray(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				var ret=UnityEngine.Physics.OverlapCapsuleNonAlloc(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==6){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Collider[] a4;
				checkArray(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				UnityEngine.QueryTriggerInteraction a6;
				checkEnum(l,6,out a6);
				var ret=UnityEngine.Physics.OverlapCapsuleNonAlloc(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CapsuleCast_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3 a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Physics.CapsuleCast(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(float),typeof(UnityEngine.Vector3),typeof(LuaOut))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3 a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit a5;
				var ret=UnityEngine.Physics.CapsuleCast(a1,a2,a3,a4,out a5);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a5);
				return 3;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(float),typeof(UnityEngine.Vector3),typeof(float))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				var ret=UnityEngine.Physics.CapsuleCast(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(float),typeof(UnityEngine.Vector3),typeof(LuaOut),typeof(float))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3 a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit a5;
				System.Single a6;
				checkType(l,6,out a6);
				var ret=UnityEngine.Physics.CapsuleCast(a1,a2,a3,a4,out a5,a6);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a5);
				return 3;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(float),typeof(UnityEngine.Vector3),typeof(float),typeof(int))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				var ret=UnityEngine.Physics.CapsuleCast(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(float),typeof(UnityEngine.Vector3),typeof(float),typeof(int),typeof(UnityEngine.QueryTriggerInteraction))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				UnityEngine.QueryTriggerInteraction a7;
				checkEnum(l,7,out a7);
				var ret=UnityEngine.Physics.CapsuleCast(a1,a2,a3,a4,a5,a6,a7);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(float),typeof(UnityEngine.Vector3),typeof(LuaOut),typeof(float),typeof(int))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3 a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit a5;
				System.Single a6;
				checkType(l,6,out a6);
				System.Int32 a7;
				checkType(l,7,out a7);
				var ret=UnityEngine.Physics.CapsuleCast(a1,a2,a3,a4,out a5,a6,a7);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a5);
				return 3;
			}
			else if(argc==8){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3 a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit a5;
				System.Single a6;
				checkType(l,6,out a6);
				System.Int32 a7;
				checkType(l,7,out a7);
				UnityEngine.QueryTriggerInteraction a8;
				checkEnum(l,8,out a8);
				var ret=UnityEngine.Physics.CapsuleCast(a1,a2,a3,a4,out a5,a6,a7,a8);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a5);
				return 3;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SphereCast_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.Physics.SphereCast(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(float),typeof(float))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Physics.SphereCast(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(float),typeof(LuaOut))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit a3;
				var ret=UnityEngine.Physics.SphereCast(a1,a2,out a3);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a3);
				return 3;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(float),typeof(UnityEngine.Vector3),typeof(LuaOut))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit a4;
				var ret=UnityEngine.Physics.SphereCast(a1,a2,a3,out a4);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a4);
				return 3;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(float),typeof(float),typeof(int))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Physics.SphereCast(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(float),typeof(LuaOut),typeof(float))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit a3;
				System.Single a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Physics.SphereCast(a1,a2,out a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a3);
				return 3;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(float),typeof(LuaOut),typeof(float),typeof(int))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit a3;
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				var ret=UnityEngine.Physics.SphereCast(a1,a2,out a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a3);
				return 3;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(float),typeof(float),typeof(int),typeof(UnityEngine.QueryTriggerInteraction))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				UnityEngine.QueryTriggerInteraction a5;
				checkEnum(l,5,out a5);
				var ret=UnityEngine.Physics.SphereCast(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(float),typeof(UnityEngine.Vector3),typeof(LuaOut),typeof(float))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit a4;
				System.Single a5;
				checkType(l,5,out a5);
				var ret=UnityEngine.Physics.SphereCast(a1,a2,a3,out a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a4);
				return 3;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(float),typeof(UnityEngine.Vector3),typeof(LuaOut),typeof(float),typeof(int))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit a4;
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				var ret=UnityEngine.Physics.SphereCast(a1,a2,a3,out a4,a5,a6);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a4);
				return 3;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(float),typeof(LuaOut),typeof(float),typeof(int),typeof(UnityEngine.QueryTriggerInteraction))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit a3;
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				UnityEngine.QueryTriggerInteraction a6;
				checkEnum(l,6,out a6);
				var ret=UnityEngine.Physics.SphereCast(a1,a2,out a3,a4,a5,a6);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a3);
				return 3;
			}
			else if(argc==7){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit a4;
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				UnityEngine.QueryTriggerInteraction a7;
				checkEnum(l,7,out a7);
				var ret=UnityEngine.Physics.SphereCast(a1,a2,a3,out a4,a5,a6,a7);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a4);
				return 3;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CapsuleCastAll_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3 a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Physics.CapsuleCastAll(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==5){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				var ret=UnityEngine.Physics.CapsuleCastAll(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==6){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				var ret=UnityEngine.Physics.CapsuleCastAll(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==7){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				UnityEngine.QueryTriggerInteraction a7;
				checkEnum(l,7,out a7);
				var ret=UnityEngine.Physics.CapsuleCastAll(a1,a2,a3,a4,a5,a6,a7);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CapsuleCastNonAlloc_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==5){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3 a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit[] a5;
				checkArray(l,5,out a5);
				var ret=UnityEngine.Physics.CapsuleCastNonAlloc(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==6){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3 a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit[] a5;
				checkArray(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				var ret=UnityEngine.Physics.CapsuleCastNonAlloc(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==7){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3 a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit[] a5;
				checkArray(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				System.Int32 a7;
				checkType(l,7,out a7);
				var ret=UnityEngine.Physics.CapsuleCastNonAlloc(a1,a2,a3,a4,a5,a6,a7);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==8){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3 a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit[] a5;
				checkArray(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				System.Int32 a7;
				checkType(l,7,out a7);
				UnityEngine.QueryTriggerInteraction a8;
				checkEnum(l,8,out a8);
				var ret=UnityEngine.Physics.CapsuleCastNonAlloc(a1,a2,a3,a4,a5,a6,a7,a8);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SphereCastAll_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.Physics.SphereCastAll(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(float),typeof(float))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Physics.SphereCastAll(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(float),typeof(UnityEngine.Vector3))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Physics.SphereCastAll(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(float),typeof(float),typeof(int))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Physics.SphereCastAll(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(float),typeof(UnityEngine.Vector3),typeof(float))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Physics.SphereCastAll(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(float),typeof(UnityEngine.Vector3),typeof(float),typeof(int))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				var ret=UnityEngine.Physics.SphereCastAll(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(float),typeof(float),typeof(int),typeof(UnityEngine.QueryTriggerInteraction))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				UnityEngine.QueryTriggerInteraction a5;
				checkEnum(l,5,out a5);
				var ret=UnityEngine.Physics.SphereCastAll(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==6){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				UnityEngine.QueryTriggerInteraction a6;
				checkEnum(l,6,out a6);
				var ret=UnityEngine.Physics.SphereCastAll(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SphereCastNonAlloc_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit[] a3;
				checkArray(l,3,out a3);
				var ret=UnityEngine.Physics.SphereCastNonAlloc(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(float),typeof(UnityEngine.RaycastHit[]),typeof(float))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit[] a3;
				checkArray(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Physics.SphereCastNonAlloc(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(float),typeof(UnityEngine.Vector3),typeof(UnityEngine.RaycastHit[]))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit[] a4;
				checkArray(l,4,out a4);
				var ret=UnityEngine.Physics.SphereCastNonAlloc(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(float),typeof(UnityEngine.RaycastHit[]),typeof(float),typeof(int))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit[] a3;
				checkArray(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				var ret=UnityEngine.Physics.SphereCastNonAlloc(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(float),typeof(UnityEngine.Vector3),typeof(UnityEngine.RaycastHit[]),typeof(float))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit[] a4;
				checkArray(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				var ret=UnityEngine.Physics.SphereCastNonAlloc(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(float),typeof(UnityEngine.Vector3),typeof(UnityEngine.RaycastHit[]),typeof(float),typeof(int))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit[] a4;
				checkArray(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				var ret=UnityEngine.Physics.SphereCastNonAlloc(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(float),typeof(UnityEngine.RaycastHit[]),typeof(float),typeof(int),typeof(UnityEngine.QueryTriggerInteraction))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit[] a3;
				checkArray(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				UnityEngine.QueryTriggerInteraction a6;
				checkEnum(l,6,out a6);
				var ret=UnityEngine.Physics.SphereCastNonAlloc(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==7){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit[] a4;
				checkArray(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				UnityEngine.QueryTriggerInteraction a7;
				checkEnum(l,7,out a7);
				var ret=UnityEngine.Physics.SphereCastNonAlloc(a1,a2,a3,a4,a5,a6,a7);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CheckSphere_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.Physics.CheckSphere(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Physics.CheckSphere(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==4){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.QueryTriggerInteraction a4;
				checkEnum(l,4,out a4);
				var ret=UnityEngine.Physics.CheckSphere(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CheckCapsule_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Physics.CheckCapsule(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==4){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Physics.CheckCapsule(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==5){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				UnityEngine.QueryTriggerInteraction a5;
				checkEnum(l,5,out a5);
				var ret=UnityEngine.Physics.CheckCapsule(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CheckBox_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.Physics.CheckBox(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Quaternion a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Physics.CheckBox(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==4){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Quaternion a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Physics.CheckBox(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==5){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Quaternion a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				UnityEngine.QueryTriggerInteraction a5;
				checkEnum(l,5,out a5);
				var ret=UnityEngine.Physics.CheckBox(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OverlapBox_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.Physics.OverlapBox(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Quaternion a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Physics.OverlapBox(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==4){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Quaternion a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Physics.OverlapBox(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==5){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Quaternion a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				UnityEngine.QueryTriggerInteraction a5;
				checkEnum(l,5,out a5);
				var ret=UnityEngine.Physics.OverlapBox(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OverlapBoxNonAlloc_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Collider[] a3;
				checkArray(l,3,out a3);
				var ret=UnityEngine.Physics.OverlapBoxNonAlloc(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==4){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Collider[] a3;
				checkArray(l,3,out a3);
				UnityEngine.Quaternion a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Physics.OverlapBoxNonAlloc(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==5){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Collider[] a3;
				checkArray(l,3,out a3);
				UnityEngine.Quaternion a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				var ret=UnityEngine.Physics.OverlapBoxNonAlloc(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==6){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Collider[] a3;
				checkArray(l,3,out a3);
				UnityEngine.Quaternion a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				UnityEngine.QueryTriggerInteraction a6;
				checkEnum(l,6,out a6);
				var ret=UnityEngine.Physics.OverlapBoxNonAlloc(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int BoxCastAll_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Physics.BoxCastAll(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==4){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				UnityEngine.Quaternion a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Physics.BoxCastAll(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==5){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				UnityEngine.Quaternion a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				var ret=UnityEngine.Physics.BoxCastAll(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==6){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				UnityEngine.Quaternion a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				var ret=UnityEngine.Physics.BoxCastAll(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==7){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				UnityEngine.Quaternion a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				UnityEngine.QueryTriggerInteraction a7;
				checkEnum(l,7,out a7);
				var ret=UnityEngine.Physics.BoxCastAll(a1,a2,a3,a4,a5,a6,a7);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int BoxCastNonAlloc_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit[] a4;
				checkArray(l,4,out a4);
				var ret=UnityEngine.Physics.BoxCastNonAlloc(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==5){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit[] a4;
				checkArray(l,4,out a4);
				UnityEngine.Quaternion a5;
				checkType(l,5,out a5);
				var ret=UnityEngine.Physics.BoxCastNonAlloc(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==6){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit[] a4;
				checkArray(l,4,out a4);
				UnityEngine.Quaternion a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				var ret=UnityEngine.Physics.BoxCastNonAlloc(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==7){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit[] a4;
				checkArray(l,4,out a4);
				UnityEngine.Quaternion a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				System.Int32 a7;
				checkType(l,7,out a7);
				var ret=UnityEngine.Physics.BoxCastNonAlloc(a1,a2,a3,a4,a5,a6,a7);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==8){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit[] a4;
				checkArray(l,4,out a4);
				UnityEngine.Quaternion a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				System.Int32 a7;
				checkType(l,7,out a7);
				UnityEngine.QueryTriggerInteraction a8;
				checkEnum(l,8,out a8);
				var ret=UnityEngine.Physics.BoxCastNonAlloc(a1,a2,a3,a4,a5,a6,a7,a8);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int BoxCast_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Physics.BoxCast(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(LuaOut))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit a4;
				var ret=UnityEngine.Physics.BoxCast(a1,a2,a3,out a4);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a4);
				return 3;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				UnityEngine.Quaternion a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Physics.BoxCast(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion),typeof(float))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				UnityEngine.Quaternion a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				var ret=UnityEngine.Physics.BoxCast(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(LuaOut),typeof(UnityEngine.Quaternion))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit a4;
				UnityEngine.Quaternion a5;
				checkType(l,5,out a5);
				var ret=UnityEngine.Physics.BoxCast(a1,a2,a3,out a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a4);
				return 3;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(LuaOut),typeof(UnityEngine.Quaternion),typeof(float))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit a4;
				UnityEngine.Quaternion a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				var ret=UnityEngine.Physics.BoxCast(a1,a2,a3,out a4,a5,a6);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a4);
				return 3;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion),typeof(float),typeof(int))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				UnityEngine.Quaternion a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				var ret=UnityEngine.Physics.BoxCast(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion),typeof(float),typeof(int),typeof(UnityEngine.QueryTriggerInteraction))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				UnityEngine.Quaternion a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				UnityEngine.QueryTriggerInteraction a7;
				checkEnum(l,7,out a7);
				var ret=UnityEngine.Physics.BoxCast(a1,a2,a3,a4,a5,a6,a7);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(LuaOut),typeof(UnityEngine.Quaternion),typeof(float),typeof(int))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit a4;
				UnityEngine.Quaternion a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				System.Int32 a7;
				checkType(l,7,out a7);
				var ret=UnityEngine.Physics.BoxCast(a1,a2,a3,out a4,a5,a6,a7);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a4);
				return 3;
			}
			else if(argc==8){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit a4;
				UnityEngine.Quaternion a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				System.Int32 a7;
				checkType(l,7,out a7);
				UnityEngine.QueryTriggerInteraction a8;
				checkEnum(l,8,out a8);
				var ret=UnityEngine.Physics.BoxCast(a1,a2,a3,out a4,a5,a6,a7,a8);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a4);
				return 3;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IgnoreCollision_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Collider a1;
				checkType(l,1,out a1);
				UnityEngine.Collider a2;
				checkType(l,2,out a2);
				UnityEngine.Physics.IgnoreCollision(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Collider a1;
				checkType(l,1,out a1);
				UnityEngine.Collider a2;
				checkType(l,2,out a2);
				System.Boolean a3;
				checkType(l,3,out a3);
				UnityEngine.Physics.IgnoreCollision(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IgnoreLayerCollision_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				UnityEngine.Physics.IgnoreLayerCollision(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.Boolean a3;
				checkType(l,3,out a3);
				UnityEngine.Physics.IgnoreLayerCollision(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetIgnoreLayerCollision_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.Physics.GetIgnoreLayerCollision(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ComputePenetration_s(IntPtr l) {
		try {
			UnityEngine.Collider a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Quaternion a3;
			checkType(l,3,out a3);
			UnityEngine.Collider a4;
			checkType(l,4,out a4);
			UnityEngine.Vector3 a5;
			checkType(l,5,out a5);
			UnityEngine.Quaternion a6;
			checkType(l,6,out a6);
			UnityEngine.Vector3 a7;
			System.Single a8;
			var ret=UnityEngine.Physics.ComputePenetration(a1,a2,a3,a4,a5,a6,out a7,out a8);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a7);
			pushValue(l,a8);
			return 4;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ClosestPoint_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Collider a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,3,out a3);
			UnityEngine.Quaternion a4;
			checkType(l,4,out a4);
			var ret=UnityEngine.Physics.ClosestPoint(a1,a2,a3,a4);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_IgnoreRaycastLayer(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Physics.IgnoreRaycastLayer);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_DefaultRaycastLayers(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Physics.DefaultRaycastLayers);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_AllLayers(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Physics.AllLayers);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gravity(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Physics.gravity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_gravity(IntPtr l) {
		try {
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			UnityEngine.Physics.gravity=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_defaultContactOffset(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Physics.defaultContactOffset);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_defaultContactOffset(IntPtr l) {
		try {
			float v;
			checkType(l,2,out v);
			UnityEngine.Physics.defaultContactOffset=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bounceThreshold(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Physics.bounceThreshold);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bounceThreshold(IntPtr l) {
		try {
			float v;
			checkType(l,2,out v);
			UnityEngine.Physics.bounceThreshold=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_defaultSolverIterations(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Physics.defaultSolverIterations);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_defaultSolverIterations(IntPtr l) {
		try {
			int v;
			checkType(l,2,out v);
			UnityEngine.Physics.defaultSolverIterations=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_defaultSolverVelocityIterations(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Physics.defaultSolverVelocityIterations);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_defaultSolverVelocityIterations(IntPtr l) {
		try {
			int v;
			checkType(l,2,out v);
			UnityEngine.Physics.defaultSolverVelocityIterations=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sleepThreshold(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Physics.sleepThreshold);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sleepThreshold(IntPtr l) {
		try {
			float v;
			checkType(l,2,out v);
			UnityEngine.Physics.sleepThreshold=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_queriesHitTriggers(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Physics.queriesHitTriggers);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_queriesHitTriggers(IntPtr l) {
		try {
			bool v;
			checkType(l,2,out v);
			UnityEngine.Physics.queriesHitTriggers=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_queriesHitBackfaces(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Physics.queriesHitBackfaces);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_queriesHitBackfaces(IntPtr l) {
		try {
			bool v;
			checkType(l,2,out v);
			UnityEngine.Physics.queriesHitBackfaces=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Physics");
		addMember(l,Raycast_s);
		addMember(l,RaycastAll_s);
		addMember(l,RaycastNonAlloc_s);
		addMember(l,Linecast_s);
		addMember(l,OverlapSphere_s);
		addMember(l,OverlapSphereNonAlloc_s);
		addMember(l,OverlapCapsule_s);
		addMember(l,OverlapCapsuleNonAlloc_s);
		addMember(l,CapsuleCast_s);
		addMember(l,SphereCast_s);
		addMember(l,CapsuleCastAll_s);
		addMember(l,CapsuleCastNonAlloc_s);
		addMember(l,SphereCastAll_s);
		addMember(l,SphereCastNonAlloc_s);
		addMember(l,CheckSphere_s);
		addMember(l,CheckCapsule_s);
		addMember(l,CheckBox_s);
		addMember(l,OverlapBox_s);
		addMember(l,OverlapBoxNonAlloc_s);
		addMember(l,BoxCastAll_s);
		addMember(l,BoxCastNonAlloc_s);
		addMember(l,BoxCast_s);
		addMember(l,IgnoreCollision_s);
		addMember(l,IgnoreLayerCollision_s);
		addMember(l,GetIgnoreLayerCollision_s);
		addMember(l,ComputePenetration_s);
		addMember(l,ClosestPoint_s);
		addMember(l,"IgnoreRaycastLayer",get_IgnoreRaycastLayer,null,false);
		addMember(l,"DefaultRaycastLayers",get_DefaultRaycastLayers,null,false);
		addMember(l,"AllLayers",get_AllLayers,null,false);
		addMember(l,"gravity",get_gravity,set_gravity,false);
		addMember(l,"defaultContactOffset",get_defaultContactOffset,set_defaultContactOffset,false);
		addMember(l,"bounceThreshold",get_bounceThreshold,set_bounceThreshold,false);
		addMember(l,"defaultSolverIterations",get_defaultSolverIterations,set_defaultSolverIterations,false);
		addMember(l,"defaultSolverVelocityIterations",get_defaultSolverVelocityIterations,set_defaultSolverVelocityIterations,false);
		addMember(l,"sleepThreshold",get_sleepThreshold,set_sleepThreshold,false);
		addMember(l,"queriesHitTriggers",get_queriesHitTriggers,set_queriesHitTriggers,false);
		addMember(l,"queriesHitBackfaces",get_queriesHitBackfaces,set_queriesHitBackfaces,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Physics));
	}
}
