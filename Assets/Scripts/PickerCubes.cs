using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickerCubes : MonoBehaviour
{
    private bool cubeStatus;
    private int index;
    public Cube_Picker picker;

    void Start()
    {
        cubeStatus = false;
    }

    void Update()
    {
        if(cubeStatus == true)
        {
            if(transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Barrier")
        {
            picker.decreaseH();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }

    public bool GetPickObject()
    {
        return cubeStatus;
    }

    public void PickedObject()
    {
        cubeStatus = true;
    }

    public void SetIndex(int index)
    {
        this.index = index;
    }
}
