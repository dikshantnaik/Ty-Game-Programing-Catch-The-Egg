using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
        public GameObject egg_splash_pref;
        public GameManger game_manager;

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.tag == "Egg"){
            GameObject egg = collision.gameObject;
            Destroy(egg);
           GameObject egg_splash_pref2=  Instantiate(egg_splash_pref,new Vector3(egg.transform.position.x,egg.transform.position.y,0),Quaternion.identity);
            Destroy(egg_splash_pref2,1);
            game_manager.takeDamage(1);            
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
