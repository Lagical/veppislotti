using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSONReader : MonoBehaviour
{
    public TextAsset textJSON;

    [System.Serializable]
    public class Codes
    {
        public string koodi;
    }
    public class Codes1
    {
        public string koodi;
    }
    public class Codes2
    {
        public string koodi;
    }
    public class Codes3
    {
        public string koodi;
    }
    public class Codes4
    {
        public string koodi;
    }

    [System.Serializable]
    public class allCodes
    {
        public Codes[] koodi2;
        public Codes[] koodi5;
        public Codes[] koodi8;
        public Codes[] koodi10;
        public Codes[] koodi15;
    }

    public allCodes allCodesList = new allCodes();
    void Start()
    {
        allCodesList = JsonUtility.FromJson<allCodes>(textJSON.text);
        //allCodesList = JsonUtility.FromJsonOverwrite
        //Debug.Log(Codes[].koodi2)
        Debug.Log(allCodesList);
        Debug.Log(textJSON);
    }

}
