using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon2 : MonoBehaviour
{

    public Transform firePoint;
    public Transform firePoint2;
    public Transform firePoint3;
    public GameObject bullet;

    private Animator anim;
    public AudioSource ShotSound;
    private bool cooldown = false;
    private const float ShootInterval = 1f;
    // Update is called once per frame
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && !cooldown)
        {
            cooldown = true;
            Shoot();
            ShotSound.pitch = Random.Range(0.9f, 1.1f);
            ShotSound.Play();
            anim.SetBool("fire",true);
            Invoke("CoolDown", ShootInterval);
        }else
        {
            anim.SetBool("fire",false);
        }
    }
    void CoolDown(){
        cooldown = false;
    }
    void Shoot()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
        Instantiate(bullet, firePoint2.position, firePoint2.rotation);
        Instantiate(bullet, firePoint3.position, firePoint3.rotation);
    }
}