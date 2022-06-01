using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float speed = 10f;
    public float force = 1000f;
    public float minX;
    public float maxX;
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = transform.position = new Vector3(0, 0, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        /*if (playerpos.x < minX)
        {
            playerpos.x = minX;
        }
        transform.position = playerpos;
        if (playerpos.x>maxX)
        {
            playerpos.x = maxX;
        }*/
        Vector3 playerpos = transform.position;
        playerpos.x = Mathf.Clamp(playerpos.x, minX, maxX);
        transform.position = playerpos;
       
        if (Input.GetKey(KeyCode.RightArrow)|| Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position+new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow)|| Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position - new Vector3(speed * Time.deltaTime, 0, 0);
        }
    }
    private void FixedUpdate()
    {
        rigidbody.AddForce(0, 0, force*Time.deltaTime);
    }
}
