
using UnityEngine;

public class MoveAndSpawnWalls : MonoBehaviour
{
    float speed=5f;
    public GameObject road;
    void Update()
    {
        transform.Translate(Vector3.up*speed*Time.deltaTime);
        if(transform.position.y>8){
            Instantiate(road,new Vector3(-2.35f,-9.695182f,0),Quaternion.identity);
            Destroy(gameObject);
        }
          
    }
}
