using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChevronFloat : MonoBehaviour
{
    public LeanTweenType easeType;
    public AnimationCurve curve;
    public float duration, delay;
    public Transform origin;

    void OnEnable()
    {
        if (easeType == LeanTweenType.animationCurve)
        {
            LeanTween.moveY(gameObject, 12f, duration).setLoopPingPong().setEase(curve);
        }
        else
        {
            LeanTween.moveY(gameObject, 12f, duration).setLoopPingPong().setEase(easeType);
        }
    }
}
