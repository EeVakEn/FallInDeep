using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGspawner : MonoBehaviour
{
    public float speed=5f;
    public GameObject road;
    void Update()
    {
        transform.Translate(Vector3.up*speed*Time.deltaTime);
        if(transform.position.y>17.5f){
            Instantiate(road,new Vector3(0.008597851f,-20f,0f),Quaternion.identity);
            Destroy(gameObject);
        }
          
    }
}
