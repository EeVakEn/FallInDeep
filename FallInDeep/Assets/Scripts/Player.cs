using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public static Player instance;
     private bool facingRight = true;
    public Rigidbody2D rb;
    public GameObject ControlButtons;
    public GameObject ControlJoystick;
    public float HorizontalMove;
    public float speed = 1f;
    public float fallspeed = 3f;
    public Joystick joystick;
    public float speedx = 50000f;
    public int chooseControl = 2;
    private int normalSpeed=1;
    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        chooseControl = Public.control;
    }

    private void FixedUpdate()
    {
        //ганьг
        //выбор управленя
        if(chooseControl == 0){//джойстик
            ControlJoystick.SetActive(true);
            ControlButtons.SetActive(false);
            HorizontalMove = joystick.Horizontal;
            rb.velocity = new Vector2(HorizontalMove*10f*speedx, 0f);
        }else
        if(chooseControl == 1){//кнопки
            ControlJoystick.SetActive(false);
            ControlButtons.SetActive(true);
            rb.velocity = new Vector2(HorizontalMove*10f*speedx, 0f);
        }else
        if(chooseControl == 2){//акселерометр
            ControlJoystick.SetActive(false);
            ControlButtons.SetActive(false);
            Vector3 acceleration = Input.acceleration;
            HorizontalMove = acceleration.x;
            Vector2 targetVelocity = new Vector2(HorizontalMove * 10f * speedx, 0f);
            rb.velocity = targetVelocity;
        }else
        if(chooseControl == 3){//wasd
            ControlJoystick.SetActive(false);
            ControlButtons.SetActive(false);
            HorizontalMove = Input.GetAxisRaw("Horizontal");
            Vector2 targetVelocity = new Vector2(HorizontalMove * 10f * speedx, 0f);
            rb.velocity = targetVelocity;
        }

        
        if(facingRight == false && HorizontalMove > 0)
        {
            Flip();
        } else if (facingRight == true && HorizontalMove < 0)
        {
            Flip();
        }
    }
    void OnLeftButtonDown(){
        if(HorizontalMove >= 0f){
            HorizontalMove = -normalSpeed;
        }
    }
    void OnRightButtonDown(){
        if(HorizontalMove <= 0f){
            HorizontalMove = normalSpeed;
        }
    }
    void OnButtonUp(){
        HorizontalMove = 0f;
    }
    void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0f,180f,0f);
        // Vector3 Scaler = transform.localScale;
        // Scaler.x *= -1;
    
        // transform.localScale = Scaler;
    }
}

