using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public void Keluar(){
        Application.Quit();
        Debug.Log("Aplikasi Telah Keluar");
    }

    public void Mulai(){
        SceneManager.LoadScene("Mulai");
    }
}
