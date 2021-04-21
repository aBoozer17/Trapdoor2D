﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//correct path is 0, 3, 7, 5
public class NineSquarep7 : MonoBehaviour
{

    public bool showPathOnce = true;

    public GameObject tile0_right;
    public GameObject tile3_right;
    public GameObject tile7_right;
    public GameObject tile5_right;
    

    public GameObject tile1_wrong;
    public GameObject tile2_wrong;
    public GameObject tile3_wrong;
    public GameObject tile4_wrong;
    public GameObject tile5_wrong;
    public GameObject tile6_wrong;
    public GameObject tile7_wrong;
    public GameObject tile8_wrong;



    public Button tile0;
    public Button tile1;
    public Button tile2;
    public Button tile3;
    public Button tile4;
    public Button tile5;
    public Button tile6;
    public Button tile7;
    public Button tile8;

    public bool tile0_isCorrect;
    public bool tile3_isCorrect;
    public bool tile7_isCorrect;
    public bool tile5_isCorrect;

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


    // Update is called once per frame
    void Update()
    {
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

        if (tile5_isCorrect)
        {
            MenuScript.levelNum += 1;
            go();
        }
    }

    //button 0
    public void tile0Click()
    {
        right.Play();
        tile0_right.SetActive(true);
        tile0_isCorrect = true;
    }

    //button 3
    public void tile3Click()
    {
        if (tile0_isCorrect)
        {
            right.Play();
            tile3_right.SetActive(true);
            tile3_isCorrect = true;
        }
        else
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

            StartCoroutine(displayLives());
        }
    }

    //button 7
    public void tile7Click()
    {
        if (tile3_isCorrect)
        {
            right.Play();
            tile7_right.SetActive(true);
            tile7_isCorrect = true;
        }
        else
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

            StartCoroutine(displayLives());
        }
    }


    //button 5
    public void tile5Click()
    {
        if (tile7_isCorrect)
        {
            right.Play();
            tile5_right.SetActive(true);
            StartCoroutine(forward());
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

            StartCoroutine(displayLives());
        }
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

        StartCoroutine(displayLives());
    }

    //button 4
    public void tile4Click()
    {
        wrong.Play();
        tile4_wrong.SetActive(true);

        tile0.interactable = false;
        tile1.interactable = false;
        tile2.interactable = false;
        tile3.interactable = false;
        tile4.interactable = false;
        tile5.interactable = false;
        tile6.interactable = false;
        tile7.interactable = false;
        tile8.interactable = false;

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
        levelcomplete.GetComponent<Animation>().Play("levelcomplete");
        yield return new WaitForSeconds(3);

        tile5_isCorrect = true;

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
        tile0_right.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        blink.Play();
        tile3_right.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        blink.Play();
        tile7_right.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        blink.Play();
        tile5_right.SetActive(true);
        yield return new WaitForSeconds(0.7f);

        tile0_right.SetActive(false);
        tile3_right.SetActive(false);
        tile7_right.SetActive(false);
        tile5_right.SetActive(false);

        tile0.interactable = true;
        tile1.interactable = true;
        tile2.interactable = true;
        tile3.interactable = true;
        tile4.interactable = true;
        tile5.interactable = true;
        tile6.interactable = true;
        tile7.interactable = true;
        tile8.interactable = true;
    }

}

