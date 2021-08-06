using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Game/NameStore/" + nameof(NamesStorage))]
public class NamesStorage : ScriptableObject
{
    public List<NameStore> nameStores;
}

[System.Serializable]
public struct NameStore
{
    public List<string> nameValues;
}