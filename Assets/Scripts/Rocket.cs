using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Rocket : MonoBehaviour
{
    private Rigidbody2D _rb2d;
    private float fuel = 100f;
    
    private readonly float SPEED = 5f;
    private readonly float FUELPERSHOOT = 10f;

    private int score;
    private int highscore;

    [SerializeField] private TextMeshProUGUI currentScoreTxt;
    [SerializeField] private TextMeshProUGUI HighScoreTxt;
    void Awake()
    {
        _rb2d = GameObject.Find("Rocket").GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        score = (int)gameObject.transform.position.y;
        currentScoreTxt.text = $"{score} M";
        HighScoreTxt.text = $"High : {highscore} M";
        if (score >= highscore)
        {
            highscore = score;
        }
    }
    public void RetryButton()
    {
        SceneManager.LoadScene("RocketLauncher");
    }
    public void Shoot()
    {
        if (fuel >= FUELPERSHOOT)
        {
            _rb2d.AddForce(Vector2.up*SPEED);
            fuel -= FUELPERSHOOT;
        }
    }
}
