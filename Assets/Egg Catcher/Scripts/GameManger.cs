using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    public GameObject egg_prefab;
  
    
    void Start()
    {
        InvokeRepeating("SpawnEgg",2,2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void SpawnEgg(){
        float tempPos = Random.Range(-8f,8f);
        Instantiate(egg_prefab,new Vector3(tempPos,5.34f,0),Quaternion.identity);

    }
}
