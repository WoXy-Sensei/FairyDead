using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Proje1.Movements.Player;
using TMPro;

namespace Proje1.Combats
{
    public class Dead : MonoBehaviour
    {
        [SerializeField] bool _isDead;
    
        public bool IsDead => _isDead;
        Dash _dash;
        public event System.Action OnDead;

        private void Awake()
        {
            _dash = GetComponent<Dash>();
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "EnemyTree")
            {
                if (_dash._isDashing == false)
                {
                    DeadAction();
                }
            }

        }
        private void GameRestart()
        {
            GameManager.Instance.StartGame();
        }
        private void DeadAction()
        {
            _isDead = true;
            OnDead?.Invoke();
            Time.timeScale = 2f;

        }
        
    }

}
