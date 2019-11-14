using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayExhibitInfo : MonoBehaviour
{
    public GameObject museumObject;
    public string displayText;
    public Camera uiCamera;
    public float proxDistance;

    private GameObject canvasHolder;

    void Start()
    {
        canvasHolder = new GameObject();
        canvasHolder.name = "ProximityCanvas";
        canvasHolder.AddComponent<Canvas>();
        Canvas myCanvas = canvasHolder.GetComponent<Canvas>();
        myCanvas.renderMode = RenderMode.ScreenSpaceCamera;
        myCanvas.worldCamera = uiCamera;
        canvasHolder.AddComponent<Text>();
        Text textComponent = canvasHolder.GetComponent<Text>();
        textComponent.text = "";
    }


    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(this.transform.position, museumObject.transform.position) < proxDistance)
        {
            canvasHolder.GetComponent<Text>().text = displayText;
        }
        else
        {
            canvasHolder.GetComponent<Text>().text = "";
        }
    }
}
