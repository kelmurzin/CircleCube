using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnergyText : MonoBehaviour
{
    private Text textEnergy;
    public int energyint;
    void Start()
    {
        textEnergy = GetComponent<Text>();        
        energyint = int.Parse(textEnergy.text);
        textEnergy.text = energyint.ToString();
    }

    public void UpdateEnergy()
    {
        energyint--;
        textEnergy.text = energyint.ToString();
    }
   

}
