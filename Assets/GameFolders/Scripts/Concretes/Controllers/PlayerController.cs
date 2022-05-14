using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Proje1.Movements.Player;
using Proje1.Inputs;
using Proje1.Combats;
using Proje1.Sounds;

namespace Proje1.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        Rigidbody2D _rigiBody2D;
        Collider2D _collider2D;
        private bool _isJumpClicked;
        private bool _isFireClicked;
        private bool _isDashedClicked;
        private bool _isBackDashedClicked;
        private Jump _jump;
        private Dash _dash;
        private Dead _dead;
        private AudioSource _audioSound;
        private ComputerInputs _input;
        private PlayerSound _PlayerSound;
        private LunchMagic _magic;
        private void Awake()
        {

            _rigiBody2D = GetComponent<Rigidbody2D>();
            _collider2D = GetComponent<Collider2D>();
            _jump = GetComponent<Jump>();
            _dash = GetComponent<Dash>();
            _dead = GetComponent<Dead>();
            _audioSound = GetComponent<AudioSource>();
            _PlayerSound = GetComponent<PlayerSound>();
            _magic = GetComponent<LunchMagic>();
            _input = new ComputerInputs();

        }
        private void Update()
        {
            if(_dash._isDashing || _dead.IsDead){
                return;
            }

            if(_dead.IsDead){
                return;
            }

            if (_input.JumpClickDown)
            {
                _isJumpClicked = true;
            }

            if(_input.DashClickDown && _dash._canDash){
          
                _isDashedClicked = true;    
            }

            if(_input.BackDashClickDown && _dash._canBackDash){
                
                _isBackDashedClicked = true;    
            }
            
            if(_input.FireClickDown && _magic._canLunch){
               
                _isFireClicked = true;    
            }
        }
        private void FixedUpdate()
        {
            if (_isJumpClicked)
            {
                _jump.JumpAction(_rigiBody2D);
                _audioSound.PlayOneShot(_PlayerSound.ClickSound,_PlayerSound.ClickSoundVolume);
                _isJumpClicked = false;
            }
            if(_isDashedClicked){
                StartCoroutine(_dash.DashAction(_rigiBody2D));
                _audioSound.PlayOneShot(_PlayerSound.ClickSound,_PlayerSound.ClickSoundVolume);
                _isDashedClicked = false;
            }
            if(_isBackDashedClicked){
                StartCoroutine(_dash.BackDashAction(_rigiBody2D));
                _audioSound.PlayOneShot(_PlayerSound.ClickSound,_PlayerSound.ClickSoundVolume);
                _isBackDashedClicked = false;
            }
            if(_isFireClicked){
                StartCoroutine(_magic.LunchAction());
                _audioSound.PlayOneShot(_PlayerSound.MagicFireSound,_PlayerSound.MagicFireSoundVolume);
                _audioSound.PlayOneShot(_PlayerSound.ClickSound,_PlayerSound.ClickSoundVolume);
                
                _isFireClicked = false;
            }
        }
        
        

        

    }

}
