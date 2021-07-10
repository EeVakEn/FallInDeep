using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class healthbar : MonoBehaviour
{
    public Image bar;
    public float fill;
    // Start is called before the first frame update
    void Start()
    {
        fill = 1f;
    }
    
    // Update is called once per frame
    void Update()
    {
        bar.fillAmount = fill;
        if(fill > 1f){
            fill = 1f;
        }
        if(fill <= 0f){
            fill = 0f;
            
            StartCoroutine(pause());
            
        }
    }
    IEnumerator pause(){ 
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene(2);
    }

}
