using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{



    private Transform player;
    public float offset = 2f;

    void Start()
    {
        FindPlayer();
    }

    public void FindPlayer()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        transform.position = new Vector3(0, player.position.y-offset,transform.position.z);
    }

    void Update()
    {
        FindPlayer();
    }
}
