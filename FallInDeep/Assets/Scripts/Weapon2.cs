using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Update
public class Weapon2 : MonoBehaviour
{

    public Transform firePoint;
    public Transform firePoint2;
    public Transform firePoint3;
    public GameObject bullet;

    private Animator anim;
    public AudioSource ShotSound;
    // Update is called once per frame
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            ShotSound.pitch = Random.Range(0.9f, 1.1f);
            ShotSound.Play();
            anim.SetTrigger("reload");
        }
    }

    void Shoot()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
        Instantiate(bullet, firePoint2.position, firePoint2.rotation);
        Instantiate(bullet, firePoint3.position, firePoint3.rotation);
    }
}