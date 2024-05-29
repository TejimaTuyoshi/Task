using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] int _count;
    [SerializeField] float _index = -45.5f;
    // Start is called before the first frame update
    void Start()
    {
        for (var i = 0; i < _count; i++)
        {
            var obj = (GameObject)Resources.Load("Item");
            var collider = obj.AddComponent<BoxCollider>();
            collider.isTrigger = true;
            Instantiate(obj, new Vector3(_index, 1.0f, 0.0f), Quaternion.identity);
            obj.tag = "item";
            _index += 5;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
