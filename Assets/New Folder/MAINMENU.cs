using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MAINMENU : MonoBehaviour
{
    public AudioMixer audioMixer;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None; 

    }
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
    Application.Quit();
        }

    public void SetVolume(float Volume)
    {
        Debug.Log(Volume);
        audioMixer.SetFloat("Volume", Volume);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
