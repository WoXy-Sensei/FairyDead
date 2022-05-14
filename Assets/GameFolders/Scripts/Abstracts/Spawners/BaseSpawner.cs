using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Proje1.Abstract.Spawners
{
    public abstract class BaseSpawner : MonoBehaviour
    {
        [Range(1, 10)]
        [SerializeField] float _minSpawnTime;
        [Range(1, 10)]
        [SerializeField] float _maxSpawnTime;


        float _timeBoundary;
        float _currentTime;

        private void Awake()
        {
            RestartTimes();
        }
        private void Update()
        {
            _currentTime += Time.deltaTime;
            if (_currentTime > _timeBoundary)
            {
                Spawn();
                RestartTimes();
            }
        }
        protected abstract void Spawn();

        private void RestartTimes()
        {
            _currentTime = 0f;
            _timeBoundary = Random.Range(_minSpawnTime, _maxSpawnTime);
        }
    }
}
    

