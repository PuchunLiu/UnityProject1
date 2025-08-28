
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    public Rigidbody body;
    public int Score = 0;
    public Vector3 force = new Vector3(0f, 0f, 0f);
    public Text Scoretext;
    public GameObject RestartGameobject;

    public AudioSource AudioSource;
    public AudioClip triggerSound;
    //public Button RestartButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    private void FixedUpdate()
    {
        body.AddForce(force * speed);
    }

    private void PlayerMove()
    {
        force = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Food") 
        {
            Score += 1;
            Scoretext.text = "Score: " + Score.ToString();
            AudioSource.PlayOneShot(triggerSound);
            Destroy(other.gameObject);
            if (Score >= 8)
            {
                RestartGameobject.SetActive(true);
            }
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}
