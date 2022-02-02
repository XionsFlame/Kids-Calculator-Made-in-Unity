using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField]
    private GameObject FirstValue;

    [SerializeField]
    private GameObject SecondValue;

    [SerializeField]
    public GameObject SelectedGameObject;

    [SerializeField]
    public GameObject results;

    [SerializeField]
    private Material HighLightedMaterial;

    [SerializeField]
    Material NormalMaterial;
    // Start is called before the first frame update
    void Start()
    {
        SelectedGameObject = FirstValue;
        FirstValue.GetComponent<Renderer>().material = HighLightedMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo = new RaycastHit();
            bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
            if (hit)
            {
                if (hitInfo.transform.gameObject.tag == "FirstValue")
                {
                    SelectedGameObject = FirstValue;

                }
                if (hitInfo.transform.gameObject.tag == "SecondValue")
                {
                    SelectedGameObject = SecondValue;
                }
                SetHighlightedMaterial();
            }
        }
    }

    public void SetHighlightedMaterial()
    {
        if(SelectedGameObject.tag == "FirstValue")
        {
            FirstValue.GetComponent<Renderer>().material = HighLightedMaterial;
            SecondValue.GetComponent<Renderer>().material = NormalMaterial;
        }
        else if(SelectedGameObject.tag == "SecondValue")
        {
            SecondValue.GetComponent<Renderer>().material = HighLightedMaterial;
            FirstValue.GetComponent<Renderer>().material = NormalMaterial;
        }
    }
}
