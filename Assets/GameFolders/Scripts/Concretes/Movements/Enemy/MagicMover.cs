using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Proje1.Movements.Enemy
{
public class MagicMover : MonoBehaviour
{
    [SerializeField] internal float MoveSpeed;
    Rigidbody2D _rigiBody2D;


    private void Awake()
    {
        this.transform.rotation = Quaternion.identity;
        _rigiBody2D = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        
        _rigiBody2D.velocity = Vector2.right * MoveSpeed;
    }

 
}
    
}
