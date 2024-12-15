using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Scoreboard : MonoBehaviour
{
    [SerializeField] TMP_Text scoreboardText;
    int score = 0;

    public void InscreaseScore(int amount)
    {
        score += amount;
        scoreboardText.text = score.ToString();
    }
}
