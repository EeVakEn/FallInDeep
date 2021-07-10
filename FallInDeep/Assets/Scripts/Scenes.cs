using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scenes : MonoBehaviour
{
    public void ChangeScenes(int num){
        SceneManager.LoadScene(num);
    }
    public void Exit(){
        Application.Quit();
    }
}
