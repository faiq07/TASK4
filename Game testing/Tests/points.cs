using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class points
{
    public int pointsCal(int fireEncounter)
    {

        if(fireEncounter==3){
            return 0;
        }if(fireEncounter==2){
            return 10;
        }if(fireEncounter==1){
            return 20;
        }
        return 30;

    }
}
