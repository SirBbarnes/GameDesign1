using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    Rigidbody myRig;
    float speed = 5.0f;
    int hp = 100;
    public static int score;
    public Text scoreText, timeText;
    string timeHour;
    public GameObject prefButton, butt, panelInv;
    public RectTransform ParentPanel;
    public Slider healthSlide;
    Vector3 pos;
    
    // Start is called before the first frame update
    void Start()
    {
        myRig = GetComponent<Rigidbody>();
        if (myRig == null)
            throw new System.Exception("No Rigid Body on Game Object");

        scoreText = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
        timeText = GameObject.FindGameObjectWithTag("Time").GetComponent<Text>();
        pos.y = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BadBlock")
        {
            hp -= 10;
            Destroy(other.gameObject);
            healthSlide.value = hp;
            Debug.Log("Health: " + hp);
        }

        if (other.gameObject.tag == "GoodBlock")
        {

            score++;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "InvBlock")
        {
            pos.y -= 10;
            Destroy(other.gameObject);
            butt = Instantiate(prefButton);
            butt.transform.SetParent(ParentPanel, false);
            butt.transform.Translate(pos);
            
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            panelInv.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Tab))
        {
            panelInv.SetActive(false);
        }

        if (pos.y == -80)
        {
            pos.y = 0;
        }
        timeHour = System.TimeSpan.FromSeconds((int)Time.timeSinceLevelLoad).ToString();
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(-moveVertical, 0.0f, moveHorizontal);
        myRig.AddForce(movement * speed);

        scoreText.text = "Score: " + score.ToString();
        timeText.text = "Time: " + timeHour;

    }
}
