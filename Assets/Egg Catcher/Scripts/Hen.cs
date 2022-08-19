using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hen : MonoBehaviour
{
    [SerializeField]
    int speed;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(new Vector3(1,0,0)*speed*Time.deltaTime);

        }
                if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(new Vector3(-1,0,0)*speed*Time.deltaTime);
            
        }
        float currentXPos  = transform.position.x;
        currentXPos = Mathf.Clamp(currentXPos,-8f,8f);
        transform .position = new Vector3(currentXPos,transform.position.y,transform.position .z);    
    }
    
}

