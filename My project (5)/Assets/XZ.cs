 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XZ : MonoBehaviour
{   
    // Define Hero's name and age
    string name = "nmood";
    int age = 54;
    bool isHero = false;
    float speed = 22.3f;
    int speedBoost = 10;
    // run the code to see the output

    void Start()
    {

     float runSpeed = speed * 2;
     // printing a short story rtory relating to the hero
     print(" The dude 's name is " + name + "and his age is " + age);
     print(" The prophecy says that  is a " + isHero + " hero, with a speed of " +  speed + "KM/h");
     print("He recieved a speed boost of " + (speed+speedBoost));
     print("He has a running speed of " + runSpeed);
    }
}
