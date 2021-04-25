using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLevel
{


    public int currentLevel;
    


    public void setlevel(int num)
    {
        currentLevel = num;
    }

    public string changelevel()
    {
        System.Random random = new System.Random();
        string path = "";
        int i = random.Next(0, 8);

        switch(currentLevel)
        {
            case 1:
                string[] lev1paths = new string[] { "l1p1", "l1p2", "l1p3", "l1p4", "l1p5", "l1p6", "l1p7", "l1p8" };
                path = lev1paths[i];
                break;
            case 2:
                string[] lev2paths = new string[] { "l2p1", "l2p2", "l2p3", "l2p4", "l2p5", "l2p6", "l2p7", "l2p8" };
                path = lev2paths[i];
                break;
            case 3:
                string[] lev3paths = new string[] { "l3p1", "l3p2", "l3p3", "l3p4", "l3p5", "l3p6", "l3p7", "l3p8" };
                path = lev3paths[i];
                break;
            case 4:
                string[] lev4paths = new string[] { "l4p1", "l4p2", "l4p3", "l4p4", "l4p5", "l4p6", "l4p7", "l4p8" };
                path = lev4paths[i];
                break;
            case 5:
                string[] lev5paths = new string[] { "l5p1", "l5p2", "l5p3", "l5p4", "l5p5", "l5p6", "l5p7", "l5p8" };
                path = lev5paths[i];
                break;
            case 6:
                string[] lev6paths = new string[] { "l6p1", "l6p2", "l6p3", "l6p4", "l6p5", "l6p6", "l6p7", "l6p8" };
                path = lev6paths[i];
                break;
            case 7:
                string[] lev7paths = new string[] { "l7p1", "l7p2", "l7p3", "l7p4", "l7p5", "l7p6", "l7p7", "l7p8" };
                path = lev7paths[i];
                break;
            case 8:
                string[] lev8paths = new string[] { "l8p1", "l8p2", "l8p3", "l8p4", "l8p5", "l8p6", "l8p7", "l8p8" };
                path = lev8paths[i];
                break;
            case 9:
                string[] lev9paths = new string[] { "l9p1", "l9p2", "l9p3", "l9p4", "l9p5", "l9p6", "l9p7", "l9p8" };
                path = lev9paths[i];
                break;
            case 10:
                string[] lev10paths = new string[] { "l10p1", "l10p2", "l10p3", "l10p4", "l10p5", "l10p6", "l10p7", "l10p8" };
                path = lev10paths[i];
                break;
            case 11:
                string[] lev11paths = new string[] { "l11p1", "l11p2", "l11p3", "l11p4", "l11p5", "l11p6", "l11p7", "l11p8" };
                path = lev11paths[i];
                break;
            case 12:
                string[] lev12paths = new string[] { "l12p1", "l12p2", "l12p3", "l12p4", "l12p5", "l12p6", "l12p7", "l12p8" };
                path = lev12paths[i];
                break;

        }


        
        return path;

    }

}
