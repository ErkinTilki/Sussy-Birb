using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawnScript : MonoBehaviour
{
    public GameObject Cloud;
    public float hightoffset = 1;
    public float spawnRate = 2;
    public float timer = 0;
    void Start()
    {
        spawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnRate > timer) {
            timer += Time.deltaTime;
        }
        else
        {
            spawnCloud();
            timer = 0;
        }

         
    }
    void spawnCloud() {
        float lowestPoint = transform.position.y - hightoffset;
        float highestPoint = transform.position.y + hightoffset;
        Instantiate(Cloud, new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint)), transform.rotation);
    }
}
