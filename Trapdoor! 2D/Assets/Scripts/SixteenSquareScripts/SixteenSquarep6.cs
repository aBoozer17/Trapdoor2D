using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//correct path is 4,5,10,14,15
public class SixteenSquarep6 : MonoBehaviour
{

    public bool showPathOnce = true;

    public GameObject tile4_right;
    public GameObject tile5_right;
    public GameObject tile10_right;
    public GameObject tile14_right;
    public GameObject tile15_right;


    public GameObject tile0_wrong;
    public GameObject tile1_wrong;
    public GameObject tile2_wrong;
    public GameObject tile3_wrong;
    public GameObject tile5_wrong;
    public GameObject tile6_wrong;
    public GameObject tile7_wrong;
    public GameObject tile8_wrong;
    public GameObject tile9_wrong;
    public GameObject tile10_wrong;
    public GameObject tile11_wrong;
    public GameObject tile12_wrong;
    public GameObject tile13_wrong;
    public GameObject tile14_wrong;
    public GameObject tile15_wrong;



    public Button tile0;
    public Button tile1;
    public Button tile2;
    public Button tile3;
    public Button tile4;
    public Button tile5;
    public Button tile6;
    public Button tile7;
    public Button tile8;
    public Button tile9;
    public Button tile10;
    public Button tile11;
    public Button tile12;
    public Button tile13;
    public Button tile14;
    public Button tile15;

    public bool tile4_isCorrect;
    public bool tile5_isCorrect;
    public bool tile10_isCorrect;
    public bool tile14_isCorrect;
    public bool tile15_isCorrect;


    public bool tile_isWrong;


    public AudioSource right;
    public AudioSource wrong;
    public AudioSource blink;
    public AudioSource scream;


    public GameObject fade;
    public GameObject tiles;


    public GameObject life1;
    public GameObject life2;
    public GameObject life3;

    public GameObject life1_empty;
    public GameObject life2_empty;
    public GameObject life3_empty;

    public GameObject popup;
    public GameObject trapdoor;

    public Sprite t1;
    public Sprite t2;
    public Sprite t3;
    public Sprite t4;

    public GameObject guy_standing;
    public GameObject guy_falling;
    public GameObject guy;

    public GameObject gameover;
    public GameObject levelcomplete;
    public GameObject levelName;

    private SwitchLevel sw = new SwitchLevel();

    //method the transitions a level forward or backward
    void go()
    {
        int current = MenuScript.levelNum;
        sw.setlevel(current);
        string path = sw.changelevel();
        SceneManager.LoadScene(path);
    }

    //hides the text messages before the level starts
    void Start()
    {
        gameover.SetActive(false);
        levelcomplete.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

        if (showPathOnce)
        {
            StartCoroutine(show());
            showPathOnce = false;
        }
        if (tile_isWrong)
        {
            MenuScript.levelNum -= 1;
            go();
        }

        if (tile15_isCorrect)
        {
            MenuScript.levelNum += 1;
            if (MenuScript.levelNum == 13)
            {
                SceneManager.LoadScene("Victory");
            }
            else
            {
                go();
            }
        }
    }

    //button 4
    public void tile4Click()
    {
        right.Play();
        tile4_right.SetActive(true);
        tile4_isCorrect = true;
    }

    //button 5
    public void tile5Click()
    {
        if (tile4_isCorrect)
        {
            right.Play();
            tile5_right.SetActive(true);
            tile5_isCorrect = true;
        }
        else
        {
            wrong.Play();
            tile5_wrong.SetActive(true);

            tile0.interactable = false;
            tile1.interactable = false;
            tile2.interactable = false;
            tile3.interactable = false;
            tile4.interactable = false;
            tile5.interactable = false;
            tile6.interactable = false;
            tile7.interactable = false;
            tile8.interactable = false;
            tile9.interactable = false;
            tile10.interactable = false;
            tile11.interactable = false;
            tile12.interactable = false;
            tile13.interactable = false;
            tile14.interactable = false;
            tile15.interactable = false;

            StartCoroutine(displayLives());
        }
    }

    //button 10
    public void tile10Click()
    {
        if (tile5_isCorrect)
        {
            right.Play();
            tile10_right.SetActive(true);
            tile10_isCorrect = true;
        }
        else
        {
            wrong.Play();
            tile10_wrong.SetActive(true);

            tile0.interactable = false;
            tile1.interactable = false;
            tile2.interactable = false;
            tile3.interactable = false;
            tile4.interactable = false;
            tile5.interactable = false;
            tile6.interactable = false;
            tile7.interactable = false;
            tile8.interactable = false;
            tile9.interactable = false;
            tile10.interactable = false;
            tile11.interactable = false;
            tile12.interactable = false;
            tile13.interactable = false;
            tile14.interactable = false;
            tile15.interactable = false;

            StartCoroutine(displayLives());
        }
    }

    //button 14
    public void tile14Click()
    {
        if (tile10_isCorrect)
        {
            right.Play();
            tile14_right.SetActive(true);
            tile14_isCorrect = true;
        }
        else
        {
            wrong.Play();
            tile14_wrong.SetActive(true);

            tile0.interactable = false;
            tile1.interactable = false;
            tile2.interactable = false;
            tile3.interactable = false;
            tile4.interactable = false;
            tile5.interactable = false;
            tile6.interactable = false;
            tile7.interactable = false;
            tile8.interactable = false;
            tile9.interactable = false;
            tile10.interactable = false;
            tile11.interactable = false;
            tile12.interactable = false;
            tile13.interactable = false;
            tile14.interactable = false;
            tile15.interactable = false;

            StartCoroutine(displayLives());
        }
    }

    

    //button 15
    public void tile15Click()
    {
        if (tile14_isCorrect)
        {
            right.Play();
            tile15_right.SetActive(true);
            StartCoroutine(forward());
        }
        else
        {
            wrong.Play();
            tile11_wrong.SetActive(true);

            tile0.interactable = false;
            tile1.interactable = false;
            tile2.interactable = false;
            tile3.interactable = false;
            tile4.interactable = false;
            tile5.interactable = false;
            tile6.interactable = false;
            tile7.interactable = false;
            tile8.interactable = false;
            tile9.interactable = false;
            tile10.interactable = false;
            tile11.interactable = false;
            tile12.interactable = false;
            tile13.interactable = false;
            tile14.interactable = false;
            tile15.interactable = false;

            StartCoroutine(displayLives());
        }
    }

    //button 0
    public void tile0Click()
    {
        wrong.Play();
        tile0_wrong.SetActive(true);

        tile0.interactable = false;
        tile1.interactable = false;
        tile2.interactable = false;
        tile3.interactable = false;
        tile4.interactable = false;
        tile5.interactable = false;
        tile6.interactable = false;
        tile7.interactable = false;
        tile8.interactable = false;
        tile9.interactable = false;
        tile10.interactable = false;
        tile11.interactable = false;
        tile12.interactable = false;
        tile13.interactable = false;
        tile14.interactable = false;
        tile15.interactable = false;

        StartCoroutine(displayLives());
    }

    //button 1
    public void tile1Click()
    {
        wrong.Play();
        tile1_wrong.SetActive(true);

        tile0.interactable = false;
        tile1.interactable = false;
        tile2.interactable = false;
        tile3.interactable = false;
        tile4.interactable = false;
        tile5.interactable = false;
        tile6.interactable = false;
        tile7.interactable = false;
        tile8.interactable = false;
        tile9.interactable = false;
        tile10.interactable = false;
        tile11.interactable = false;
        tile12.interactable = false;
        tile13.interactable = false;
        tile14.interactable = false;
        tile15.interactable = false;

        StartCoroutine(displayLives());
    }

    //button 2
    public void tile2Click()
    {
        wrong.Play();
        tile2_wrong.SetActive(true);

        tile0.interactable = false;
        tile1.interactable = false;
        tile2.interactable = false;
        tile3.interactable = false;
        tile4.interactable = false;
        tile5.interactable = false;
        tile6.interactable = false;
        tile7.interactable = false;
        tile8.interactable = false;
        tile9.interactable = false;
        tile10.interactable = false;
        tile11.interactable = false;
        tile12.interactable = false;
        tile13.interactable = false;
        tile14.interactable = false;
        tile15.interactable = false;

        StartCoroutine(displayLives());
    }

    //button 3
    public void tile3Click()
    {
        wrong.Play();
        tile3_wrong.SetActive(true);

        tile0.interactable = false;
        tile1.interactable = false;
        tile2.interactable = false;
        tile3.interactable = false;
        tile4.interactable = false;
        tile5.interactable = false;
        tile6.interactable = false;
        tile7.interactable = false;
        tile8.interactable = false;
        tile9.interactable = false;
        tile10.interactable = false;
        tile11.interactable = false;
        tile12.interactable = false;
        tile13.interactable = false;
        tile14.interactable = false;
        tile15.interactable = false;

        StartCoroutine(displayLives());
    }

    //button 6
    public void tile6Click()
    {
        wrong.Play();
        tile6_wrong.SetActive(true);

        tile0.interactable = false;
        tile1.interactable = false;
        tile2.interactable = false;
        tile3.interactable = false;
        tile4.interactable = false;
        tile5.interactable = false;
        tile6.interactable = false;
        tile7.interactable = false;
        tile8.interactable = false;
        tile9.interactable = false;
        tile10.interactable = false;
        tile11.interactable = false;
        tile12.interactable = false;
        tile13.interactable = false;
        tile14.interactable = false;
        tile15.interactable = false;

        StartCoroutine(displayLives());
    }

    //button 7
    public void tile7Click()
    {
        wrong.Play();
        tile7_wrong.SetActive(true);

        tile0.interactable = false;
        tile1.interactable = false;
        tile2.interactable = false;
        tile3.interactable = false;
        tile4.interactable = false;
        tile5.interactable = false;
        tile6.interactable = false;
        tile7.interactable = false;
        tile8.interactable = false;
        tile9.interactable = false;
        tile10.interactable = false;
        tile11.interactable = false;
        tile12.interactable = false;
        tile13.interactable = false;
        tile14.interactable = false;
        tile15.interactable = false;

        StartCoroutine(displayLives());
    }

    //button 8
    public void tile8Click()
    {
        wrong.Play();
        tile8_wrong.SetActive(true);

        tile0.interactable = false;
        tile1.interactable = false;
        tile2.interactable = false;
        tile3.interactable = false;
        tile4.interactable = false;
        tile5.interactable = false;
        tile6.interactable = false;
        tile7.interactable = false;
        tile8.interactable = false;
        tile9.interactable = false;
        tile10.interactable = false;
        tile11.interactable = false;
        tile12.interactable = false;
        tile13.interactable = false;
        tile14.interactable = false;
        tile15.interactable = false;

        StartCoroutine(displayLives());
    }

    //button 9
    public void tile9Click()
    {
        wrong.Play();
        tile9_wrong.SetActive(true);

        tile0.interactable = false;
        tile1.interactable = false;
        tile2.interactable = false;
        tile3.interactable = false;
        tile4.interactable = false;
        tile5.interactable = false;
        tile6.interactable = false;
        tile7.interactable = false;
        tile8.interactable = false;
        tile9.interactable = false;
        tile10.interactable = false;
        tile11.interactable = false;
        tile12.interactable = false;
        tile13.interactable = false;
        tile14.interactable = false;
        tile15.interactable = false;

        StartCoroutine(displayLives());
    }

    //button 11
    public void tile11Click()
    {
        wrong.Play();
        tile11_wrong.SetActive(true);

        tile0.interactable = false;
        tile1.interactable = false;
        tile2.interactable = false;
        tile3.interactable = false;
        tile4.interactable = false;
        tile5.interactable = false;
        tile6.interactable = false;
        tile7.interactable = false;
        tile8.interactable = false;
        tile9.interactable = false;
        tile10.interactable = false;
        tile11.interactable = false;
        tile12.interactable = false;
        tile13.interactable = false;
        tile14.interactable = false;
        tile15.interactable = false;

        StartCoroutine(displayLives());
    }

    //button 12
    public void tile12Click()
    {
        wrong.Play();
        tile12_wrong.SetActive(true);

        tile0.interactable = false;
        tile1.interactable = false;
        tile2.interactable = false;
        tile3.interactable = false;
        tile4.interactable = false;
        tile5.interactable = false;
        tile6.interactable = false;
        tile7.interactable = false;
        tile8.interactable = false;
        tile9.interactable = false;
        tile10.interactable = false;
        tile11.interactable = false;
        tile12.interactable = false;
        tile13.interactable = false;
        tile14.interactable = false;
        tile15.interactable = false;

        StartCoroutine(displayLives());
    }

    //button 13
    public void tile13Click()
    {
        wrong.Play();
        tile13_wrong.SetActive(true);

        tile0.interactable = false;
        tile1.interactable = false;
        tile2.interactable = false;
        tile3.interactable = false;
        tile4.interactable = false;
        tile5.interactable = false;
        tile6.interactable = false;
        tile7.interactable = false;
        tile8.interactable = false;
        tile9.interactable = false;
        tile10.interactable = false;
        tile11.interactable = false;
        tile12.interactable = false;
        tile13.interactable = false;
        tile14.interactable = false;
        tile15.interactable = false;

        StartCoroutine(displayLives());
    }



    //Method that pops up a success screen and starts the level transition
    IEnumerator forward()
    {
        yield return new WaitForSeconds(1);
        fade.SetActive(true);
        tiles.SetActive(false);
        popup.SetActive(true);

        popup.GetComponent<Animation>().Play("pop");

        yield return new WaitForSeconds(1);
        guy.GetComponent<Animation>().Play("stickrunning");
        yield return new WaitForSeconds(0.5f);
        levelcomplete.SetActive(true);
        levelcomplete.GetComponent<Animation>().Play("levelcomplete");
        yield return new WaitForSeconds(3);

        tile15_isCorrect = true;

    }

    //Incorrect tile method
    IEnumerator displayLives()
    {
        yield return new WaitForSeconds(1);
        fade.SetActive(true);
        tiles.SetActive(false);
        popup.SetActive(true);

        popup.GetComponent<Animation>().Play("pop");

        yield return new WaitForSeconds(1);
        life1_empty.SetActive(true);
        life2_empty.SetActive(true);
        life3_empty.SetActive(true);

        if (MenuScript.numLives >= 1)
        {
            life1.SetActive(true);
        }
        if (MenuScript.numLives >= 2)
        {
            life2.SetActive(true);
        }
        if (MenuScript.numLives == 3)
        {
            life3.SetActive(true);
        }
        guy_standing.SetActive(true);
        trapdoor.SetActive(true);


        MenuScript.numLives -= 1;
        yield return new WaitForSeconds(1);



        trapdoor.GetComponent<SpriteRenderer>().sprite = t2;
        yield return new WaitForSeconds(0.05f);
        trapdoor.GetComponent<SpriteRenderer>().sprite = t3;
        yield return new WaitForSeconds(0.05f);
        trapdoor.GetComponent<SpriteRenderer>().sprite = t4;
        yield return new WaitForSeconds(0.5f);

        guy_falling.SetActive(true);
        guy_standing.SetActive(false);

        scream.Play();
        guy_falling.GetComponent<Animation>().Play("falling");



        yield return new WaitForSeconds(1);
        if (MenuScript.numLives == 2)
        {
            life3.GetComponent<Animation>().Play("lifelost");
            yield return new WaitForSeconds(0.5f);
            life3.SetActive(false);
        }
        if (MenuScript.numLives == 1)
        {
            life2.GetComponent<Animation>().Play("lifelost2");
            yield return new WaitForSeconds(0.5f);
            life2.SetActive(false);
        }
        if (MenuScript.numLives == 0)
        {
            life1.GetComponent<Animation>().Play("lifelost3");
            yield return new WaitForSeconds(0.5f);
            life1.SetActive(false);
            yield return new WaitForSeconds(1);
            gameover.SetActive(true);
            gameover.GetComponent<Animation>().Play("gameover");
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene("Menu");
        }
        yield return new WaitForSeconds(2);

        tile_isWrong = true;

    }



    //Method that shows the correct path before enabling the buttons
    IEnumerator show()
    {
        levelName.SetActive(true);
        levelName.GetComponent<Animation>().Play("levelname");
        yield return new WaitForSeconds(3);
        levelName.SetActive(false);

        yield return new WaitForSeconds(1.5f);
        blink.Play();
        tile4_right.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        blink.Play();
        tile5_right.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        blink.Play();
        tile10_right.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        blink.Play();
        tile14_right.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        blink.Play();
        tile15_right.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        

        tile4_right.SetActive(false);
        tile5_right.SetActive(false);
        tile10_right.SetActive(false);
        tile14_right.SetActive(false);
        tile15_right.SetActive(false);


        tile0.interactable = true;
        tile1.interactable = true;
        tile2.interactable = true;
        tile3.interactable = true;
        tile4.interactable = true;
        tile5.interactable = true;
        tile6.interactable = true;
        tile7.interactable = true;
        tile8.interactable = true;
        tile9.interactable = true;
        tile10.interactable = true;
        tile11.interactable = true;
        tile12.interactable = true;
        tile13.interactable = true;
        tile14.interactable = true;
        tile15.interactable = true;
    }

}

