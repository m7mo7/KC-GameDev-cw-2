using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cc : MonoBehaviour
{
    // Start is called before the first frame update\

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



    //bonus

    bool TruevillainSuperPower = false;

    void Start()
    {


        print(" my hero is " + heroName + " the hero's height is " + heroHeight + " the hero's age is " + heroAge + " and my hero's super power is " + heroSuperPower);
        print(" my villain is " + villainName + " the villain height is " + vililanHeight + " the villain's age is " + villainAge + " and my villain's super power is " + villainSuperPower);


        print(" my hero is " + heroName + " the hero's age is " + heroAge + " and my hero's super power is " + heroSuperPower);
        print(" my villain is " + villainName + " the villain height is " + vililanHeight + " the villain's age is " + villainAge + " and my villain's super power is " + TruevillainSuperPower);
        print("agedeffrence is" + (heroAge - villainAge ));
        print("heroHeight is" + (heroHeight + 5));
             
        }
    // Update is called once per frame
    void Update()
    {

    }
}