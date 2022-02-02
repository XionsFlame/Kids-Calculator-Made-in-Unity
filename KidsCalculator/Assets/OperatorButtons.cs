using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OperatorButtons : MonoBehaviour
{

    [SerializeField]
    private TextMeshProUGUI TMOperator;
    public void AddOperator()
    {
        TMOperator.text = "+";      
    }

    public void SubtractionOperator()
    {
        TMOperator.text = "-";
    }

    public void MultipleOperator()
    {
        TMOperator.text = "X";
    }

    public void DivideOperator()
    {
        TMOperator.text = "/";
    }
}
