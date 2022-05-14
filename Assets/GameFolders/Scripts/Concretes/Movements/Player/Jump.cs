using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Proje1.Movements.Player
{
    public class Jump : MonoBehaviour
    {
        [SerializeField] private float _jumpForce = 300f;

        public void JumpAction(Rigidbody2D rigiBody2D)
        {
            rigiBody2D.velocity = Vector2.zero;
            rigiBody2D.AddForce(Vector2.up * _jumpForce);
        }
    }
}

