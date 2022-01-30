using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollectionScript : MonoBehaviour
{
    [SerializeField] public Text Score;
    [SerializeField] public float score;

    void Start()
    {
        Score.text = "Score: " + score;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            score += 10;
            Score.text = "Score: " + score;
        }
    }
}
