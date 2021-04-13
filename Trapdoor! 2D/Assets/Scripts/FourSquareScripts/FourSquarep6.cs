using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class FourSquarep6 : MonoBehaviour
{
    //correct path is 2, 3, 1
    public bool showPathOnce = true;
    public GameObject tile2_right;
    public GameObject tile3_right;
    public GameObject tile1_right;


    public GameObject tile0_wrong;
    public GameObject tile1_wrong;
    public GameObject tile3_wrong;

    public Button tile0;
    public Button tile1;
    public Button tile2;
    public Button tile3;

    public bool tile2_isCorrect;
    public bool tile3_isCorrect;
    public bool tile1_isCorrect;

    public bool tile0_isWrong;
    public bool tile3_isWrong;
    public bool tile1_isWrong;

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

        if (tile2_isCorrect && tile3_isCorrect && tile1_isCorrect)
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
        tile2_right.SetActive(true);
        tile2_isCorrect = true;
    }


    public void tile3Click()
    {
        if (tile2_isCorrect)
        {
            tile3_right.SetActive(true);
            tile3_isCorrect = true;
        }
        else
        {
            tile3_wrong.SetActive(true);

            if (MenuScript.levelNum == 1)
            {
                StartCoroutine(reset());
            }
            else
            {
                
                StartCoroutine(wrong3());
                
            }
        }

    }
    public void tile1Click()
    {
        if (tile3_isCorrect && tile2_isCorrect)
        {
            tile1_right.SetActive(true);
            StartCoroutine(forward());
        }
        else
        {
            tile1_wrong.SetActive(true);

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
    public void tile0Click()
    {
        tile0_wrong.SetActive(true);

        if (MenuScript.levelNum == 1)
        {
            StartCoroutine(reset());
        }
        else
        {
            MenuScript.levelNum -= 1;
            StartCoroutine(wrong0());
            go();
        }
    }
    IEnumerator forward()
    {
        yield return new WaitForSeconds(1);

        tile1_isCorrect = true;

    }
    IEnumerator wrong0()
    {
        
        yield return new WaitForSeconds(1);
        tile0_isWrong = true;
        
    }
    IEnumerator wrong1()
    {

        yield return new WaitForSeconds(1);
        tile1_isWrong = true;

    }
    IEnumerator wrong3()
    {

        yield return new WaitForSeconds(1);
        tile3_isWrong = true;

    }



    IEnumerator show()
    {
        yield return new WaitForSeconds(1);
        tile2_right.SetActive(true);
        yield return new WaitForSeconds(1);
        tile3_right.SetActive(true);
        yield return new WaitForSeconds(1);
        tile1_right.SetActive(true);
        yield return new WaitForSeconds(1);

        tile1_right.SetActive(false);
        tile3_right.SetActive(false);
        tile2_right.SetActive(false);

        tile0.interactable = true;
        tile1.interactable = true;
        tile2.interactable = true;
        tile3.interactable = true;
    }
    IEnumerator reset()
    {
        yield return new WaitForSeconds(1);
        tile3_right.SetActive(false);
        tile2_right.SetActive(false);


        tile1_wrong.SetActive(false);
        tile0_wrong.SetActive(false);
        tile3_wrong.SetActive(false);



        tile2_isCorrect = false;
        tile1_isCorrect = false;
        tile3_isCorrect = false;

        tile0.interactable = false;
        tile1.interactable = false;
        tile2.interactable = false;
        tile3.interactable = false;

        showPathOnce = true;
    }
}

