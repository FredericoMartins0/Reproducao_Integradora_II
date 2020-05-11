using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public bool press = false;

    static float timer = 0.0f;
    public Text text_box;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        var min = Mathf.Floor(timer / 60);
        var sec = timer % 60;
        text_box.text = string.Format("{0:00} : {1:00}", min, sec);
    }
}
