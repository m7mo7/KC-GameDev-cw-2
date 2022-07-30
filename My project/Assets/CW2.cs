using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CW2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //hero

        string heroName = "SpiderMan";
        int heroHeight = 169;
        int heroAge = 18;
        string heroSuperPower = "strings..";
        
        //villain

        string villainName = "Venom";
        int vililanHeight = 229;
        int villainAge = 13;
        string villainSuperPower = "strong body..";
        //Difference
        int ageDifference = heroAge - villainAge;
                    
                print(" my hero is " + heroName + " the hero's height is " + heroHeight + " the hero's age is " + heroAge + " and my hero's super power is " + heroSuperPower);
        print(" my villain is " + villainName + " the villain height is " + vililanHeight + " the villain's age is " + villainAge + " and my villain's super power is " + villainSuperPower);

       
        //bonus
        int Trueheroheight = heroHeight + 5;
        string TruevillainSuperPower = "none";

        print(" my hero is " + heroName + " the hero's height is " + Trueheroheight + " the hero's age is " + heroAge + " and my hero's super power is " + heroSuperPower);
        print(" my villain is " + villainName + " the villain height is " + vililanHeight + " the villain's age is " + villainAge + " and my villain's super power is " + TruevillainSuperPower);

    }
    // Update is called once per frame
    void Update()
    {

    }
}



//استوعبت ليش مو قادر اسوي برنت متاخر وعدلتهاا :))