using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Text ScoreText;

    public Slider HealthBar;

    public Image DeathScreen;

    private int TotalScore;

    private int Health = 100;

    public static GameManager ManagerInstance;

    public GameObject Player;

    public void Awake()
    {
        ManagerInstance = this;
    }

    public void DamagePlayer(int Count)
    {
        if (Health > 0)
        {
            Health -= Count;
            HealthBar.value = Health;
            Debug.Log("Вам нанесено урона в размере " + Count);
        }
        else if (Health <= 0) Death();
    }

    private void Death()
    {
        DeathScreen.gameObject.SetActive(true);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void AddScore(int Count)
    {
        TotalScore += Count;
        ScoreText.text = "Score: " + TotalScore;
        Debug.Log("Итоговый счет: " + TotalScore);
    }
}
