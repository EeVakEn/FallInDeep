using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteStat : MonoBehaviour
{
    // Start is called before the first frame update
    public void DeleteStats(){
        PlayerPrefs.DeleteAll();
    }
}
