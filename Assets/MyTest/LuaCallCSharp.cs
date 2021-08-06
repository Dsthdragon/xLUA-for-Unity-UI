using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class LuaCallCSharp : MonoBehaviour
{
    private void Start()
    {
        LuaEnv luaEnv = new LuaEnv();

        luaEnv.DoString("require 'LuaCallCSharp'");

        luaEnv.Dispose();
    }
}
