using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public Text ScoreText;
    public Image Bullet;
    public Sprite[] BulletImages;
    Player player;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
         
        ScoreText.text = GameManager.instance.Score.ToString();
        Debug.Log((int)player.BulletType);
        Bullet.sprite = BulletImages[(int)player.BulletType];

    }
}
