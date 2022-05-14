using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Proje1.Effects;
using Proje1.Controllers;
namespace Proje1.Combats
{
public class DeadFairyEnemy : MonoBehaviour
{
    [SerializeField] ParticleEffect _particleEffect;
    public void LunchDead(Transform transformObject){
        ParticleAction(transformObject);
    }
    public void ParticleAction(Transform transformObject){
        ParticleEffect newObject = Instantiate(_particleEffect,transformObject.localPosition,transformObject.rotation);
        

    }
}
    
}
