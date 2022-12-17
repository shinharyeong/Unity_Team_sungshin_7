using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree : MonoBehaviour
{
    Animator Anim;
    public bool isPause;
    void Start()
    {
        string info = "[SPACEBAR] = play, stop";
        print(info);
        isPause = false;
        Anim = GetComponent<Animator>();
        Anim.speed = 1;
    }

    void Update()
    {
        /*****************************************************************
         * Unity KeyCode
         * https://docs.unity3d.com/kr/2020.3/ScriptReference/KeyCode.html
         *****************************************************************/
        if (Input.GetKeyDown(KeyCode.Space))
            if (!isPause)
            {
                isPause = true;
                Time.timeScale = 0;
            }
            else
            {
                isPause = false;
                Time.timeScale = 1;
            }
    }
}