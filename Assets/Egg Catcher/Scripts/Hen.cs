using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Hen : MonoBehaviour
{
    [SerializeField]
    int speed;

    public GameManger game_manager;
      public int score = 0;
    public TMP_Text _title;
    
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.tag == "Egg"){
            score+=1;
            _title.text = "Score : "+score.ToString();
            Destroy(collision.gameObject);
            Debug.Log(collision.gameObject.transform.position.x);
        }

        if (score==game_manager.target_score)
        {
            game_manager.StopSpawning();
        }
    }
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D )){
            transform.Translate(new Vector3(1,0,0)*speed*Time.deltaTime);

        }
                if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)){
            transform.Translate(new Vector3(-1,0,0)*speed*Time.deltaTime);
            
        }
        float currentXPos  = transform.position.x;
        // Debug.Log(transform.position.x);
        currentXPos = Mathf.Clamp(currentXPos,-8f,8f);
        transform .position = new Vector3(currentXPos,transform.position.y,transform.position .z);    
    }
    
}

