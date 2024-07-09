using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    float speed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MoveRight()
    {
        transform.position += new Vector3(speed, 0, 0);

    }
    public void MoveLeft()
    {
        transform.position += new Vector3(-speed, 0, 0);

    }
}
