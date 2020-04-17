using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScreenFloat : MonoBehaviour
{
    public LeanTweenType easeType;
    public AnimationCurve curve;
    public float duration, delay;

    void OnEnable()
    {
       
        if(easeType == LeanTweenType.animationCurve)
        {
            LeanTween.moveY(gameObject, 43f, duration).setLoopPingPong().setEase(curve);
        }
        else
        {
            LeanTween.moveY(gameObject, 43f, duration).setLoopPingPong().setEase(easeType);
        }
    }
}
