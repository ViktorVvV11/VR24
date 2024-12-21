using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Script2 : MonoBehaviour
{
    public int x = 3;
    public Text txt;
    public void OnCollisionEnter(Collision collision)
    {
        x--;
        txt.text = x.ToString();
    }
}
