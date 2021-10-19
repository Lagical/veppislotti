using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hyperlink : MonoBehaviour
{

    public void OpenLink()
    {
        Application.OpenURL("https://veppi.fi/");
        TextEditor kopioi = new TextEditor();
        kopioi.text = "Testi";
        kopioi.SelectAll();
        kopioi.Copy();
    }

}
