using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoinCollectionScript : MonoBehaviour
{
    [SerializeField] public Text Score;
    [SerializeField] public Text Timer;

    [SerializeField] public float score;
    [SerializeField] public float timeleft;
    [SerializeField] public float totalcoins;
    [SerializeField] public int timeremaining;
    [SerializeField] private float scorevalue;

    [SerializeField] public float Timervalue;
    void Start()
    {
        Score.text = "Score: " + score;
    }

    private void Update()
    {
        timeleft -= Time.deltaTime;

        timeremaining = Mathf.FloorToInt(timeleft % 60);

        Timer.text = "timer: " + timeremaining.ToString();

        if(scorevalue==totalcoins)
        {
            if(timeleft<=Timervalue)
            {
                SceneManager.LoadScene("GameWinScene");
            }
        }
        else if (timeleft <= 0)
        {
            SceneManager.LoadScene("GameLoseScene");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            score += 10;
            scorevalue++;
            Score.text = "Score: " + score;
        }
    }
}
