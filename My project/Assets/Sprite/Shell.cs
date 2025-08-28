using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    public Vector3 force;
    public Rigidbody rb;
    public float speed = 10000f;
    // Start is called before the first frame update
    void Start()
    {
        force = transform.up * speed;
        rb.AddForce(force);
        Destroy(gameObject, 20f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Boob")
        {
            BoxCollider otherCollider = collision.collider.GetComponent<BoxCollider>();
            otherCollider.size *= 2f;
            Renderer renderer = collision.collider.GetComponent<Renderer>();
            renderer.enabled = false;
            Destroy(collision.gameObject, 1f);
        }
    }
}
