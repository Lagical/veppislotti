using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class fireBaseJson : MonoBehaviour
{

    public Text testi;

    [DllImport("__Internal")]
    public static extern void GetJSON(string path, string objectName, string callback, string fallback);

    private void Start()
    {
        GetJSON("example", gameObject.name, "OnRequestSuccess", "OnRequestFailed");
    }

    private void OnRequestSuccess(string data)
    {
        testi.color = Color.green;
        testi.text = data;
    }

    private void OnRequestFailed(string error)
    {
        testi.color = Color.red;
        testi.text = error;
    }
}
