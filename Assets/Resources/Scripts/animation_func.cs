using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation_func : MonoBehaviour
{
    private SpriteRenderer targrender;
    private Sprite initialsprite;
    public List<Sprite> framelist = new List<Sprite>();
    public int anim_type = 1, loop_order = 0;
    public float sec = .2f;
    public bool start, stop, isactive, returnstate;

    private void Start()
    {
        targrender = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (start && !isactive)
        {
            if (this.gameObject.TryGetComponent<Animator>(out Animator comp))
            {
                comp.enabled = false;
            }

            initialsprite = targrender.sprite;

            StartCoroutine(animationbehaviour());
            isactive = true;
            start = false;
        }

        if (stop)
        {
            if (returnstate) 
            {
                if (this.gameObject.TryGetComponent<Animator>(out Animator comp))
                {
                    comp.enabled = true;
                }
                targrender.sprite = initialsprite; 
            }

            StopAllCoroutines();
            framelist = new List<Sprite>();

            isactive = false;
            stop = false;
        }
    }

    public IEnumerator animationbehaviour()
    {
        var play = true;
        while (play)
        {
            yield return null;

            if (anim_type == 0)
            {
                foreach (Sprite spr in framelist)
                {
                    targrender.sprite = spr;
                    yield return new WaitForSeconds(sec);
                }
                play = false;
            }

            if (anim_type == 1)
            {
                switch (loop_order)
                {
                    case 0:
                        //forward-loop
                        foreach (Sprite spr in framelist)
                        {
                            targrender.sprite = spr;
                            yield return new WaitForSeconds(sec);
                        }
                        continue;
                    case 1:
                        //ping-pong

                        //forward
                        for (int i = 0; i < framelist.Count; i++)
                        {
                            targrender.sprite = framelist[i];
                            yield return new WaitForSeconds(sec);
                        }

                        yield return null;

                        //backwards
                        for (int i = framelist.Count -1; i > 0; i--)
                        {
                            targrender.sprite = framelist[i];
                            yield return new WaitForSeconds(sec);
                        }

                        yield return null;
                        continue;
                }
            }
        }

        yield return null;

        stop = true;
    }
}
