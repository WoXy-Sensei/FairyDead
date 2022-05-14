using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Proje1.Effects
{
    public class ParticleEffect : MonoBehaviour
    {
        float _currentTime;
        [SerializeField] float maxLifeTime = 3f;
      
        // Update is called once per frame

        void Update()
        {
            _currentTime += Time.deltaTime;
            if(_currentTime > maxLifeTime){
                Destroy(this);
            }
        }
    }    
}

