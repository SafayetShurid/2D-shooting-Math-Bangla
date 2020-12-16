using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Number : MonoBehaviour
{
   public enum NumberType
    {
        Even=2,
        Odd=1,
        Prime=0
    }

    public NumberType Type;
    public int Value;
    public int DecimalNumber;
    public int SingleNumber;
    public SpriteRenderer[] SpriteRenderers;
    public Sprite[] BanglaNumbersSprites = new Sprite[10];


    void Start()
    {
        SetNumberType();
        SetSprites(DecimalNumber,SingleNumber);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * 3f * Time.deltaTime);
        if (transform.position.y < -6.37f)
        {
            Destroy(this.gameObject);
        }
    }

    void SetNumberType()
    {
       
        DecimalNumber = Random.Range(0, 10);
        SingleNumber = Random.Range(0, 10);
        Value = DecimalNumber * 10 + SingleNumber;

        if(Value%2==0)
        {
            Type = NumberType.Even;
        }

        else
        {
            Type = NumberType.Odd;

            int numberOfDividers = 0;

            for(int i=1; i<=Value; i++)
            {
                if(Value%i==0)
                {
                    numberOfDividers++;
                }
                if(numberOfDividers>2)
                {
                    break;
                }
            }

           Type = numberOfDividers>2 ? NumberType.Odd : NumberType.Prime;

        }

       
    }

    void SetSprites(int DecimalNumber,int SingleNumber)
    {
        SpriteRenderers = GetComponentsInChildren<SpriteRenderer>();
        SpriteRenderers[0].sprite = BanglaNumbersSprites[DecimalNumber];
        SpriteRenderers[1].sprite = BanglaNumbersSprites[SingleNumber];
    }
}
