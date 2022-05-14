using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Proje1.UIs
{
    public class GameOverPanel : MonoBehaviour
    {
        public void RestartButton()
        {
            GameManager.Instance.StartGame();
        }
        public void ReturnMenuButton()
        {
            GameManager.Instance.ReturnMenu();
        }
    }
}

