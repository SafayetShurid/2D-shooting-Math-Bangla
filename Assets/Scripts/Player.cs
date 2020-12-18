using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float Speed;
    private Camera Camera;
    public Bullet Bullet;
    public Bullet.BulletType BulletType;

    public Transform XLeft, XRight, YUp, YDown;

    [SerializeField]
    private float FireRate = 0.25f;
    private float CanFire = 0.00f;

    void Start()
    {
        Camera = Camera.main;
    }

    
    void Update()
    {

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(horizontal, vertical);
        transform.Translate(movement * Speed * Time.deltaTime);


        Shoot();
        ChangeBullet();
        
        MouseMovement();
        checkMaxMoevement();



    }

    private void checkMaxMoevement()
    {
        if(transform.position.x<=XLeft.position.x)
         {
            Vector2 leftPos = transform.position;
            leftPos.x = XLeft.position.x;
            transform.position = leftPos;
         }
         if (transform.position.x >=XRight.position.x)
         {
            Vector2 rightPos = transform.position;
            rightPos.x = XRight.position.x;
            transform.position = rightPos;
         }
         if (transform.position.y >= YUp.position.y)
         {
            Vector2 upPos = transform.position;
            upPos.y = YUp.position.y;
            transform.position = upPos;
         }
         if (transform.position.y <= YDown.position.y)
         {
            Vector2 downPos = transform.position;
            downPos.y = YDown.position.y;
            transform.position = downPos;
         }

        /*Vector3 playerMovement = transform.position;
        playerMovement.x = Mathf.Clamp(playerMovement.x,XLeft.position.x, XRight.position.x);
        playerMovement.y = Mathf.Clamp(playerMovement.y, YUp.position.y, YDown.position.y);
        transform.position = playerMovement;*/
    }

    private void MouseMovement()
    {
        // get mouse position
        Vector2 mousePos = Camera.ScreenToWorldPoint(Input.mousePosition);

        // discard y
        mousePos = new Vector2(mousePos.x, mousePos.y);

        transform.position = mousePos;
        //transform.position = Vector2.MoveTowards(transform.position, mousePos, Speed * Time.deltaTime);
    }

    public void Shoot()
    {
        if (Input.GetKey(KeyCode.Space) || Input.GetMouseButtonDown(0) && Time.time > CanFire)
        {
            Bullet.Type = BulletType;
            Instantiate(Bullet, transform.position + new Vector3(0, 0.6f, 0), Quaternion.identity);
            CanFire = Time.time + FireRate;
        }

    }

    public void ChangeBullet()
    {
        if (Input.GetKey(KeyCode.A))
        {
            BulletType = Bullet.BulletType.Even;
        }
        if (Input.GetKey(KeyCode.S))
        {
            BulletType = Bullet.BulletType.Odd;
        }
        if (Input.GetKey(KeyCode.D))
        {
            BulletType = Bullet.BulletType.Prime;
        }
    }



}
