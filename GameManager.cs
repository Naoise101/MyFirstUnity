// did not include in alpha version as when I did game would not compile + crashed computer etc
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagment;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<GameObject> Threat;
    public TextMeshProUGUI gameOverText;
    public Button restartButton;
    
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void GameOver(){
    
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
    }
    
    public void RestartGame(){
    
        restartButton.gameObject.setActive(true);
        //Restart game () function missing ???
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}