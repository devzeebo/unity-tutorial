using System;
using UnityEngine;

namespace UnityStandardAssets._2D
{
    public class Restarter : MonoBehaviour
    {
        public GameObject GameOverScreen;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                GameOverScreen.SetActive(true);
            }
        }

        public void Restart() {
            Application.LoadLevel(Application.loadedLevelName);
        }
    }
}
