using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Rocket : MonoBehaviour
{
    private Rigidbody2D _rb2d;
    [SerializeField] private Image image;
    private float fuel = 100f;
    
    private readonly float SPEED = 5f;
    private readonly float FUELPERSHOOT = 10f;

    private int score = 0;
    private int highscore = 0;

    [SerializeField] private TextMeshProUGUI currentScoreTxt;
    [SerializeField] private TextMeshProUGUI HighScoreTxt;

    private RocketEnergySystem energySystem = new RocketEnergySystem();
    private RocketDashboard dashboard = new RocketDashboard();
    void Awake()
    {
        _rb2d = GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (fuel <= 100f)
        {
            fuel += 0.1f;
        }

        image.fillAmount = fuel / 100f;
        score = (int)GameObject.FindWithTag("Player").transform.position.y;
        if (score >= highscore)
        {
            highscore = score;
        }
        currentScoreTxt.text = $"{score} M";
        HighScoreTxt.text = $"High : {highscore} M";

    }
    public void RetryButton()
    {
        SceneManager.LoadScene("RocketLauncher");
    }
    public void Shoot()
    {
        if (fuel >= FUELPERSHOOT)
        {
            _rb2d.AddForce(Vector2.up*SPEED,ForceMode2D.Impulse);
            fuel -= FUELPERSHOOT;
        }
    }
}