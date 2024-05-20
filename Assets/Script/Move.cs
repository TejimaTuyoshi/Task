using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Rigidbody _rigidBody;
    bool isStop = false;
    void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //TODO
        //ˆÚ“®‚¹‚æ
        if (!isStop)
        {
            _rigidBody.AddForce(Vector3.right * 1, ForceMode.Force);
        }
        if (isStop) 
        {
            _rigidBody.AddForce(Vector3.right * 0, ForceMode.Force);
            Time.timeScale = 0.0f;
        }
        if (Input.GetKeyDown("a"))
        {
            transform.position += transform.TransformDirection(Vector3.forward) * 1.7f;
        }
        if (Input.GetKeyDown("d"))
        {
            transform.position += transform.TransformDirection(Vector3.back) * 1.7f;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("stop"))
        {
            isStop = true;
        }
    }
}