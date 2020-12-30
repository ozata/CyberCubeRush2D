using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{

    public Transform generationPoint;

    private float distanceBetween;

    private float platformWidth;

    public float distanceBetweenMin;
    public float distanceBetweenMax;


    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        GeneratePlatform();
    }

    void GeneratePlatform()
    {
        if(transform.position.x < generationPoint.transform.position.x)
        {
            GameObject platform = ObjectPooler.Instance.GetGameObject();
            platformWidth = platform.GetComponent<BoxCollider2D>().size.x;
            distanceBetween = Random.Range(distanceBetweenMin, distanceBetweenMax);
            transform.position = new Vector3(transform.position.x + platformWidth + distanceBetween, transform.position.y, transform.position.z);
            platform.transform.position = transform.position;
            platform.transform.rotation = transform.rotation;
            platform.SetActive(true);
        }
    }
}
