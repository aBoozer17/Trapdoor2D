﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class FourSquarep1 : MonoBehaviour
{
    //correct path is 2, 0, 1
public bool showPathOnce = true;
public GameObject tile0_right;
public GameObject tile1_right;
public GameObject tile2_right;


public GameObject tile0_wrong;
public GameObject tile1_wrong;
public GameObject tile3_wrong;


    public Button tile0;
    public Button tile1;
    public Button tile2;
    public Button tile3;

    public bool tile0_isCorrect;
public bool tile1_isCorrect;
public bool tile2_isCorrect;

    public bool tile0_isWrong;
    public bool tile1_isWrong;
    public bool tile3_isWrong;

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
    if (tile0_isWrong || tile1_isWrong || tile3_isWrong)
        {
            MenuScript.levelNum -= 1;
            go();
        }

    if (tile0_isCorrect && tile1_isCorrect && tile2_isCorrect)
    {
            MenuScript.levelNum += 1;
        if (MenuScript.levelNum == 5)
        {
            SceneManager.LoadScene("Menu");
        }
        else
        {
                
                go();
        }




        }
}

//check the correct buttons
public void tile2Click()
{
        right.Play();
    tile2_right.SetActive(true);
    tile2_isCorrect = true;
}


public void tile0Click()
{
    if (tile2_isCorrect)
    {
            right.Play();
            tile0_right.SetActive(true);
        tile0_isCorrect = true;
    }
    else
    {
            wrong.Play();
            tile0_wrong.SetActive(true);
            tile0.interactable = false;
            tile1.interactable = false;
            tile2.interactable = false;
            tile3.interactable = false;


            if (MenuScript.levelNum == 1)
        {
            StartCoroutine(reset());
        }
        else
        {
                StartCoroutine(wrong0());
            }
    }

}
public void tile1Click()
{
    if (tile0_isCorrect && tile2_isCorrect)
    {
            right.Play();
            tile1_right.SetActive(true);
            StartCoroutine(forward());
    }
    else
    {
            wrong.Play();
            tile1_wrong.SetActive(true);
            tile0.interactable = false;
            tile1.interactable = false;
            tile2.interactable = false;
            tile3.interactable = false;

            if (MenuScript.levelNum == 1)
        {
            StartCoroutine(reset());
        }
        else
        {

                StartCoroutine(wrong1());
            }
    }
}
public void tile3Click()
{
        wrong.Play();
        tile3_wrong.SetActive(true);
        tile0.interactable = false;
        tile1.interactable = false;
        tile2.interactable = false;
        tile3.interactable = false;

        if (MenuScript.levelNum == 1)
    {
        StartCoroutine(reset());
    }
    else
    {
            StartCoroutine(wrong3());
        }
}
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

        tile1_isCorrect = true;

    }

IEnumerator wrong0()
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

        tile0_isWrong = true;
        
    }
    IEnumerator wrong1()
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

        tile1_isWrong = true;
        
    }
    IEnumerator wrong3()
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

        tile3_isWrong = true;

    }


    IEnumerator show()
{
        levelName.SetActive(true);
        levelName.GetComponent<Animation>().Play("levelname");
    yield return new WaitForSeconds(3);
        levelName.SetActive(false);
        yield return new WaitForSeconds(1.5f);
        blink.Play();
        tile2_right.SetActive(true);
    yield return new WaitForSeconds(1);
        blink.Play();
        tile0_right.SetActive(true);
    yield return new WaitForSeconds(1);
        blink.Play();
        tile1_right.SetActive(true);
    yield return new WaitForSeconds(1);

    tile1_right.SetActive(false);
    tile0_right.SetActive(false);
    tile2_right.SetActive(false);

        tile0.interactable = true;
        tile1.interactable = true;
        tile2.interactable = true;
        tile3.interactable = true;
    }
IEnumerator reset()
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
        yield return new WaitForSeconds(3);



        trapdoor.GetComponent<SpriteRenderer>().sprite = t1;
        guy_falling.SetActive(false);

        trapdoor.SetActive(false);
        life1_empty.SetActive(false);
        life2_empty.SetActive(false);
        life3_empty.SetActive(false);

        life1.SetActive(false);
        life2.SetActive(false);
        life3.SetActive(false);

        

        popup.GetComponent<Animation>().Play("popdown");
        trapdoor.SetActive(false);
        popup.SetActive(false);
        fade.SetActive(false);
        tiles.SetActive(true);

        tile0_right.SetActive(false);
    tile2_right.SetActive(false);


    tile1_wrong.SetActive(false);
    tile0_wrong.SetActive(false);
    tile3_wrong.SetActive(false);



    tile0_isCorrect = false;
    tile1_isCorrect = false;
    tile2_isCorrect = false;

        


        showPathOnce = true;
}

    


}
