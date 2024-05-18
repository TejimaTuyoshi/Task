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
            _rigidBody.AddForce(Vector3.right * 5, ForceMode.Force);
        }
        if (isStop) 
        {
            _rigidBody.AddForce(Vector3.right * 0, ForceMode.Force);
            Time.timeScale = 0.0f;
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