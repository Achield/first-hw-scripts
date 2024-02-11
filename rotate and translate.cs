using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateandtranslate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string name = "Aidan M";
        string introduction = "Hello, my name is ";
        print(introduction + name + ".");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 10 * Time.deltaTime, -10 * Time.deltaTime);
        transform.Rotate(-2 , 0, 0);
    }
}
