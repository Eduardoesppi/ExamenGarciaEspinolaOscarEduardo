using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suma : MonoBehaviour
{
    [SerializeField]
    private UnityEngine.UI.Text componenteTexto = null;
    private string dato1;


    public void ingresardato1 (string s)
    {

        dato1 = s;
        Debug.Log("dato1 asignado");

    }

    
    public void  AlgoritmoEjercicio ()
    {

        int n = int.Parse(dato1);

        int suma = 0;

        for(int i = 1; i <= n; i++)
        {


            suma = suma + i;





        }


        string resultado = "resultado de la suma es " + suma.ToString();

        componenteTexto.text = resultado;

        Debug.Log("resultado correcto");


    }
}
