using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comidadeanimalitos : MonoBehaviour
{
    public string CodigoDelAnimal;
    public float DiasAQuedarse;
    float MontoFinalGramos;
    float ComidaGato = 300f;
    float ComidaPerroPequeño = 400f;
    float ComidaPerroGrande = 700f;



    // Start is called before the first frame update
    void Start()
    {

        if (CodigoDelAnimal == "G" || CodigoDelAnimal == "PP" || CodigoDelAnimal == "PG")
        {
            switch (CodigoDelAnimal)
            {
                case ("G"):

                    MontoFinalGramos = ComidaGato * DiasAQuedarse;
                    Debug.Log("Para ese período se necesitan" + MontoFinalGramos + "gramos de alimento");
                    MontoFinalGramos = MontoFinalGramos * 100 / 80;
                    Debug.Log("Se necesitan " + MontoFinalGramos + "$");
                    break;

                case ("PP"):

                    MontoFinalGramos = ComidaPerroPequeño * DiasAQuedarse;
                    Debug.Log("Para ese período se necesitan" + MontoFinalGramos + "gramos de alimento");
                    MontoFinalGramos = MontoFinalGramos * 100 / 80;
                    Debug.Log("Se necesitan " + MontoFinalGramos + "$");
                    break;

                case ("PG"):

                    MontoFinalGramos = ComidaPerroGrande * DiasAQuedarse;
                    Debug.Log("Para ese período se necesitan" + MontoFinalGramos + "gramos de alimento");
                    MontoFinalGramos = MontoFinalGramos * 100 / 80;
                    Debug.Log("Se necesitan " + MontoFinalGramos + "$");
                    break;

            }
        }
        else if (DiasAQuedarse < 3)
        {
            Debug.Log("La cantidad minima de dias son 3");
            return;
        }

        else
        {
            Debug.Log("Codigo no valido");
            return;
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}