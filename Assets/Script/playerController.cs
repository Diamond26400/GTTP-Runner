using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private Rigidbody playerRb;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            {
            Debug.Log("Space bar pressed"); // Add this line for debugging
            playerRb.AddForce(Vector3.up * 100,ForceMode.Impulse);
            }
        }

    }

