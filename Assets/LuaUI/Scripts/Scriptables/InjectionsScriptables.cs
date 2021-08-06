using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Game/Injections/" + nameof(InjectionsScriptables))]
public class InjectionsScriptables : ScriptableObject
{
    public List<InjectionModel> injectionModels;
}

[System.Serializable]
public struct InjectionModel
{
    public TextAsset luaAsset;
    public XLuaTest.Injection[] injectionPrefabs;
}

