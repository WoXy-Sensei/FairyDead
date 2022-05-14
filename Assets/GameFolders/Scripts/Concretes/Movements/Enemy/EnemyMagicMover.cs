using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Proje1.Movements.Enemy
{
public class EnemyMagicMover : MonoBehaviour
{
    [SerializeField] internal float MoveSpeed;
    Rigidbody2D _rigiBody2D;


    private void Awake()
    {
        _rigiBody2D = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        
        _rigiBody2D.velocity = Vector2.left * MoveSpeed;
    }

 
}
    
}
