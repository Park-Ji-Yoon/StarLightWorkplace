using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DukPlayer_4 : MonoBehaviour
{

    public Transform Player;
    public float Speed;
    public int bounce;
    bool a, b;

    int score = 0;

    Rigidbody2D rigid;
    SpriteRenderer spriteRenderer;

    public GameObject OpenButton;
    public GameObject OpenText;

    public GameObject Panel;
    public GameObject Text;
    public GameObject NextBtn;
    public GameObject NextText;
    public GameObject HomeBtn;
    public GameObject HomeText;

    public GameObject PlayerObject;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (a)
        {
            Player.position += Vector3.left * Speed * Time.deltaTime;
        }

        if (b)
        {
            Player.position += Vector3.right * Speed * Time.deltaTime;
        }
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                back();
            }
        }
    }

    public void Up()
    {
        a = false;
    }
    public void Down()
    {
        a = true;
    }
    public void BackUp()
    {
        b = false;
    }
    public void BackDown()
    {
        b = true;
    }
    public void Jump()
    {
        rigid.velocity = Vector2.zero;
        Vector2 JumpVelocity = new Vector2(0, bounce);
        rigid.AddForce(JumpVelocity, ForceMode2D.Impulse);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Food")
        {
            Destroy(collision.gameObject);
            score++;

            if (score >= 5)
            {
                OpenButton.SetActive(true);
                OpenText.SetActive(true);
            }
        }
        else if (collision.gameObject.tag == "Danger")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("JumpGame");
        }
    }
    public void CloseStore()
    {
        Panel.SetActive(true);
        Text.SetActive(true);
        NextBtn.SetActive(true);
        NextText.SetActive(true);
        PlayerObject.SetActive(false);
        HomeBtn.SetActive(true);
        HomeText.SetActive(true);
    }
    public void back()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(11);
    }
}
