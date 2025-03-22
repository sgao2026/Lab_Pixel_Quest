using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{

    public string nextLevel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case ("Death"):
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                    break;
                }
            case ("Finish"):
                {
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
        }
    }
}
