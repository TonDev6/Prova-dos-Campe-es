using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atributtes : MonoBehaviour
{

    [SerializeField] private GameObject powerText;
    [SerializeField] private GameObject powerIniText;
    [SerializeField] private GameObject energyText;
    [SerializeField] private GameObject energyIniText;
    [SerializeField] private GameObject luckText;
    [SerializeField] private GameObject luckIniText;

    [SerializeField] private GameObject characterName;

    [SerializeField] private GameObject weaponName;



    public int power;
    public int powerI;

    public int energy;
    public int energyI;

    public int luck;
    public int luckI;

    private void Update() {
        if (power > powerI)
        {
            power = powerI;
        }

        if (energy > energyI)
        {
            energy = energyI;
        }

        if (luck > luckI)
        {
            luck = luckI;
        }



    }


    
}