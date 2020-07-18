﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level3 : MonoBehaviour
{
    public AudioClip audioClip;
    public AudioSource Audio;
    public GameObject Coin1;
    public GameObject Coin2;
    public GameObject Coin3;
    public GameObject Coin4;
    public GameObject Coin5;
    public GameObject Coin6;
    public GameObject Coin7;
    public GameObject Coin8;
    public GameObject Coin9;
    public GameObject Panel;
    public GameObject Panel1;


    public GameObject Cube;
    public string CollectionText = "Coins to be collected:";
    public string CollectedText = "Coins collected:";
    public Text CollectionText1;
    public Text CollectedText1;
    public Text CollectedText2;
    public Text Counter1;
    int score = 0;
    int i = 3;
    public int index;


    void PlaySound()
    {
        Audio.clip = audioClip;
        Audio.Play();
    }

    //Start is called before the first frame update
    void Start()
    {
        Panel1.SetActive(true);
        Invoke("Counter", 1f);
        Invoke("Counter", 2f);
        Invoke("Counter", 3f);
        Invoke("StartPanel", 4f);
        CollectionText1.text = CollectionText + " 9";
    }




    public void Back()
    {
        SceneManager.LoadScene(0);
    }
    public void NEXT()
    {
        SceneManager.LoadScene(index);

    }
    public void StartPanel()
    {
        Panel1.SetActive(false);
    }


    public void Counter()
    {
        Counter1.text = i.ToString();
        i--;
    }
    void OnTriggerEnter(Collider Coin)
    {

        switch (Coin.tag)
        {
            case "Coin1":
                score++;
                PlaySound();
                Coin1.SetActive(false);
                Debug.Log("coin1 taken");
                break;
            case "Coin2":
                score++;
                PlaySound();
                Coin2.SetActive(false);
                Debug.Log("coin2 taken");
                break;
            case "Coin3":
                score++;
                PlaySound();
                Coin3.SetActive(false);
                Debug.Log("coin3 taken");
                break;
            case "Coin4":
                score++;
                PlaySound();
                Coin4.SetActive(false);
                Debug.Log("coin4 taken");
                break;
            case "Coin5":
                score++;
                PlaySound();
                Coin5.SetActive(false);
                Debug.Log("coin5 taken");
                break;
            case "Coin6":
                score++;
                PlaySound();
                Coin6.SetActive(false);
                Debug.Log("coin6 taken");
                break;
            case "Coin7":
                score++;
                PlaySound();
                Coin7.SetActive(false);
                Debug.Log("coin7 taken");
                break;
            case "Coin8":
                score++;
                PlaySound();
                Coin7.SetActive(false);
                Debug.Log("coin8 taken");
                break;
            case "Coin9":
                score++;
                PlaySound();
                Coin9.SetActive(false);
                Debug.Log("coin9 taken");
                break;
            case "ExitCube":
                Panel.SetActive(true);
                Cursor.visible = true;
                Invoke("NEXT", 3f);
                break;

        }


    }
    
    // Update is called once per frame
    void Update()
    {
        CollectedText1.text = CollectedText + " " + score.ToString();
        CollectedText2.text = CollectedText + " " + score.ToString() + "/9";
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
}


