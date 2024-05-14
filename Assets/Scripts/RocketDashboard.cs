using TMPro;
using UnityEngine;


public class RocketDashboard : Rocket//UI담당
{
    private int score = 0;//to RocketDashboard
    private int highscore = 0;//to RocketDashboard

    [SerializeField] private TextMeshProUGUI currentScoreTxt;//to RocketDashboard
    [SerializeField] private TextMeshProUGUI HighScoreTxt;//to RocketDashboard

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
