using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Proje1.Movements.Player
{
    public class Dash : MonoBehaviour
    {
        [SerializeField] private float _dashForce = 700f;
        [SerializeField] private float _dashingTime = 0.1f;
        [SerializeField] private float _dashCoolDown = 1f;
        internal bool _canDash = true;
        internal bool _canBackDash = true;
        internal bool _isDashing;



        public IEnumerator DashAction(Rigidbody2D rigiBody2D)
        {

            _canDash = false;
            _isDashing = true;
            float orginalGravity = rigiBody2D.gravityScale;
            rigiBody2D.gravityScale = 0f;
            rigiBody2D.velocity = Vector2.zero;
            rigiBody2D.AddForce(Vector2.right * _dashForce);
            yield return new WaitForSeconds(_dashingTime);
            rigiBody2D.velocity = Vector2.zero;
            rigiBody2D.gravityScale = orginalGravity;
            _isDashing = false;
            yield return new WaitForSeconds(_dashCoolDown);
            _canDash = true;


        }
        public IEnumerator BackDashAction(Rigidbody2D rigiBody2D)
        {

            _canBackDash = false;
            _isDashing = true;
            float orginalGravity = rigiBody2D.gravityScale;
            rigiBody2D.gravityScale = 0f;
            rigiBody2D.velocity = Vector2.zero;
            rigiBody2D.AddForce(Vector2.left * _dashForce);
            yield return new WaitForSeconds(_dashingTime);
            rigiBody2D.velocity = Vector2.zero;
            rigiBody2D.gravityScale = orginalGravity;
            _isDashing = false;
            yield return new WaitForSeconds(_dashCoolDown);
            _canBackDash = true;


        }
    }
}
