using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jsonController : MonoBehaviour
{
    /*
    public string jsonURL;
    private string[] koodit;

    void Start()
    {
        StartCoroutine(getData());

    }


    IEnumerator getData()
    {
        WWW _www = new WWW(jsonURL);
        yield return _www;
        if(_www.error == null)
        {
            processJsonData(_www.text);
        }
        else
        {
            Debug.Log("Error");
        }
    }

    private void processJsonData(string _url)
    {
        jsonDataClass jsonData = JsonUtility.FromJson<jsonDataClass>(_url);
        List<string> testiLista = new List<string>();
        foreach (allCodes x in jsonData.koodi2)
        {
            testiLista.Add(x.koodi); 
        }
        koodit = testiLista.ToArray();
        Debug.Log(koodit[2]);
    }*/
}
