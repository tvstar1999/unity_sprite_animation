using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class call_script : MonoBehaviour
{
    private animation_func anim;
    public bool activate;

    private void Start()
    {
        anim = GetComponent<animation_func>();
    }

    private void Update()
    {
        if (activate)
        {
            anim.framelist.Add(Resources.Load<Sprite>("Sprites/wingMan1"));
            anim.framelist.Add(Resources.Load<Sprite>("Sprites/wingMan2"));
            anim.framelist.Add(Resources.Load<Sprite>("Sprites/wingMan3"));
            anim.framelist.Add(Resources.Load<Sprite>("Sprites/wingMan4"));
            anim.framelist.Add(Resources.Load<Sprite>("Sprites/wingMan5"));
            anim.anim_type = 1;
            anim.loop_order = 1;
            anim.sec = 0.1f;
            anim.returnstate = true;
            anim.start = true;

            activate = false;
        }
    }

}
