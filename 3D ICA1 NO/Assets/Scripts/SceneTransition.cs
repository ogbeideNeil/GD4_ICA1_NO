using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{

    public string sceneToLoad;

    public void OnTriggerEnter(Collider other)
    {
        //if (other.CompareTag("Player"))
        if(other.attachedRigidbody.isKinematic)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }

    

    //public void ontri

}
