using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerate : MonoBehaviour
{
   
    public GameObject[] prefabsList = new GameObject[10];
    public float plotnost = 1f;
    GameObject[] oldList = new GameObject[10];
    GameObject[] newList = new GameObject[10];



    private void Start()
    {
        Generate();
    }
    private void FixedUpdate()
    {   
        plotnost = 1f + 0.01f*(Public.score/1000f);
        for(int i=0; i<10; i++){
               oldList[i]=newList[i];
        }
        if(oldList[9] == null || oldList[9].transform.position.y>5f){
            DestroyItems();
            Generate();
        }

    }
    public void DestroyItems(){
        for(int i=0; i<10; i++){
                Destroy(oldList[i]);
            }
    }
    public void Generate(){

        Vector3 SpawnerPosition = new Vector3();
        for(int i=0; i<10; i++){
            SpawnerPosition.x =  Random.Range(-2f,2f);
            SpawnerPosition.y -= Random.Range(3f * (1/plotnost),6f * (1/plotnost));
            
            int rndm = Random.Range(0,100);
            int choose=0;
            if(rndm<40 && rndm >=0){
                choose = 0;
            }else if(rndm>=40 && rndm < 60){
                choose = 4;
            }else if(rndm>=60 && rndm < 70){
                choose = 2;
            }else if(rndm >=70 && rndm < 90){
                choose = 1;
            }else if(rndm >=90 && rndm <100){
                choose = 3;
            }

            newList[i] = Instantiate(prefabsList[choose], SpawnerPosition,Quaternion.identity);   
        }    
    }
    /*
    void Start()
    {
        StartCoroutine(Spawner());
    }

    
    IEnumerator Spawner()
    {
        GameObject[] newList = new GameObject[10];
        while(true){
            
            Vector3 SpawnerPosition = new Vector3();
            
            for(int i=0; i<10; i++){
                SpawnerPosition.x =  Random.Range(-2f,2f);
                SpawnerPosition.y += Random.Range(-3f,-6f);
                newList[i] = Instantiate(prefabsList[Random.Range(0,10)], SpawnerPosition,Quaternion.identity);
                Destroy(newList[i],10);
            }
            yield return new WaitForSeconds(10);
            
        }
        yield break;
    }
    */
}
