using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetOutCome : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI FirstValue;
    [SerializeField] private TextMeshProUGUI OutComeOperator;
    [SerializeField] private TextMeshProUGUI SecondValue;
    [SerializeField] private TextMeshProUGUI Outcome;
    public void GetValue()
    {
        int Val1 =  int.Parse(FirstValue.text.ToString());
        int Val2 =  int.Parse(SecondValue.text.ToString());
        Debug.Log(Val1.ToString());
        Debug.Log(Val2.ToString());
        Debug.Log(OutComeOperator.text);
        switch(OutComeOperator.text)
        {
            case "+":
                int resultsadd = Val1 + Val2;
                Outcome.text = resultsadd.ToString();
                Debug.Log("1");
                break;

            case "-":
                int resultssub = Val1 - Val2;
                Outcome.text = resultssub.ToString();
                Debug.Log("2");
                break;

            case "X":
                int resultsmult = Val1 * Val2;
                Outcome.text = resultsmult.ToString();
                Debug.Log("3");
                break;

            case "/":
                float resultsdiv = (float)Val1 / (float)Val2;
                Outcome.text = resultsdiv.ToString();
                Debug.Log("4");
                break;
            default:
                break;
        }
    }
}
