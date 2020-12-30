using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestroyer : MonoBehaviour
{

    GameObject platformDestructionPoint;

    // Start is called before the first frame update
    void Start()
    {
        platformDestructionPoint = GameObject.Find("PlatformDestructionPoint");
    }

    // Update is called once per frame
    void Update()
    {
        DestroyPlatform();
    }

    void DestroyPlatform()
    {
        if(transform.position.x < platformDestructionPoint.transform.position.x)
        {
            // Destroy(this.gameObject);
            gameObject.SetActive(false);
        }
    }
}
