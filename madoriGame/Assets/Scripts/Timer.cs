using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI text;
    [SerializeField]
    UnityEvent time30;

    int time = 0;
    // Start is called before the first frame update
    void Start()
    {
        text.text = time.ToString();
        StartCoroutine(OneTimer());

    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator OneTimer()
    {
        yield return new WaitForSeconds(1);
        StartCoroutine(OneTimer());
        time += 1;
        text.text = time.ToString();
        if(time == 30)
        {
            time30.Invoke();
        }

    }
}
