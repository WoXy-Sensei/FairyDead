using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Proje1.Movements.Enemy
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class TreeMover : MonoBehaviour
    {

        [SerializeField] internal float MoveSpeed;
        Rigidbody2D _rigiBody2D;
        [Range(0, 100)]
        [SerializeField] float _randomThrowPercent;
        [Range(0, 10)]
        [SerializeField] float _minHeight;
        [Range(0, 10)]
        [SerializeField] float _maxHeight;
        bool _throwTree;
        float _randomThrowTime;
        float currentTime;
        private void Awake()
        {
            _rigiBody2D = GetComponent<Rigidbody2D>();
        }
        private void OnEnable()
        {   _randomThrowTime = Random.Range(0.5f,1.3f);
            float randomHeight = Random.Range(_minHeight+10f,_maxHeight+10f);
            float randomWidth = Random.Range(10,15);
            if (Random.value >= 1 - (_randomThrowPercent / 100))
            {
                _throwTree = true;
            }
            this.transform.localScale = new Vector3(randomWidth,randomHeight,0f);
            this.transform.rotation = Quaternion.identity;
            _rigiBody2D.velocity = Vector2.left * MoveSpeed;
        }
        private void OnDisable() {
            _throwTree = false;
            _rigiBody2D.gravityScale = 0f;
        }
        private void FixedUpdate()
        {
            if (_throwTree)
            {
                currentTime += Time.deltaTime;
                if (currentTime > _randomThrowTime)
                {
                    currentTime = 0f;
                    trhowTree();
                    _throwTree = false;
                }
            }

        }

        private void trhowTree()
        {
            this.transform.Rotate(0f,0f,45f);
            _rigiBody2D.gravityScale = 1f;
            _rigiBody2D.AddForce(Vector2.up * 600f);
        }
    }

}
