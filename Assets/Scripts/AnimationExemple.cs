using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationExemple : MonoBehaviour
{
    public Animation animation;

    public AnimationClip idle;
    public AnimationClip run;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            PlayAnimation(run);
        }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            PlayAnimation(idle);
        }
    }


    private void PlayAnimation(AnimationClip c)
    {
        animation.CrossFade(c.name);
    }

}
