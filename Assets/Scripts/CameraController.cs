using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    
        public float m_speed = 20.0f;

    void Update()
    {
        //CAMERA MOVEMENT CONTROLS (RELEVANT TO CAMERA ANGLE)

        Vector3 move = new Vector3(0, 0, 0);

        //BASIC

        //FORWARD
        if (Input.GetKey(KeyCode.W) && !((Input.GetKey(KeyCode.Q)) || (Input.GetKey(KeyCode.E)) || (Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.D))))
            move = new Vector3(0, 0, 1) * Time.deltaTime * m_speed;

        //BACK
        if (Input.GetKey(KeyCode.S) && !((Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.D))))
            move = new Vector3(0, 0, -1) * Time.deltaTime * m_speed;

        //LEFT
        if ((Input.GetKey(KeyCode.A)) && !((Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.S)) || (Input.GetKey(KeyCode.Q)) || (Input.GetKey(KeyCode.E))))
            move = new Vector3(-1, 0, 0) * Time.deltaTime * m_speed;

        //RIGHT
        if ((Input.GetKey(KeyCode.D)) && !((Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.S)) || (Input.GetKey(KeyCode.E)) || (Input.GetKey(KeyCode.Q))))
            move = new Vector3(1, 0, 0) * Time.deltaTime * m_speed;

        //UP
        if (Input.GetKey(KeyCode.Q) && !((Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.S)) || (Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.D))))
            move = new Vector3(0, 1, 0) * Time.deltaTime * m_speed;

        //DOWN
        if (Input.GetKey(KeyCode.E) && !((Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.S)) || (Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.D))))
            move = new Vector3(0, -1, 0) * Time.deltaTime * m_speed;


        //------------------------------------------------------------------

        //VARIANTS

        //FORWARD VARIANTS

        //FORWARD UP
        if ((Input.GetKey(KeyCode.Q)) && (Input.GetKey(KeyCode.W)))
        {
            move = new Vector3(0, 1, 1) * Time.deltaTime * m_speed;
        }

        //FORWARD DOWN
        if ((Input.GetKey(KeyCode.E)) && (Input.GetKey(KeyCode.W)))
        {
            move = new Vector3(0, -1, 1) * Time.deltaTime * m_speed;
        }

        //FORWARD LEFT
        if ((Input.GetKey(KeyCode.A)) && (Input.GetKey(KeyCode.W)))
        {
            move = new Vector3(-1, 0, 1) * Time.deltaTime * m_speed;
        }

        //FORWARD RIGHT
        if ((Input.GetKey(KeyCode.D)) && (Input.GetKey(KeyCode.W)))
        {
            move = new Vector3(1, 0, 1) * Time.deltaTime * m_speed;
        }

        //------------------------------------------------------------------

        //BACK VARIANTS

        //BACK UP
        if ((Input.GetKey(KeyCode.Q)) && (Input.GetKey(KeyCode.S)))
        {
            move = new Vector3(0, 1, -1) * Time.deltaTime * m_speed;
        }

        //BACK DOWN
        if ((Input.GetKey(KeyCode.E)) && (Input.GetKey(KeyCode.S)))
        {
            move = new Vector3(0, -1, -1) * Time.deltaTime * m_speed;
        }

        //BACK LEFT
        if ((Input.GetKey(KeyCode.A)) && (Input.GetKey(KeyCode.S)))
        {
            move = new Vector3(-1, 0, -1) * Time.deltaTime * m_speed;
        }

        //BACK RIGHT
        if ((Input.GetKey(KeyCode.D)) && (Input.GetKey(KeyCode.S)))
        {
            move = new Vector3(1, 0, -1) * Time.deltaTime * m_speed;
        }

        //------------------------------------------------------------------

        //UP & DOWN VARIANTS

        //UP LEFT
        if ((Input.GetKey(KeyCode.A)) && (Input.GetKey(KeyCode.Q)))
        {
            move = new Vector3(-1, 1, 0) * Time.deltaTime * m_speed;
        }

        //UP RIGHT
        if ((Input.GetKey(KeyCode.D)) && (Input.GetKey(KeyCode.Q)))
        {
            move = new Vector3(1, 1, 0) * Time.deltaTime * m_speed;
        }


        transform.Translate(move);

    }
}

