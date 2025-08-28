using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerGun : MonoBehaviour
{
    public Transform firePoint;
    public GameObject shellPrefab;
    public GameObject Cylinder;
    public float mSpeed = 5f;
    public float rSpeed = 50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
        MoveGun();
    }

    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            Instantiate(shellPrefab, firePoint.position, firePoint.rotation);
        }

    }

    private void MoveGun()
    {
        transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0, 0) * Time.deltaTime * mSpeed);
        transform.Rotate(new Vector3(-Input.GetAxis("Vertical"), 0, 0) * Time.deltaTime * rSpeed);
    }

    public void Restart()
    {
        SceneManager.LoadScene(2);
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}
