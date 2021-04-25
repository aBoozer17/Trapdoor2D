using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public static int numLives = 3;
    public static int levelNum = 1;

    public GameObject title;
    public GameObject trapdoor;
    public GameObject figure;
    public GameObject standing;
    public GameObject falling;
    public GameObject play;
    public GameObject help;
    public GameObject exit;
    public GameObject next;
    public GameObject back;

    public GameObject help1;
    public GameObject help2;

    public GameObject playButton;
    public GameObject helpButton;
    public GameObject nextButton;
    public GameObject backButton;
    public GameObject exitButton;

    public AudioSource scream;
    public AudioSource blink;

    public Sprite t2;
    public Sprite t3;
    public Sprite t4;

    public SwitchLevel sw = new SwitchLevel();
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
        
        play.GetComponent<Animation>().Play("playgrow");
        help.GetComponent<Animation>().Play("helpgrow");
        next.GetComponent<Animation>().Play("nextgrow");
        back.GetComponent<Animation>().Play("backgrow");
        exit.GetComponent<Animation>().Play("exitgrow");
    }

    public void playGame()
    {
        blink.Play();
        StartCoroutine(startAnim());
        
    }

    public void showHelp()
    {
        blink.Play();
        title.SetActive(false);
        playButton.SetActive(false);
        helpButton.SetActive(false);
        nextButton.SetActive(true);
        exitButton.SetActive(true);
        exit.SetActive(true);
        help1.SetActive(true);
    }

    public void helpNext()
    {
        blink.Play();
        help1.SetActive(false);
        nextButton.SetActive(false);
        backButton.SetActive(true);
        help2.SetActive(true);
        
    }

    public void helpBack()
    {
        blink.Play();
        help1.SetActive(true);
        nextButton.SetActive(true);
        help2.SetActive(false);
        nextButton.SetActive(true);
    }

    public void close()
    {
        blink.Play();
        title.SetActive(true);
        exit.SetActive(false);
        exitButton.SetActive(false);
        help1.SetActive(false);
        help2.SetActive(false);
        nextButton.SetActive(false);
        backButton.SetActive(false);
        playButton.SetActive(true);
        helpButton.SetActive(true);

    }

    IEnumerator startAnim()
    {
        figure.SetActive(false);
        standing.SetActive(true);
        play.SetActive(false);
        help.SetActive(false);
        playButton.SetActive(false);
        helpButton.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        title.GetComponent<Animation>().Play("titleleave");
        yield return new WaitForSeconds(1.5f);

        trapdoor.GetComponent<SpriteRenderer>().sprite = t2;
        yield return new WaitForSeconds(0.05f);
        trapdoor.GetComponent<SpriteRenderer>().sprite = t3;
        yield return new WaitForSeconds(0.05f);
        trapdoor.GetComponent<SpriteRenderer>().sprite = t4;
        yield return new WaitForSeconds(0.5f);

        standing.SetActive(false);
        falling.SetActive(true);
        yield return new WaitForSeconds(0.5f);

        scream.Play();
        falling.GetComponent<Animation>().Play("menufall");
        yield return new WaitForSeconds(3.5f);


        numLives = 3;
        levelNum = 1;
        sw.setlevel(levelNum);
        string path = sw.changelevel();
        SceneManager.LoadScene(path);
    }

    IEnumerator display()
    {
        yield return new WaitForSeconds(1.5f);
        trapdoor.GetComponent<Animation>().Play("trapdoor");
        yield return new WaitForSeconds(1);
        figure.GetComponent<Animation>().Play("running");
        yield return new WaitForSeconds(0.5f);
        title.GetComponent<Animation>().Play("titleanim");
        yield return new WaitForSeconds(0.5f);
        play.SetActive(true);
        help.SetActive(true);
        playButton.SetActive(true);
        helpButton.SetActive(true);
    }
}
