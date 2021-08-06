using System;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class TegaTest : MonoBehaviour
{
    [CSharpCallLua]
    public interface IPersons
    {
        event EventHandler<PropertyChangedEventArgs> PropertyChanged;

        int Age { get; set; }
        int Name { get; set; }
        void Eat();
        void Speak();
        void Add(int a, int b);

        object this[int index] { get; set; }
    }

    [CSharpCallLua]
    public delegate IPersons NewPerson(int mult, params string[] args);

    // Start is called before the first frame update
    void Start()
    {
        LuaEnv luaEnv = new LuaEnv();

        //luaEnv.AddLoader(MyLoader);

        luaEnv.DoString("require 'CSharpCallLua'");

        //Debug.Log(luaEnv.Global.Get<int>("a"));
        //Debug.Log(luaEnv.Global.Get<int>("b"));

        //IPerson p = luaEnv.Global.Get<IPerson>("person");

        //print(p.age);
        //print(p.name);

        //NewPerson ps = luaEnv.Global.GetInPath<NewPerson>("Calc.New");

        //print(luaEnv.Global.Get<string>("Name"));
        //_ps.Speak();
        //_ps.Add(2, 3);

        //Dictionary<string, object> dict = luaEnv.Global.Get<Dictionary<string, object>>("GameUser");
        //foreach (string key in dict.Keys)
        //{
        //    print(key + " + " + dict[key]);
        //}
        //luaEnv.Dispose();

        //LuaTable luaTable = luaEnv.Global.Get<LuaTable>("GameUser");
        //print(luaTable.Get<string>("Age"));

        //Add add = luaEnv.Global.Get<Add>("add");
        //int ab = 0;
        //int abs = 0;
        //add(2, 2,ref ab,ref abs);
        //print(ab);
        //print(abs);
        //add = null;

        Load luaFunction = luaEnv.Global.Get<Load>("GetNameByIndex");
        string nameO = "";
        luaFunction(1, ref nameO);
        Debug.Log(nameO);

        TableMaxNo tabNo = luaEnv.Global.Get<TableMaxNo>("GetTableMaxCount");
        Debug.Log(tabNo());

    }
    string[] tableA = new string[3];
    [CSharpCallLua]
    public delegate void Add(int a, int b, ref int ab, ref int abs);

    [CSharpCallLua]
    public delegate void Load(int index, ref string name);

    [CSharpCallLua]
    public delegate int TableMaxNo ();
    private byte[] MyLoader(ref string filePath)
    {
        //print(filePath);
        //print(Application.streamingAssetsPath);
        //string s = "print(123)";
        return null;
    }
}

class Person
{
    public int age;

    public string name;

}

public class PropertyChangedEventArgs : EventArgs
{
    public string name;
    public object value;
}


