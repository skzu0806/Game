using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour{
    private float mana = 100;

    public void Skill(float mana) {
        this.mana -= mana;

        Debug.Log("Skill");
        Debug.Log("Current Mana : " + this.mana);
    }

}
