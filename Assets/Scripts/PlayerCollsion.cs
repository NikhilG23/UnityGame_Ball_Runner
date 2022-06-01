using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollsion : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerScript playerScript;
    public Score score;
    public GameController gameController;
    public AudioSource audiosource;
    public AudioSource audiosource1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collectables")
        {
            score.AddScore(1);
            audiosource.Play();
            Destroy(other.gameObject);
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="obstical")
        {
            
            gameController.GameOver();
            audiosource1.Play();
            playerScript.enabled = false;
        }
    }
}
