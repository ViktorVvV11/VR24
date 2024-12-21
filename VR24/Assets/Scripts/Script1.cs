using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Script1 : MonoBehaviour
{
    public GameObject ob;
    public void ClickButton()
    {
        ob.SetActive(!(ob.activeSelf));
    }
}