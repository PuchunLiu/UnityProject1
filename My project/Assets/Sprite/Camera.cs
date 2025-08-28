using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Vector3 offest;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        offest = transform.position - Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position + offest;
    }
}
