using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


namespace Proje1.UIs
{
    public class DisplayScore : MonoBehaviour
    {
        private TextMeshProUGUI _scoreText;
        private int _socreUp;
        private void Awake()
        {
            _scoreText = GetComponent<TextMeshProUGUI>();
        }

        private void Start()
        {
            GameManager.Instance.OnScoreChanged += HandleScoreChanged;
        }
        private void OnDisable()
        {
            GameManager.Instance.OnScoreChanged -= HandleScoreChanged;
        }
        private void HandleScoreChanged(int Score = 0)
        {
            _scoreText.text = $"SCORE : {Score}";

        }
       

    }
}

