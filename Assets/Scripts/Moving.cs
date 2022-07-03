using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    [SerializeField] private float forwardSpeed;
    [SerializeField] private float rightLeftSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * rightLeftSpeed * Time.deltaTime;
        this.transform.Translate(horizontal, 0, forwardSpeed * Time.deltaTime);
    }
}
