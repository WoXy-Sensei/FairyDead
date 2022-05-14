using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Proje1.Movements.Enemy;
using Proje1.Pool;
using Proje1.Combats;
namespace Proje1.Controllers
{
    public class EnemyMagicController: MonoBehaviour
    {
        private EnemyMagicMover _mover;
        private float _maxLifeTime;
        private float _currentTime;

        private void Awake()
        {
            _mover = GetComponent<EnemyMagicMover>();
            _maxLifeTime = 20 / _mover.MoveSpeed;
            
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