using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(0f, 1f, 0f);
        }else if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(0f, -1f, 0f);
        }else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(-1f,0f, 0f);
        }else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(1f,0f, 0f);
        }
    }
}
