using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject Piedra;
    public GameObject Papel;
    public GameObject Tijera;

     public void BtnProbabilidad() {

        float Number = Random.Range(1, 100);

        if (Number >= 1 && Number <= 33)
        {
            Piedra.SetActive(true);
            Papel.SetActive(false);
            Tijera.SetActive(false);
        }

        else if (Number >= 34 && Number <= 66)
        {
            Piedra.SetActive(false);
            Papel.SetActive(true);
            Tijera.SetActive(false);
        }
        else if (Number >= 67 && Number <= 100)
        {
            Piedra.SetActive(false);
            Papel.SetActive(false);
            Tijera.SetActive(true);
        }
    }

   
}
