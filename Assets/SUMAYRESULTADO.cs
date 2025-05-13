using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SUMAYRESULTADO : MonoBehaviour
{
    public TMP_InputField InputNum1;
    public TMP_InputField InputNum2;
    public TextMeshProUGUI txtResultado;
    int Num1;
    int Num2;
    // Start is called before the first frame update
    void Start()
    {
        txtResultado.text = "";
    }
    public void SumarYMostrar()
    {
        Num1 = int.Parse(InputNum1.text);
        Num2 = int.Parse(InputNum2.text);
        txtResultado.text = (Num1 + Num2).ToString();
    }
   
}
