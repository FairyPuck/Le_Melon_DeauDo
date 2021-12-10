using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Resources : MonoBehaviour
{
    public int melonJuice, metal, dodoDieCount;
    public TextMeshProUGUI juiceValue, metalValue;

    private void FixedUpdate()
    {
        juiceValue.text = melonJuice.ToString();
        metalValue.text = metal.ToString();

    }

    public void MakeTurret()
    {
        melonJuice -= 15;
        metal -= 15;
    }

    public void DodoDie()
    {
        metal += 5;
        if(dodoDieCount == 0)
        {
            dodoDieCount = 5;
            melonJuice += 30;
        }
        else dodoDieCount--;
    }
}
