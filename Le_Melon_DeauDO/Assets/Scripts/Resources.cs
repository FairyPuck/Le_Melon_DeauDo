using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Resources : MonoBehaviour
{
    public int melonJuice = 75, metal = 50, dodoDieCount = 20;
    public TextMeshProUGUI juiceValue, metalValue;

    private void FixedUpdate()
    {
        juiceValue.text = melonJuice.ToString();
        metalValue.text = metal.ToString();

    }

    public void MakeTurret()
    {
        melonJuice -= 50;
        metal -= 50;
    }

    public void DodoDie()
    {
        metal += 5;
        if(dodoDieCount == 0)
        {
            dodoDieCount = 20;
            melonJuice += 50;
        }
        else dodoDieCount--;
    }
}
