using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayExhibitInfo : MonoBehaviour
{
    public GameObject museumObject;
    public string displayText;
    public float proxDistance;
    public GameObject display;

    private bool textSet = false;

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(this.transform.position, museumObject.transform.position) < proxDistance && !textSet)
        {
            display.GetComponent<Text>().text = displayText;
            textSet = true;
        }
        else if (Vector3.Distance(this.transform.position, museumObject.transform.position) > proxDistance)
        {
            Text textComponent = display.GetComponent<Text>();
            textComponent.text = "";
            textSet = false;
        }
    }
}
