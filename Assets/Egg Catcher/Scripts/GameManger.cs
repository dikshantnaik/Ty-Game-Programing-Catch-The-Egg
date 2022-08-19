using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    public GameObject egg_prefab;
    public int score = 0;
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.tag == "Egg"){
            score+=1;
            Destroy(collision.gameObject);
        }
    }
    
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
