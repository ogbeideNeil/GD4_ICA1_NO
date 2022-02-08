using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDie : MonoBehaviour
{
    // Start is called before the first frame update

    public static DontDie instance;

    void Start()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
