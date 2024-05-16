
using System.Diagnostics;
using UnityEngine;

public class PlayerStats
{
    // How fast is the Wizard
    public float movement = 1.5f;

    // How much Health does the Wizard 
    public int health = 100;

    // What Level is the Wizard
    public int level = 1;

    // How fast can the Wizard fire
    public float fireRate = 0.7f;

    // How long does it take for the Wizard to fire
    public float canFire = -1f;

    public int xp = 0;

    public float mana = 50f;

    public float manaReg = 5f;

    public void LevelUp()
    {
        canFire = canFire - 0.1f;
        health += 5;
        mana += 10;
        fireRate += 0.01f;
        level += 1;
    }

    public void GainXp(int newxp)
    {
        xp += newxp;
        //Debug.Log(xp);

        //Level Up
        if(xp >= level * 3)
        {
            xp -= level * 3;
            LevelUp();
        }
    }
}
