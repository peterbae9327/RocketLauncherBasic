using TMPro;
using UnityEngine;


public class RocketDashboard : Rocket//UI담당
{
    private int score = 0;
    private int highscore = 0;

    [SerializeField] private TextMeshProUGUI currentScoreTxt;
    [SerializeField] private TextMeshProUGUI HighScoreTxt;
    private void Update()
    {
        score = (int)GameObject.FindWithTag("Player").transform.position.y;
        if (score >= highscore)
        {
            highscore = score;
        }
        currentScoreTxt.text = $"{score} M";
        HighScoreTxt.text = $"High : {highscore} M";
    }
}
