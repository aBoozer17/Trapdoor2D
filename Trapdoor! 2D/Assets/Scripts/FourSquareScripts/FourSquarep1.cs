using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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



public bool tile0_isCorrect;
public bool tile1_isCorrect;
public bool tile2_isCorrect;



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
    tile2_right.SetActive(true);
    tile2_isCorrect = true;
}


public void tile0Click()
{
    if (tile2_isCorrect)
    {
        tile0_right.SetActive(true);
        tile0_isCorrect = true;
    }
    else
    {
        tile0_wrong.SetActive(true);

        if (MenuScript.levelNum == 1)
        {
            StartCoroutine(reset());
        }
        else
        {
            MenuScript.levelNum -= 1;
                go();
            }
    }

}
public void tile1Click()
{
    if (tile0_isCorrect && tile2_isCorrect)
    {
        tile1_right.SetActive(true);
        tile1_isCorrect = true;
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
            MenuScript.levelNum -= 1;
                go();
            }
    }
}
public void tile3Click()
{
    tile3_wrong.SetActive(true);

    if (MenuScript.levelNum == 1)
    {
        StartCoroutine(reset());
    }
    else
    {
        MenuScript.levelNum -= 1;
            go();
        }
}


IEnumerator show()
{
    yield return new WaitForSeconds(1);
    tile2_right.SetActive(true);
    yield return new WaitForSeconds(1);
    tile0_right.SetActive(true);
    yield return new WaitForSeconds(1);
    tile1_right.SetActive(true);
    yield return new WaitForSeconds(1);

    tile1_right.SetActive(false);
    tile0_right.SetActive(false);
    tile2_right.SetActive(false);
}
IEnumerator reset()
{
    yield return new WaitForSeconds(1);
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

