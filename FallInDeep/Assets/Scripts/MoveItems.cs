using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveItems : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed=0.5f;
    private int vect;
    private void Start()
    {
        vect = Random.Range(-1,2);
    }
    // Update is called once per frame
    void Update()
    {
        if(transform.position.x<-1.5f || transform.position.x>1.5f){
            vect=-vect;
        }
        transform.Translate(vect * speed * Time.deltaTime,0,0);
    }
    
}
