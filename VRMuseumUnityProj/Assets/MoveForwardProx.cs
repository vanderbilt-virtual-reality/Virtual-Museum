using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardProx : MonoBehaviour
{
    public GameObject museumObject;
    public GameObject displayObject;
    public float proxDistance;

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(this.transform.position, museumObject.transform.position) < proxDistance)
        {
            displayObject.transform.position = new Vector3(25, (float) 2.63, -2);
        }
        else if (Vector3.Distance(this.transform.position, museumObject.transform.position) > proxDistance)
        {
            displayObject.transform.position = new Vector3(27, (float)2.63, -2);
        }
    }
}
