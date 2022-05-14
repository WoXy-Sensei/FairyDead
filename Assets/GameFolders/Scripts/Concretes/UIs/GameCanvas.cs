using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Proje1.Combats;

namespace Proje1.UIs
{
public class GameCanvas : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel;


    private void Start() {
        
        Dead dead = FindObjectOfType<Dead>();
        dead.OnDead += DeadHandle;

    }
    private void DeadHandle(){
        gameOverPanel.SetActive(true);
    }
}
    
}
