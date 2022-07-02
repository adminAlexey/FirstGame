using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int healthPlayer;
    public int point;

    public GameObject panelWin;
    public GameObject panelLoose;
    public Text timerText;
    public Text scoreText;
    public Text livesText;

    void Start()
    {
        panelWin.SetActive(false);
        panelLoose.SetActive(false);
        healthPlayer = 5;
        point = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (healthPlayer < 1)
        {
            panelLoose.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {

            healthPlayer--;
            livesText.text = healthPlayer.ToString();
            Debug.Log("Здоровье"+ healthPlayer);
        }
        if (other.tag == "Coin")
        {
            point+=100;
            scoreText.text = point.ToString();
            Debug.Log("Очки" + point);
        }
        if (other.tag == "Start")
        {
            StartCoroutine("Time");
        }
        if (other.tag == "Finish")
        {
            StopCoroutine("Time");
            panelWin.SetActive(true);
        }
        if (other.tag == "Respawn")
        {
            healthPlayer++;
            livesText.text = healthPlayer.ToString();
        }
    }
    IEnumerator Time()
    {
        for (int i = 60; i >= 0; i--)
        {
            timerText.text = i.ToString();
            yield return new WaitForSeconds(1f);
        }
        panelLoose.SetActive(true);
    }
}
