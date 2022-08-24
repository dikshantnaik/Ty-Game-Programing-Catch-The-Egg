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

      public GameObject[] hearts;
    public int life;
    void Start()
    {
        InvokeRepeating("SpawnEgg",startIn,(float)EggSpawnSpeed);
    }

    void SpawnEgg(){
        float tempPos = Random.Range(-8f,8f);
        Instantiate(egg_prefab,new Vector3(tempPos,5.34f,0),Quaternion.identity);

    }
    public void StopSpawning(){
        CancelInvoke();
    }


    //Heart System


    public void takeDamage(int d){
        life -= d;
    }

    private void Update() {
        if(life<1){
            Destroy(hearts[0].gameObject);
        }
        else if(life<2){
            Destroy(hearts[1].gameObject);
        }
        else if(life<3){
            Destroy(hearts[2].gameObject);
        }
    }
}
