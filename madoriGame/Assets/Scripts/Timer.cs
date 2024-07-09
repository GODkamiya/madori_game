using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    TextMeshProUGUI text;
    [SerializeField]
    UnityEvent time30;

    int time = 0;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        ChangeText();
        StartCoroutine(OneTimer());

    }

    IEnumerator OneTimer()
    {
        yield return new WaitForSeconds(1);
        StartCoroutine(OneTimer());
        time += 1;
        ChangeText();
        if (time == 30)
        {
            time30.Invoke();
        }

    }
    void ChangeText()
    {
        text.text = time.ToString();
    }
}
