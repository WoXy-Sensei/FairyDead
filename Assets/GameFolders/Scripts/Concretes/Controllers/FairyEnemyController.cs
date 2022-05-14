using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Proje1.Movements.Enemy;
using Proje1.Pool;
using Proje1.Effects;
using Proje1.Combats;
namespace Proje1.Controllers

{
    public class FairyEnemyController : MonoBehaviour
    {
        private FairyMover _mover;
        private LunchEnemyMagic _lunchEnemyMagic;
        private float _maxLifeTime;
        private float _currentTime;
        bool _fireMagicEnemy;
        [Range(0, 100)]
        [SerializeField] float _randomLunchMagic;
        private void Awake()
        {
            _mover = GetComponent<FairyMover>();
            _lunchEnemyMagic = GetComponent<LunchEnemyMagic>();
        }
        private void OnEnable()
        {
            if (Random.value >= 1 - (_randomLunchMagic / 100) && _mover._rotateAroundSelf == false)
            {
                _fireMagicEnemy = true; 
                _mover.MoveSpeed = 5;
            }
            _maxLifeTime = 20 / _mover.MoveSpeed;
            _currentTime = 0f;
        }
        private void OnDisable() {
            _fireMagicEnemy = false; 
        }
        private void Update()
        {
            _currentTime += Time.deltaTime;
            if (_currentTime > _maxLifeTime)
            {
                _currentTime = 0f;
                FairyPool.Instance.Set(this);
            }
        }
        private void FixedUpdate() {
            if(_fireMagicEnemy){
                _lunchEnemyMagic.LunchAction();
                _fireMagicEnemy = false;
            }
        }

    }
}