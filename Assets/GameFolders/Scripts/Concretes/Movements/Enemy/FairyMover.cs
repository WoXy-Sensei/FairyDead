using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Proje1.Movements.Enemy
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class FairyMover : MonoBehaviour
    {

        [SerializeField] internal float MoveSpeed;

        [Range(0,100)]
        [SerializeField] float _randomRotatePercent;
        Rigidbody2D _rigiBody2D;
        Transform _transform;
        public bool _rotateAroundSelf;


        private void Awake()
        {
            _rigiBody2D = GetComponent<Rigidbody2D>();
            _transform = GetComponent<Transform>();
        }
        private void OnEnable()
        {
            
            _rigiBody2D.SetRotation(0f);
            if (Random.value >= 1 - (_randomRotatePercent/100))
            {
                _rotateAroundSelf = true;
            }
            _rigiBody2D.velocity = Vector2.left * MoveSpeed;
        }

        private void OnDisable() {
            _rotateAroundSelf = false;
        }

        private void FixedUpdate() {
            if(_rotateAroundSelf){
                RotateAroundSelf(3f);
            }
            
        }
        private void RotateAroundSelf(float RotateValue)
        {
            _rigiBody2D.rotation += RotateValue;
        }


    }

}
