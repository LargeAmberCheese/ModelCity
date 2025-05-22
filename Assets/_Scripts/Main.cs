using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using SimpleJSON;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var tables = new cfg.Tables(LoadByteBuf);
        UnityEngine.Debug.Log($"{tables.TbElements.DataMap["chest"].Title}");
        
        UnityEngine.Debug.Log("== load succ==");
    }

    private static JSONNode LoadByteBuf(string file)
    {
        return JSON.Parse(File.ReadAllText(Application.dataPath + "/../GenerateDatas/json/" + file + ".json", System.Text.Encoding.UTF8));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
