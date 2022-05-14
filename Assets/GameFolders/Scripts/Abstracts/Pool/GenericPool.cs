using System.Collections;
using System.Collections.Generic;
using UnityEngine;




namespace Proje1.Abstract.Pool
{
    public abstract class GenericPool<T> : MonoBehaviour where T : Component
    {   
        [SerializeField] T[] prefabs;
        [SerializeField] int countloop;
        Queue<T> _poolPrefebs = new Queue<T>();

        private void OnEnable() {
            GameManager.Instance.OnSceneChanged += ResetAllObjects;
        }
        private void OnDisable() {
            GameManager.Instance.OnSceneChanged -= ResetAllObjects;
        }

        private void Awake() {
            SingletonObject();
        }
        protected abstract void SingletonObject();
        public T Get(){
            if(_poolPrefebs.Count == 0){
                GrowPoolPrefab();
            }
            return _poolPrefebs.Dequeue();
        }
        private void ResetAllObjects(){
            foreach (T child in GetComponentsInChildren<T>())
            {
               if(!child.gameObject.activeSelf) continue;
               Set(child);
            }
        }
        private void GrowPoolPrefab()
        {
            for (int i = 0; i < countloop; i++)
            {
                T newPrefab = Instantiate(prefabs[Random.Range(0,prefabs.Length)]);
                newPrefab.transform.parent = this.transform;
                newPrefab.gameObject.SetActive(false);
                _poolPrefebs.Enqueue(newPrefab);
            }
        }
        public void Set(T poolObject){
            poolObject.gameObject.SetActive(false);
            _poolPrefebs.Enqueue(poolObject);
       }
    }
}
