using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Proje1.Combats;
using TMPro;
namespace Proje1.UIs
{
    public class DisplayTime : MonoBehaviour
    {
        TextMeshProUGUI _timeText;
        private float currentTime;
        private bool notDead = true;
        private void Awake() {
            _timeText = GetComponent<TextMeshProUGUI>();
            
        }
        private void Start() {
            Dead dead = FindObjectOfType<Dead>();
            dead.OnDead += timerHandle;
        }
        private void FixedUpdate() {
            if(notDead){
                currentTime += Time.deltaTime;
                _timeText.text = $"Time : {currentTime}";
            }

        }
        private void timerHandle(){
            notDead = false;
            _timeText.color = new Color(255, 0, 0);
        }
    }

}
