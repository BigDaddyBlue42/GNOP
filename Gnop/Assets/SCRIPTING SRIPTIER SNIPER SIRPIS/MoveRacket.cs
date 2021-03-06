using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRacket : MonoBehaviour
{
    public float speed = 30;
    public string axis = "Vertical";

    // Start is called before the first frame update
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            GetComponent<Computer>().enabled = false;
        }
        float v = Input.GetAxisRaw(axis);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed;
    }
}
