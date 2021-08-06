using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class LoadUI : MonoBehaviour
{
    public InjectionsScriptables injectionsStorage;
    public XLuaTest.LuaBehaviour luaBehaviour;

    void Awake()
    {
        luaBehaviour.luaScript = injectionsStorage.injectionModels[0].luaAsset;
        luaBehaviour.injections = new XLuaTest.Injection[injectionsStorage.injectionModels[0].injectionPrefabs.Length];

        for (int i = 0; i < injectionsStorage.injectionModels[0].injectionPrefabs.Length; i++)
        {
            luaBehaviour.injections[i] = injectionsStorage.injectionModels[0].injectionPrefabs[i];
        }

        luaBehaviour.Init();
    }

    private void Start()
    {
        luaBehaviour.RunStart();
    }

    private void Update()
    {
        luaBehaviour.RunUpdate();
    }

    private void OnDestroy()
    {
        luaBehaviour.RunOnDestroy();
    }
}