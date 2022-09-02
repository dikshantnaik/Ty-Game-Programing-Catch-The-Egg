using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManger : MonoBehaviour
{
    [SerializeField]
    float EggSpawnSpeed ;
    

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
        float tempPos = Random.Range(-7f,7f);
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
        //Checking Life 
        if(life<1){
            Destroy(hearts[0].gameObject);
            SceneManager.LoadScene("GameOverScreen");
        }
        else if(life<2){
            Destroy(hearts[1].gameObject);
        }
        else if(life<3){
            Destroy(hearts[2].gameObject);
        }
    }
}
