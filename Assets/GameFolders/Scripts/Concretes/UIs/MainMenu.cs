using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Proje1.UIs
{

    public class MainMenu : MonoBehaviour
    {
        public void StartGameButton(){
            GameManager.Instance.StartGame();
        }
        public void ExitGameButton(){
            GameManager.Instance.ExitGame();
        }
    }

}