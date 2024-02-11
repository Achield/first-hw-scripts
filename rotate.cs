using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int num5 = 5;
        Debug.Log("This is a number:" + " " + num5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(1,0,0);
    }
}
