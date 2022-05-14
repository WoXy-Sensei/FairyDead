using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Proje1.Sounds
{
    public class PlayerSound : MonoBehaviour
    {
        
        ///Sounds
        [SerializeField] AudioClip _clickSound;
        [SerializeField] AudioClip _magicFireSound;

        ///Sounds Volume
        [Range(0f,1f)]
        [SerializeField] float _clickSoundVolume;

        [Range(0f,1f)]
        [SerializeField] float _magicFirVolume;


        public AudioClip ClickSound => _clickSound;
        public float ClickSoundVolume => _clickSoundVolume;

        public AudioClip MagicFireSound => _magicFireSound;
        public float MagicFireSoundVolume => _magicFirVolume;
    }

}
