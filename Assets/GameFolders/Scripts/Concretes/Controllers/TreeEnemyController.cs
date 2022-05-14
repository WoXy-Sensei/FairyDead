using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Proje1.Movements.Enemy;
using Proje1.Pool;
namespace Proje1.Controllers
{
    public class TreeEnemyController : MonoBehaviour
    {
        private TreeMover _mover;
        private float _maxLifeTime;
        private float _currentTime;
        private void Awake()
        {
            _mover = GetComponent<TreeMover>();
            _maxLifeTime = 20 / _mover.MoveSpeed;
        }
        private void OnEnable() {
            _currentTime = 0f;
        }
        private void Update()
        {
            _currentTime += Time.deltaTime;
            if (_currentTime > _maxLifeTime)
            {
                _currentTime = 0f;
                TreePool.Instance.Set(this);
            }
        }

    }
}

