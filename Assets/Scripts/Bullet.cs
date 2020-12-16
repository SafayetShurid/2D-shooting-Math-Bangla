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
    public Sprite[] BulletSprites;


    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = BulletSprites[(int)Type];
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

 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggered Occured");

        int numberType = (int)collision.gameObject.GetComponent<Number>().Type;
        int bulletType = (int)Type;

        if (numberType == bulletType)
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
