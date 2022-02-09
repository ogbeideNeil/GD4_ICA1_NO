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

    private Vector3 startpos;

    private Vector3 min;// = 0,0,0;

    public void OnTriggerEnter(Collider collider)
    {
        startpos = objectToFade.transform.position;
       
            //fade to transparent using the ease curve
            LeanTween.alpha(objectToFade, 0.3f, fadeTimeSecs);//.setEase(easeType);
        if(objectToFade.name == "Cube (6)" || objectToFade.name == "wall+door (1)")
        {
            //LeanTween.alpha(objectToFade, 0f, fadeTimeSecs);
            //LeanTween.moveY(objectToFade, 50f, fadeTimeSecs);
            //LeanTween.scale(objectToFade)
        }
        
    }

    public void OnTriggerExit(Collider collider)
    {
        
            //fade to opaque using the ease curve
            LeanTween.alpha(objectToFade, 1, fadeTimeSecs).setEase(easeType);

        if (objectToFade.name == "Cube (6)" || objectToFade.name == "wall+door (1)")
        {
            //LeanTween.alpha(objectToFade, 0f, fadeTimeSecs);
            //LeanTween.moveY(objectToFade, 0f, fadeTimeSecs);
            //LeanTween.scale(objectToFade)
        }

    }



}
