using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class fireBaseJson : MonoBehaviour
{

    [DllImport("__Internal")]
    private static extern void getAle(string alennus);

    public void getAlennus(int ale)
    {
        Debug.Log(ale);
        getAle(ale.ToString());
    }

    private void Start()
    {
    }
}