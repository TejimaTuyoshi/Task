using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Rigidbody _rigidBody;
    [SerializeField] GameObject _item1;
    [SerializeField] GameObject _item2;
    [SerializeField] GameObject _item3;
    [SerializeField] GameObject _text;
    int number0;
    bool isStop = false;
    void Awake()
    {
        var random = new System.Random();
        number0 = random.Next(01, 04);
        _rigidBody = GetComponent<Rigidbody>();
        switch (number0)
        {
            case 1:
                _item1.SetActive(true);
                break;
            case 2:
                _item2.SetActive(true);
                break;
            case 3:
                _item3.SetActive(true);
                break;
        }
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
        if (other.gameObject.CompareTag("item"))
        {
            _item1.SetActive(false);
            _text.SetActive(true);
        }
        if (other.gameObject.CompareTag("item2"))
        {
            _item2.SetActive(false);
            _text.SetActive(true);
        }
        if (other.gameObject.CompareTag("item3"))
        {
            _item3.SetActive(false);
            _text.SetActive(true);
        }
    }
}