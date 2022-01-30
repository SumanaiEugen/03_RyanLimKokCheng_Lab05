using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameWinloseScript : MonoBehaviour
{
    public void restart()
    {
        SceneManager.LoadScene("GameScene");
    }
}
