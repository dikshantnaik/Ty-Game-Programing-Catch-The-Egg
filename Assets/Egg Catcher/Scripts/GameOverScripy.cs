using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverScripy : MonoBehaviour
{
      public TMP_Text _score;
    //   public Hen hen;
    // Start is called before the first frame update
    void Start()
    {
        int score = Hen.score;
         _score.text = "Score : "+score.ToString();
    }

    // Update is called once per frame
    public void onClickRestart(){  
        SceneManager.LoadScene("Level_1");
    }
    public  void onClickClose(){
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                SceneManager.LoadScene("MainMenu2");

        #if UNITY_STANDALONE
        Application.Quit();
    #endif
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #endif
    }
    void Update()
    {
       
        
    }
}
