using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Script that displays the victory screen when the player completes
//all twelve levels. It only displays for a moment before the program
//redirects the user back to the menu.
public class VictoryScript : MonoBehaviour
{
    public GameObject figure;
    public GameObject text;
    public bool load;

    
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(display());
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

        figure.GetComponent<Animation>().Play("jump");
        if (load)
        {
            SceneManager.LoadScene("Menu");
        }
    }

    IEnumerator display()
    {
        yield return new WaitForSeconds(1.5f);
        text.GetComponent<Animation>().Play("victorytxt");
        yield return new WaitForSeconds(1.5f);
        figure.SetActive(true);
        
        yield return new WaitForSeconds(4);
        load = true;
    }
}
