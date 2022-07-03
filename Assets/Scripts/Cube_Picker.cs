using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Picker : MonoBehaviour
{

    GameObject mainCube;
    int h;

    void Start()
    {
       mainCube = GameObject.Find("Cube"); 
    }

    void Update()
    {
        mainCube.transform.position = new Vector3(transform.position.x, h+1, transform.position.z);
        this.transform.localPosition = new Vector3( 0, -h, 0);
    }

    public void decreaseH()
    {
        h--;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Add" && other.gameObject.GetComponent<PickerCubes>().GetPickObject() == false)
        {
            h += 1;
            other.gameObject.GetComponent<PickerCubes>().PickedObject();
            other.gameObject.GetComponent<PickerCubes>().SetIndex(h);
            other.gameObject.transform.parent = mainCube.transform;
        }
    }
}
