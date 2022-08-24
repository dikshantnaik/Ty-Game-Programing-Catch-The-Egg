using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
 {
    Debug.Log("Hello");
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
 }
  
}
