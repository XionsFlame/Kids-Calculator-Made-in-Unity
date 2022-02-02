using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberButtons : MonoBehaviour
{
    public Manager manager;
    // Start is called before the first frame update
    void Start()
    {
        manager = GetComponent<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void One()
    {
        
        TextMeshProUGUI TMOperator = manager.SelectedGameObject.GetComponentInChildren<TextMeshProUGUI>();
        Debug.Log(TMOperator);
        if (TMOperator != null)
        {
            string text = TMOperator.text;
            TMOperator.SetText(text + "1");
        }
        
    }
    public void Two()
    {
        TextMeshProUGUI TMOperator = manager.SelectedGameObject.GetComponentInChildren<TextMeshProUGUI>();
        if (TMOperator != null)
        {

            string text = TMOperator.text;
            TMOperator.SetText(text + "2");
        }
    }
    public void Three()
    {
        TextMeshProUGUI TMOperator = manager.SelectedGameObject.GetComponentInChildren<TextMeshProUGUI>();
        if (TMOperator != null)
        {
            string text = TMOperator.text;
            TMOperator.SetText(text + "3");
        }
    }
    public void Four()
    {
        TextMeshProUGUI TMOperator = manager.SelectedGameObject.GetComponentInChildren<TextMeshProUGUI>();
        if (TMOperator != null)
        {
            string text = TMOperator.text;
            TMOperator.SetText(text + "4");
        }
    }
    public void Five()
    {
        TextMeshProUGUI TMOperator = manager.SelectedGameObject.GetComponentInChildren<TextMeshProUGUI>();
        if (TMOperator != null)
        {
            string text = TMOperator.text;
            TMOperator.SetText(text + "5");
        }
    }
    public void Six()
    {
        TextMeshProUGUI TMOperator = manager.SelectedGameObject.GetComponentInChildren<TextMeshProUGUI>();
        if (TMOperator != null)
        {
            string text = TMOperator.text;
            TMOperator.SetText(text + "6");
        }
    }
    public void Seven()
    {
        TextMeshProUGUI TMOperator = manager.SelectedGameObject.GetComponentInChildren<TextMeshProUGUI>();
        if (TMOperator != null)
        {
            string text = TMOperator.text;
            TMOperator.SetText(text + "7");
        }
    }
    public void Eight()
    {
        TextMeshProUGUI TMOperator = manager.SelectedGameObject.GetComponentInChildren<TextMeshProUGUI>();
        if (TMOperator != null)
        {
            string text = TMOperator.text;
            TMOperator.SetText(text + "8");
        }
    }
    public void Nine()
    {
        TextMeshProUGUI TMOperator = manager.SelectedGameObject.GetComponentInChildren<TextMeshProUGUI>();
        if (TMOperator != null)
        {
            string text = TMOperator.text;
            TMOperator.SetText(text + "9");
        }
    }

    public void ClearButton()
    {
        TextMeshProUGUI TMOperator = manager.SelectedGameObject.GetComponentInChildren<TextMeshProUGUI>();
        if (TMOperator != null)
        {
            TMOperator.text = "";
        }
        manager.results.GetComponentInChildren<TextMeshProUGUI>().text = "";
    }

}
