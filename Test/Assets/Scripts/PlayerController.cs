using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;

    public Text countText;
    private int count;

    public Text filmText;
    public int film;

    /*public float radius;
    public float depth;
    public float angle;
    //private Physics physics;
    */
    //Camera cam;

    //public LayerMask kiwiMask;
    //public GameObject Menu;

    public GameObject pausePanel;
    bool pause = false;

    bool scoring = true;

    public GameObject WinScreen;
    public GameObject LoseScreen;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        //cam = Camera.main;

        count = 0;
        //SetCountText();

        //pausePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Item1"))
        {
            //other.gameObject.SetActive(false);
            Debug.Log("Hi!");
            if (film != 0)
            {
                film = film - 1;
                filmText.text = "Film: " + film.ToString();
                count = count + 1;
                countText.text = "Count: " + count.ToString();
            }
            else if (film == 0)
            {
                scoring = false;
                count = count + 0;
                film = film - 0;
            }
            //WinScreen.SetActive(true);
            //win = GameObject.FindGameObjectsWithTag("Win");
            //hideWin();
        }
    }

    private void Scoring()
    {

    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }
}
