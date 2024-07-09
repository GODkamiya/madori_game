using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject target;
    [SerializeField]
    UnityEvent onPushLeft;
    [SerializeField]
    UnityEvent onPushRight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            onPushLeft.Invoke();
        } else if (Input.GetKey(KeyCode.D))
        {
            onPushRight.Invoke();

        }
    }
}
