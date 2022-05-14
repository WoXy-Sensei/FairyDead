using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Proje1.Combats;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    private int score;
    public event System.Action<int> OnScoreChanged;
    public event System.Action OnSceneChanged;
    private void Awake()
    {

        SingletonThisGameObject();
    }

    private void SingletonThisGameObject()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void IncreaseScore(){
        score += 100;
        OnScoreChanged?.Invoke(score);
    }

    

    public void ExitGame(){
        Application.Quit();
    }
    public void StartGame()
    {
        score = 0;
        StartCoroutine(StartGameAsync());    }
    private IEnumerator StartGameAsync()
    {
        OnSceneChanged?.Invoke();
        Time.timeScale =1f;
        yield return SceneManager.LoadSceneAsync("Game");
        

    }

    public void ReturnMenu()
    {
        
        StartCoroutine(ReturnMenuAsync());
        
    }
    private IEnumerator ReturnMenuAsync()
    {
        OnSceneChanged?.Invoke();
        yield return SceneManager.LoadSceneAsync("MainMenu");
    }
}
