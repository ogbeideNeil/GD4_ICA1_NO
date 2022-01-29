using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeTransparent : MonoBehaviour
{
    [SerializeField] private List<IntheWay> currentlyInWay;
    [SerializeField] private List<IntheWay> alreadyTrans;
    [SerializeField] private Transform player;
    private Transform camera;



    // Update is called once per frame
    void Update()
    {
        GetObjectsInWay();
        MakeSolid();
        MakeObjectsTransparent();
    }

    private void Awake()
    {
        currentlyInWay = new List<IntheWay>();
        alreadyTrans = new List<IntheWay>();
        camera = this.gameObject.transform;
    }


    private void GetObjectsInWay() {

        currentlyInWay.Clear();

        float cameraDistance = Vector3.Magnitude(camera.position - player.position);
        Ray ray_forward = new Ray(camera.position, player.position - camera.position);
        Ray ray_backward = new Ray(player.position, camera.position - player.position);
        var hits_forward = Physics.RaycastAll(ray_forward, cameraDistance);
        var hits_backward = Physics.RaycastAll(ray_backward, cameraDistance);


        foreach (var hit in hits_forward) {
            if(hit.collider.gameObject.TryGetComponent(out IntheWay isInTheWay))
            {
                if (!currentlyInWay.Contains(isInTheWay))
                {
                    currentlyInWay.Add(isInTheWay);
                }
            }
        }

        foreach (var hit in hits_backward)
        {
            if (hit.collider.gameObject.TryGetComponent(out IntheWay isInTheWay))
            {
                if (!currentlyInWay.Contains(isInTheWay))
                {
                    currentlyInWay.Add(isInTheWay);
                }
            }
        }



    }

    private void MakeObjectsTransparent() { 
        for(int i = 0; i< currentlyInWay.Count; i++)
        {
            IntheWay intheWay = currentlyInWay[i];
            if (!alreadyTrans.Contains(intheWay))
            {
                intheWay.ShowTransparent();
                alreadyTrans.Add(intheWay);
            }
        }
    }


    private void MakeSolid() {
        for (int i = 0; i < alreadyTrans.Count -1; i++)
        {
            IntheWay WasintheWay = currentlyInWay[i];
            if (!currentlyInWay.Contains(WasintheWay))
            {
                
                WasintheWay.ShowSolid();
                alreadyTrans.Remove(WasintheWay);
            }
        }
    }

}
