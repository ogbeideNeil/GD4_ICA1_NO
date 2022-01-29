using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeanFade : MonoBehaviour
{
    [SerializeField]
    private GameObject objectToFade;

    [SerializeField]
    private LayerMask triggerObjectLayerMask;

    [SerializeField]
    [Min(0.1f)]
    private float fadeTimeSecs = 1;

    [SerializeField]
    private LeanTweenType easeType = LeanTweenType.linear;

    public void OnTriggerEnter(Collider collider)
    {
       
            //fade to transparent using the ease curve
            LeanTween.alpha(objectToFade, 0.3f, fadeTimeSecs);//.setEase(easeType);
        
    }

    public void OnTriggerExit(Collider collider)
    {
        
            //fade to opaque using the ease curve
            LeanTween.alpha(objectToFade, 1, fadeTimeSecs).setEase(easeType);
        
    }



}
