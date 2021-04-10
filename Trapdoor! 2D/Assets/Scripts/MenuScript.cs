using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public static int numLives = 3;
    public static int levelNum = 1;
    public SwitchLevel sw = new SwitchLevel();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playGame()
    {
        levelNum = 1;
        sw.setlevel(levelNum);
        string path = sw.changelevel();
        SceneManager.LoadScene(path);
    }
}
