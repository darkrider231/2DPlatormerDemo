using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerCountDown : MonoBehaviour
{

    float currentTime = 0f;
    float startingTime = 500f;

    [SerializeField] Text timer;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;    
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        timer.text = "Timer: " + "\n" + currentTime.ToString("0");
    }
}
