using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChevronFloat : MonoBehaviour
{
    public LeanTweenType easeType;
    public AnimationCurve curve;
    public float duration, delay;
    public Transform origin;

    private Highlight _highlight;

    private void Start()
    {
        _highlight = FindObjectOfType<Highlight>();
    }

    void OnEnable()
    {
        if (easeType == LeanTweenType.animationCurve)
        {
            if (transform.position == origin.position)
            {
                LeanTween.moveY(gameObject, 12f, duration).setLoopPingPong().setEase(curve);

            }
        }
    }

    private void OnDisable()
    {
        gameObject.transform.position = origin.position;

        LeanTween.pause(LeanTween.moveY(gameObject, 12f, duration).setLoopPingPong().setEase(curve).id);
    }
}
