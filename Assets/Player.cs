using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float Speed;
    public Bullet Bullet;
    public Bullet.BulletType BulletType;

    [SerializeField]
    private float FireRate = 0.25f;
    private float CanFire = 0.00f;

    void Start()
    {
        Speed = 5f;
        BulletType = Bullet.BulletType.Even;
    }

    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(horizontal, vertical);
        transform.Translate(movement * Speed * Time.deltaTime);


        Shoot();
        ChangeBullet();



    }

    public void Shoot()
    {
        if (Input.GetKey(KeyCode.Space) && Time.time > CanFire)
        {
            Bullet.Type = BulletType;
            Instantiate(Bullet, transform.position + new Vector3(0, 0.6f, 0), Quaternion.identity);
            CanFire = Time.time + FireRate;
        }

    }

    public void ChangeBullet()
    {
        if (Input.GetKey(KeyCode.I))
        {
            BulletType = Bullet.BulletType.Even;
        }
        if (Input.GetKey(KeyCode.O))
        {
            BulletType = Bullet.BulletType.Odd;
        }
        if (Input.GetKey(KeyCode.P))
        {
            BulletType = Bullet.BulletType.Prime;
        }
    }
}
