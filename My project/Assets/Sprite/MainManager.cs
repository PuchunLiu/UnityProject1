using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    public GameObject Loading;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadGameOne()
    {
        Loading.SetActive(true);
        SceneManager.LoadScene(1);
    }

    public void LoadGameTwo()
    {
        Loading.SetActive(true);
        SceneManager.LoadScene(2);
    }
}
