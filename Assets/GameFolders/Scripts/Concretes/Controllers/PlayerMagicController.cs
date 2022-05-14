using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Proje1.Movements.Enemy;
using Proje1.Pool;
using Proje1.Combats;
namespace Proje1.Controllers
{
    public class PlayerMagicController: MonoBehaviour
    {
        private MagicMover _mover;
        private float _maxLifeTime;
        private float _currentTime;

        static public event System.Action<Transform> OnFairyEnemyDead;
        private void Awake()
        {
            _mover = GetComponent<MagicMover>();
            _maxLifeTime = 20 / _mover.MoveSpeed;
            
        }

        private void OnTriggerEnter2D(Collider2D other) {
            if(other.tag == "Enemy"){
                FairyEnemyController enemy = other.GetComponent<FairyEnemyController>();
                DeadFairyEnemy DeadFairy = other.GetComponent<DeadFairyEnemy>();
                DeadFairy.LunchDead(other.gameObject.transform);
                FairyPool.Instance.Set(enemy);
                Destroy(this.gameObject);
                GameManager.Instance.IncreaseScore();
                
            }
        }
        private void DeadEnemy(){
            OnFairyEnemyDead?.Invoke(this.gameObject.transform);
        }
        private void Update()
        {
            _currentTime += Time.deltaTime;
            if (_currentTime > _maxLifeTime)
            {
                Destroy(this.gameObject);
            }
        }

    }
}

