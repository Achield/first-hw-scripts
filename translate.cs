using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class translate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool good_at_scripting = false;
        print("Is good at scripting: " + good_at_scripting);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(1 * Time.deltaTime,0,0);
    }
}
