using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LevelTwoScript : MonoBehaviour
{
    public bool showPathOnce = true;
    public GameObject tile0_right;
    public GameObject tile1_right;
    public GameObject tile4_right;
    public GameObject tile7_right;
    public GameObject tile8_right;

    public GameObject tile1_wrong;
    public GameObject tile2_wrong;
    public GameObject tile3_wrong;
    public GameObject tile4_wrong;
    public GameObject tile5_wrong;
    public GameObject tile6_wrong;
    public GameObject tile7_wrong;
    public GameObject tile8_wrong;


    public bool tile0_isCorrect;
    public bool tile1_isCorrect;
    public bool tile4_isCorrect;
    public bool tile7_isCorrect;
    public bool tile8_isCorrect;

    public GameObject Text;





    // Update is called once per frame
    void Update()
    {
        if (showPathOnce)
        {
            
            
            StartCoroutine(show());
            
            showPathOnce = false;


        }

        if (tile0_isCorrect && tile1_isCorrect && tile4_isCorrect && tile7_isCorrect && tile8_isCorrect)
        {
            StartCoroutine(transition());
            

        }

        
        
    }

    //check the correct buttons
    public void tile0Click()
    {
        tile0_right.SetActive(true);
        tile0_isCorrect = true;
    }

    public void tile1Click()
    {
        if (tile0_isCorrect)
        {
            tile1_right.SetActive(true);
            tile1_isCorrect = true;
        }
        else
        {
            tile1_wrong.SetActive(true);

            StartCoroutine(goBack());
        }
    }

    public void tile2Click()
    {
        tile2_wrong.SetActive(true);
        StartCoroutine(goBack());
    }

    public void tile3Click()
    {
        tile3_wrong.SetActive(true);
        StartCoroutine(goBack());
    }

    public void tile4Click()
    {
        if (tile0_isCorrect && tile1_isCorrect)
        {
            tile4_right.SetActive(true);
            tile4_isCorrect = true;
        }
        else
        {
            tile4_wrong.SetActive(true);
            StartCoroutine(goBack());
        }
    }

    public void tile5Click()
    {
        tile5_wrong.SetActive(true);
        StartCoroutine(goBack());
    }

    public void tile6Click()
    {
        tile6_wrong.SetActive(true);
        StartCoroutine(goBack());
    }

    public void tile7Click()
    {
        if (tile0_isCorrect && tile1_isCorrect && tile4_isCorrect)
        {
            tile7_right.SetActive(true);
            tile7_isCorrect = true;
        }
        else
        {
            tile7_wrong.SetActive(true);
            StartCoroutine(goBack());
        }
    }

    public void tile8Click()
    {
        if (tile0_isCorrect && tile1_isCorrect && tile4_isCorrect && tile7_isCorrect)
        {
            tile8_right.SetActive(true);
            tile8_isCorrect = true;
        }
        else
        {
            tile8_wrong.SetActive(true);
            StartCoroutine(goBack());
        }
    }



    /*IEnumerator reset()
    {
        yield return new WaitForSeconds(1);
        tile0_right.SetActive(false);
        tile1_right.SetActive(false);
        tile4_right.SetActive(false);
        tile7_right.SetActive(false);
        tile8_right.SetActive(false);

        tile1_wrong.SetActive(false);
        tile2_wrong.SetActive(false);
        tile3_wrong.SetActive(false);
        tile4_wrong.SetActive(false);
        tile5_wrong.SetActive(false);
        tile6_wrong.SetActive(false);
        tile7_wrong.SetActive(false);
        tile8_wrong.SetActive(false);


        tile0_isCorrect = false;
        tile1_isCorrect = false;
        tile4_isCorrect = false;
        tile7_isCorrect = false;
        tile8_isCorrect = false;

        showPathOnce = true;
    } */


    IEnumerator show()
    {
        yield return new WaitForSeconds(1);
        tile0_right.SetActive(true);
        yield return new WaitForSeconds(1);
        tile1_right.SetActive(true);
        yield return new WaitForSeconds(1);
        tile4_right.SetActive(true);
        yield return new WaitForSeconds(1);
        tile7_right.SetActive(true);
        yield return new WaitForSeconds(1);
        tile8_right.SetActive(true);
        yield return new WaitForSeconds(1);
        tile0_right.SetActive(false);
        tile1_right.SetActive(false);
        tile4_right.SetActive(false);
        tile7_right.SetActive(false);
        tile8_right.SetActive(false);


    }
    IEnumerator transition()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Menu");
    }
    IEnumerator goBack()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("level1");
    }
}
