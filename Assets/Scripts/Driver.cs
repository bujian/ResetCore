﻿using UnityEngine;
using System.Collections;
using ResetCore.Asset;
using ResetCore.Util;
using System.Collections.Generic;
using System.IO;
using ResetCore.Data.GameDatas.Json;
using ResetCore.Data;
using ResetCore.Json;
using ResetCore.ScriptObj;
using ResetCore.Data.GameDatas.Obj;
using ResetCore.UGUI;
using ResetCore.Data.GameDatas.Xml;
using ResetCore.Event;
using ResetCore.NetPost;
using ResetCore.Protobuf;
using System;
using Vector3D;

//using ResetCore.Data.GameDatas;

public class Driver : MonoSingleton<Driver> {


    public BaseServer server;
    void Awake()
    {
        server = new BaseServer();
        server.Connect(ServerConst.ServerAddress, ServerConst.TcpRemotePort, ServerConst.UdpRemotePort, ServerConst.UdpLocalPort, true);
        server.Regist(new List<int> { 1 }, new List<int>());
        //int i = 0;
        //CoroutineTaskManager.Instance.LoopTodoByTime(() =>
        //{
        //    Vector3DData data = new Vector3DData();
        //    data.X = i;
        //    data.Y = i;
        //    data.Z = i;
        //    Debug.Log("发送");
        //    server.Send<Vector3DData>((int)HandlerConst.HandlerId.TestHandler, 1, data, SendType.TCP);

        //    i++;

        //}, 1, -1);

        //HttpTaskDispatcher.AddNetPostTask(new ExampleNetTask(new Dictionary<string, object>()
        //{
        //    {"test", 1 }
        //}));


        //HttpTaskDispatcher.AddNetPostTask(1, new Dictionary<string, object>()
        //{
        //    {"test", 1 },
        //    {"test2", "asd" },
        //    {"test3", 1.2 }
        //}, (data) =>
        //{
        //    Debug.LogError(data.ToJson());
        //});
    }
    // Use this for initialization
    void Start()
    {
    }

    void OnDestroy()
    {
        //server.Disconnect();
    }

    public void TestReveive(int len, byte[] bytes)
    {
        Debug.LogError("收到" + System.Text.Encoding.UTF8.GetString(bytes));
    }

    public void TestSend(int len)
    {
        Debug.LogError("发送长度为" + len);
    }

    public override void Init()
    {
        base.Init();
    }

    //private List<GameObject> cubes = new List<GameObject>();

    void Update()
    {
        
    }
    
}
