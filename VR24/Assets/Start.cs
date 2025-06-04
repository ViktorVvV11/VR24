using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start : MonoBehaviour
{
    public Animator anim;
    private void OnMouseDown()
    {
        anim.SetTrigger("Go");
    }
}
