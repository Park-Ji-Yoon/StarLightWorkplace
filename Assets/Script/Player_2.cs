using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_2 : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveSpeed;
    public float rotateAmount;
    float rot;
    int score = 0;
    public GameObject scoreText;
    public GameObject scorePanel;
    public GameObject NextBtn;
    public GameObject HomeBtn;
    public GameObject NextText;
    public GameObject HomeText;
    public GameObject player;
    public GameObject naverplaceBtn;
    public GameObject naverplaceText;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (mousePos.x < 0)
            {
                rot = rotateAmount;
            }
            else
            {
                rot = rotateAmount;
            }

            transform.Rotate(0, 0, rot);
        }
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                back();
            }
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = transform.up * moveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Food")
        {
            Destroy(collision.gameObject);

            if (score >= 5)
            {
                print("Level Complete");
                scoreText.SetActive(true);
                scorePanel.SetActive(true);
                NextBtn.SetActive(true);
                HomeBtn.SetActive(true);
                NextText.SetActive(true);
                HomeText.SetActive(true);
                naverplaceBtn.SetActive(true);
                naverplaceText.SetActive(true);
                player.SetActive(false);
            }

            score++;
        }
        else if (collision.gameObject.tag == "Danger")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Game_2");
        }
    }
    public void back()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }
}
