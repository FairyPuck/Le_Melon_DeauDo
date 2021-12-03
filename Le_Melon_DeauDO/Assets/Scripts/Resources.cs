using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Resources : MonoBehaviour
{
    public int melonJuice = 75, metal = 50;
    public TextMeshProUGUI juiceValue, metalValue;

    private void FixedUpdate()
    {
        juiceValue.text = melonJuice.ToString();
        metalValue.text = metal.ToString();

    }
}
