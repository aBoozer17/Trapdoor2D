using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLevel
{
    public static string[] lev1paths = new string[] { "l1p1", "l1p2", "l1p3", "l1p4", "l1p5", "l1p6", "l1p7", "l1p8" };
    public static string[] lev2paths = new string[] { "l2p1", "l2p2", "l2p3", "l2p4", "l2p5", "l2p6", "l2p7", "l2p8" };
    public static string[] lev3paths = new string[] { "l3p1", "l3p2", "l3p3", "l3p4", "l3p5", "l3p6", "l3p7", "l3p8" };
    public static string[] lev4paths = new string[] { "l4p1", "l4p2", "l4p3", "l4p4", "l4p5", "l4p6", "l4p7", "l4p8" };
    public int currentLevel;
    public System.Random random = new System.Random();


    public void setlevel(int num)
    {
        currentLevel = num;
    }

    public string changelevel()
    {
        
        string path = "";
        int i = random.Next(0, 8);
        if (currentLevel == 1)
        {
            path = lev1paths[i];
        }
        else if (currentLevel == 2)
        {
            path = lev2paths[i];
        }
        else if (currentLevel == 3)
        {
            path = lev3paths[i];
        }
        else if (currentLevel == 4)
        {
            path = lev4paths[i];
        }
        return path;

    }

}
