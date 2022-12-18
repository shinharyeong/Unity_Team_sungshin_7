using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change_Ground : MonoBehaviour
{
    void Start() { }
    public void SceneChange()
    {
        SceneManager.LoadScene("Ground");
    }

}
