using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class points1
{
    public int pointsCal1(int fireEncounter)
    {

        if(fireEncounter==3){
            return 30;
        }if(fireEncounter==2){
            return 20;
        }if(fireEncounter==1){
            return 10;
        }
        return 0;

    }
}
