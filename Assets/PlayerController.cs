using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float lastAClickTime;
    float lastDClickTime;
    // Start is called before the first frame update
    void Start()
    {
        this.lastAClickTime = Time.time;
        this.lastDClickTime = Time.time;
    }


    public void LButtonDown()
    {
        this.GetComponent<Transform>().Translate(-3.0f, 0, 0);
    }

    public void RButtonDown()
    {
        this.GetComponent<Transform>().position += new Vector3(3.0f, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (DashCoolTime.dashCoolTime > 0) DashCoolTime.dashCoolTime -= Time.deltaTime;
        if (DashCoolTime.dashCoolTime < 0) DashCoolTime.dashCoolTime = 0.0f;

        if (Input.GetKeyDown(KeyCode.A))
        {
            if (Time.time - this.lastAClickTime <= 0.25f && DashCoolTime.dashCoolTime <= 0.0f && this.GetComponent<Transform>().position.x >= -6) 
            { 
                for (int i = 0; i < 20; i++) gameObject.transform.Translate(-0.1f, 0, 0);
                DashCoolTime.dashCoolTime = 1.0f;
            }
            this.lastAClickTime = Time.time;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (Time.time - this.lastDClickTime <= 0.25f && DashCoolTime.dashCoolTime <= 0.0f && this.GetComponent<Transform>().position.x <= 6)
            {
                for (int i = 0; i < 20; i++) gameObject.transform.Translate(0.1f, 0, 0);
                DashCoolTime.dashCoolTime = 1.0f;
            }
            this.lastDClickTime = Time.time;
        }
        if (Input.GetKey(KeyCode.A) && this.GetComponent<Transform>().position.x >= -8) this.GetComponent<Transform>().Translate(-0.1f, 0, 0);
        if (Input.GetKey(KeyCode.D) && this.GetComponent<Transform>().position.x <= 8) this.GetComponent<Transform>().position += new Vector3(0.1f, 0, 0);
    }
}
