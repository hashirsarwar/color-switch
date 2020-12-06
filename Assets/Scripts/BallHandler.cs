using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallHandler : MonoBehaviour
{
    public Rigidbody2D rb;
    public float force;
    public Color Blue, Pink, Yellow, Purple;
    private string playerColor;
    public SpriteRenderer sr;
    private int score = 0;
    public GameManager gd;
    public Text textRef;
    // Start is called before the first frame update
    void Start()
    {
        rb.gravityScale = 0;
        ChooseRandomColor();
    }

    void ChooseRandomColor()
    {
        int index = Random.Range(0, 4);
        switch (index)
        {
            case 0:
                sr.color = Blue;
                playerColor = "Blue";
                break;
            case 1:
                sr.color = Yellow;
                playerColor = "Yellow";
                break;
            case 2:
                sr.color = Pink;
                playerColor = "Pink";
                break;
            case 3:
                sr.color = Purple;
                playerColor = "Purple";
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.gravityScale = 2;
            Push();
        }
    }

    private void Push()
    {
        rb.velocity = new Vector2(0, force);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ColorChanger")
        {
            ChooseRandomColor();
            gd.Spawner();
            Destroy(collision.gameObject);
            return;
        }
        if (collision.tag == "Star")
        {
            ++score;
            textRef.text = "Score " + score.ToString();
            Destroy(collision.gameObject);
            return;
        }
        if (collision.tag == "Slider")
        {
            Push();
            return;
        }
        if (collision.tag != playerColor)
        {
            SceneManager.LoadScene(0);
        }
    }
}
