using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParOImpar : MonoBehaviour
{
    public int num1;

    // Start is called before the first frame update
    void Start()
    {
        if(num1 > 0)
        {
            if(num1 % 2 == 0)
            {
                Debug.Log("el número es par");
            }else
            {
                Debug.Log("el número es impar");
            }
        }
        else
        {
            Debug.Log("El número debe ser mayor que cero");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
