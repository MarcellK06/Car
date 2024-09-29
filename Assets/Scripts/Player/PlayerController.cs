using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    public CharacterController controller;

[SerializeField]
    private int speed;
    public int sensitivity;
    [SerializeField]
    private float gravity;
    [SerializeField]
    private Transform head, raycastPos;
    private float verticalVelocity = -4f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!controller.isGrounded)
            verticalVelocity += gravity*Time.deltaTime;
        else
            verticalVelocity = -4f;
        if(Input.GetButton("Jump") && controller.isGrounded) {
            verticalVelocity = -gravity/1.3f;
        }

        if (Input.GetButtonDown("Escape"))
            Cursor.lockState = Cursor.lockState == CursorLockMode.Locked ? CursorLockMode.None : CursorLockMode.Locked;


        float w_s = Input.GetAxisRaw("Vertical");
        float a_d = Input.GetAxisRaw("Horizontal");

        float x = Input.GetAxisRaw("Mouse X");
        float y = Input.GetAxisRaw("Mouse Y");

        if (!controller.isGrounded)
        {
            w_s /= 3;
            a_d /= 3;
        }

        #region animator parameters
        animator.SetBool("Forwards", w_s > 0 && a_d == 0 && verticalVelocity  == -4);
        animator.SetBool("Backwards", w_s < 0 && a_d == 0 && verticalVelocity  == -4);
        animator.SetBool("Forwards-Left", w_s > 0 && a_d < 0 && verticalVelocity  == -4);
        animator.SetBool("Forwards-Right", w_s > 0 && a_d > 0 && verticalVelocity  == -4);
        animator.SetBool("Backwards-Left", w_s < 0 && a_d > 0 && verticalVelocity  == -4);
        animator.SetBool("Backwards-Right", w_s < 0 && a_d < 0 && verticalVelocity  == -4);
        animator.SetBool("Left", a_d < 0 && w_s == 0 && verticalVelocity  == -4);
        animator.SetBool("Right", a_d > 0 && w_s == 0 && verticalVelocity  == -4);
        animator.SetBool("Falling", verticalVelocity < -4);
        animator.SetBool("Jumping", Input.GetButton("Jump"));
        animator.SetBool("Grounded", controller.isGrounded);
        #endregion

        controller.Move(transform.forward * w_s * speed * Time.deltaTime + transform.right * a_d * speed * Time.deltaTime + transform.up * verticalVelocity * Time.deltaTime);
        head.Rotate(transform.right * y * sensitivity * Time.deltaTime + transform.up * x * sensitivity * Time.deltaTime);
        Debug.Log(transform.right);
        Vector3 headRot = head.localEulerAngles;
        if (headRot.x > 180f) headRot.x -= 360f;

        headRot.x = Mathf.Clamp(headRot.x, -90f, 90f);
        headRot.z = Mathf.Clamp(headRot.z, 0f, 0f);
        if (w_s != 0 || a_d != 0) {
            transform.Rotate(new Vector3(0f, headRot.y, 0f));
            headRot.y = 0;
        }
        head.localEulerAngles = new Vector3(headRot.x, headRot.y, 0f);
    }
}
