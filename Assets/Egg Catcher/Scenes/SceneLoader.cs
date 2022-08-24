using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    // public void LoadNextScene(){
    //     Debug.Log("Hheheh");
    //     SceneManager.LoadScene("Main");
    // }
    // public void LoadStartScene(){
    //     SceneManager.LoadScene(0);
    // }
    public void StartGame()
 {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
 }
    // Update is called once per frame
} 
