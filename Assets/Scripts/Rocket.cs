using UnityEngine;
using UnityEngine.SceneManagement;

public class Rocket : MonoBehaviour
{
    private Rigidbody2D _rb2d;
    private readonly float SPEED = 5f;

    void Awake()
    {
        _rb2d = GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>();
    }
    public void RetryButton()
    {
        SceneManager.LoadScene("RocketLauncher");
    }
    public void AddForce()
    {
        _rb2d.AddForce(Vector2.up*SPEED,ForceMode2D.Impulse);
    }
}