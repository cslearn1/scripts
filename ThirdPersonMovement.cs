using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public float speedWalk = 4f;
    public float speedRun = 9f;
    float targetMovingSpeed;
    public bool canRun = true;
    public bool run;
    public KeyCode runningKey = KeyCode.Q;
    private Rigidbody playerRigidbody;

    void Awake()
    {
        playerRigidbody = this.GetComponent<Rigidbody>();
    }

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void FixedUpdate()
    {
        run = canRun && Input.GetKey(runningKey);
        targetMovingSpeed = run ? speedRun : speedWalk;

        playerRigidbody.velocity = transform.rotation * new Vector3(Input.GetAxis("Horizontal"), playerRigidbody.velocity.y, Input.GetAxis("Vertical") * targetMovingSpeed);

        transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * (100f * Time.deltaTime), Space.Self);

    }
}
