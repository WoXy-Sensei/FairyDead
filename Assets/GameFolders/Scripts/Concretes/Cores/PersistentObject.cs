using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Proje1.Cores
{
    public class PersistentObject : MonoBehaviour
    {
        [SerializeField] GameObject[] _persistentPrefab;
        static bool _isFirstTime =true;
        private void Start() {
            if(_isFirstTime){
                SpawnPersistentObjects();
                _isFirstTime= false;
            }
        }

        private void SpawnPersistentObjects(){
            foreach (var item in _persistentPrefab)
            {
                GameObject newObject = Instantiate(item);
                DontDestroyOnLoad(newObject);                
            }

        }

    }
}

