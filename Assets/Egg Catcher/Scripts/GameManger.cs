using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    [SerializeField]
    int EggSpawnSpeed = 1;
    

    public Hen hen;
    public GameObject egg_prefab;
    public float startIn = 2;
    public int target_score = 10;
    void Start()
    {
        InvokeRepeating("SpawnEgg",startIn,(float)EggSpawnSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void SpawnEgg(){
        float tempPos = Random.Range(-8f,8f);
        Instantiate(egg_prefab,new Vector3(tempPos,5.34f,0),Quaternion.identity);

    }
    public void StopSpawning(){
        CancelInvoke();
    }
}
