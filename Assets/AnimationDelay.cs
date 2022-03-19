using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationDelay : MonoBehaviour
{
    public Animator anim;
    public float delay = 5;
 
    void Start()
    {
        StartCoroutine(PlayAnimation());
    }

    IEnumerator PlayAnimation()
    {
        while (true)
        {
            anim.SetBool("play", true);
            yield return new WaitForSeconds(delay);
            anim.SetBool("play", false);
        }
    }

}
