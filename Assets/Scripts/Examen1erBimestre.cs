using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Examen1erBimestre : MonoBehaviour
{
    public float MontoAConvertir;
    public string DivisaALaQueConvetir;
    float MontoFinal;
    float montoMinimoAConvertir = 1000;
    float CotizacionDolar = 1300f;
    float CotizacionEuro = 1500f;
    float CotizacionReal = 200f;



    // Start is called before the first frame update
    void Start()
    {

        if (DivisaALaQueConvetir == "D" && MontoAConvertir > montoMinimoAConvertir || DivisaALaQueConvetir == "R" && MontoAConvertir > montoMinimoAConvertir || DivisaALaQueConvetir == "E" && MontoAConvertir > montoMinimoAConvertir)
        {
            switch(DivisaALaQueConvetir)
            {
                case("D"):
                    
                    MontoFinal = MontoAConvertir / CotizacionDolar;
                    Debug.Log("La conversion de " + MontoAConvertir + " a  Dolar es " + MontoFinal + " Dolares");
                    break;

                case ("R"):
                   
                    MontoFinal = MontoAConvertir / CotizacionReal;
                    Debug.Log("La conversion de " + MontoAConvertir + " a Real es" + MontoFinal + " Reales");
                    break;

                case ("E"):
                    
                    MontoFinal = MontoAConvertir / CotizacionEuro;
                    Debug.Log("La conversion de " + MontoAConvertir + " a  Euro es" + MontoFinal + " Euros");
                    break;

            }
        }
        else if (MontoAConvertir < montoMinimoAConvertir)
        {
            Debug.Log("El monto mínimo es $1000");
            return;
        }
              
        else
        {
            Debug.Log("Opción de moneda extranjera no válida");
            return;
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
