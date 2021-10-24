using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Move(Vector3.left);
        }
        else if(Input.GetKeyDown(KeyCode.D))
        {
            Move(Vector3.right);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            Move(Vector3.forward);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            Move(Vector3.back);
        }
    }

    private void Move(Vector3 direction)
    {
        transform.Translate(playerSpeed * direction * Time.deltaTime);
    }
}
