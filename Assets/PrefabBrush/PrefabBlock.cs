using UnityEngine;

[System.Serializable]
public class PrefabBlock{
    public string name;
    public GameObject prefab;
    public Texture2D display;

    public static PrefabBlock Empty{
        get{
            return new PrefabBlock("", null, null);
        }
    }

    public PrefabBlock(string name, GameObject prefab, Texture2D display){
        this.prefab = prefab;
        this.name = name;
        this.display = display;
    }
}