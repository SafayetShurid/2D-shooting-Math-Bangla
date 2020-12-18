using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{

    public float Speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down* Speed * Time.deltaTime,Space.World);

        if(transform.position.y<=-11.5)
        {
            Vector2 pos = transform.position;
            pos.y = 12.5f;
            transform.position = pos;
        }
    }
}
