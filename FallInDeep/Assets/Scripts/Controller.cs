using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject pl;
    public Rigidbody2D rb;
    private bool facingRight = true;
    public GameObject ControlButtons;
    public GameObject ControlJoystick;
    public Joystick joystick;
    private float HorizontalMove;
    public float speedx = 0.2f;
    private int chooseControl;


    
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("Control") )
            chooseControl = PlayerPrefs.GetInt("Control");
        else
            chooseControl = 0;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(chooseControl == 0){//джойстик
            ControlJoystick.SetActive(true);
            ControlButtons.SetActive(false);
            HorizontalMove = joystick.Horizontal;
            rb.velocity = new Vector2(HorizontalMove*10f*speedx, 0f);
        }else
        if(chooseControl == 1){//кнопки
            ControlJoystick.SetActive(false);
            ControlButtons.SetActive(true);
            rb.velocity = new Vector2(HorizontalMove* 7f * speedx, 0f);
        }else
        if(chooseControl == 2){ //акселерометр
            ControlJoystick.SetActive(false);
            ControlButtons.SetActive(false);
            HorizontalMove = Input.acceleration.x;
            rb.velocity = new Vector2(HorizontalMove * 10f * speedx, 0f);
        }else
        if(chooseControl == 3){//wasd
            ControlJoystick.SetActive(false);
            ControlButtons.SetActive(false);
            HorizontalMove = Input.GetAxisRaw("Horizontal");
            Vector2 targetVelocity = new Vector2(HorizontalMove * 7f * speedx, 0f);
            rb.velocity = targetVelocity;
        }

        
        if(facingRight == false && HorizontalMove > 0)
            Flip();
        else if (facingRight == true && HorizontalMove < 0)
            Flip();
    }
    public void OnLeftButtonDown(){
        if(HorizontalMove >= 0f)
            HorizontalMove = -1f;
    }
    public void OnRightButtonDown(){
        if(HorizontalMove <= 0f)
            HorizontalMove = 1f;
    }
    public void OnButtonUp(){
        HorizontalMove = 0f;
    }
    void Flip()
    {
        facingRight = !facingRight;
        pl.transform.Rotate(0f,180f,0f);
    }
}