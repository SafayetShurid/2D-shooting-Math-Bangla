using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Numbers : MonoBehaviour
{

    public Sprite[] BanglaNumbers;
    public SpriteRenderer s;

    void Start()
    {
        s = GetComponent<SpriteRenderer>();
        s.sprite = BanglaNumbers[Random.Range(0, 10)];

    }
}
