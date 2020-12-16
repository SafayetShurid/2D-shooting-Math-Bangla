using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public enum BulletType
    {
        Even = 2,
        Odd = 1,
        Prime = 0
    }

    public BulletType Type;
    public Sprite[] BulletSpries;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BulletMovement();
    }

    private void BulletMovement()
    {
        transform.Translate(Vector2.up * 5f * Time.deltaTime);
    }
}
