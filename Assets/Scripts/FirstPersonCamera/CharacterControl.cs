using AlienColour.Assets.Scripts.Interactables;
using AlienColour.Assets.Scripts.SceneChanging;
using AlienColour.Assets.Scripts.Sound;
using AlienColour.Assets.Scripts.Switcher;
using AlienColour.Assets.Scripts.UI_Inventory;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace AlienColour.Assets.Scripts.FirstPersonCamera
{
    public class CharacterControl : MonoBehaviour
    {
        public CharacterController controller;
             
        private IDisplay display;
        
       // public AudioSource audiosrc;
       
        public float speed = 6.0F;
        public float gravity = -9.81f;

        public Transform groundCheck;
        public float groundDistance = 0.4F;
        public LayerMask groundMask;
        

        Vector3 velocity;
        bool isGrounded;
        bool cemetery = true;
        bool trees = true;
        bool grey = true;
        bool last = true;
        bool texttrigger = true;
        bool well = true;

       
        void Update()
        {
            
            display = transform.parent.GetComponentInChildren<IDisplay>();
            //audiosrc = GetComponent<AudioSource>();
            controller = GetComponent<CharacterController>();
            PlayerMovement();
           
            
        }


        private void PlayerMovement()
        {
           


            isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

            if ( isGrounded && velocity.y < 0)
            {
                velocity.y = -2f;
            }

            float vertical = Input.GetAxis("Vertical");
            float horizontal = Input.GetAxis("Horizontal");

            Vector3 move = transform.right * horizontal + transform.forward * vertical;

            controller.Move(move* speed * Time.deltaTime);

            velocity.y += gravity * Time.deltaTime;

            controller.Move(velocity* Time.deltaTime);

           /* if (vertical != 0) isMoving = true;
            else isMoving = false;

            if (isMoving)
            {
                audiosrc.Play();
            }
                
            else if (!isMoving) 
            {
                audiosrc.Stop();
            }*/
                

        }

        public Vector3 GetPosition()
        {
            return controller.transform.position;
        }

       

        public void OnTriggerEnter(Collider collider)
        {
            if (collider.gameObject.name == "texttrigger")
            {
                if (texttrigger == true)
                {
                    display.SetText("texttrigger");
                }
                texttrigger = false;
            }
            else if (collider.gameObject.name == "well")
            {
                if (well == true)
                {
                    display.SetText("well");
                }
                well = false;
            }
            else if (collider.gameObject.name == "changetrigger")
            {
                Loader.Load(Loader.Scene.Ende);
            }
            else if (collider.gameObject.name == "changecolor")
            {
                if (collider.gameObject.GetComponent<Prerequisite>() && !collider.gameObject.GetComponent<Prerequisite>().Complete)
                {
                    return;
                }
                Loader.Load(Loader.Scene.Bunt);
            }
            else if (collider.gameObject.name == "changegrey")
            {
                if (collider.gameObject.GetComponent<Prerequisite>() && !collider.gameObject.GetComponent<Prerequisite>().Complete)
                {
                    return;
                }
                Loader.Load(Loader.Scene.Grau);
            }
            else if (collider.gameObject.name == "cemetery")
            {
                if (collider.gameObject.GetComponent<Prerequisite>() && !collider.gameObject.GetComponent<Prerequisite>().Complete)
                {
                    return;
                }
                else if(cemetery == true)
                {
                    display.SetText("cemetery");
                }
                cemetery = false;
            }
            else if (collider.gameObject.name == "trees")
            {
                if (collider.gameObject.GetComponent<Prerequisite>() && !collider.gameObject.GetComponent<Prerequisite>().Complete)
                {
                    return;
                }
                else if (trees == true)
                {
                    display.SetText("trees");
                }
                trees = false;
            }
            else if (collider.gameObject.name == "grey")
            {
                if (collider.gameObject.GetComponent<Prerequisite>() && !collider.gameObject.GetComponent<Prerequisite>().Complete)
                {
                    return;
                }
                else if (grey == true)
                {
                    display.SetText("grey");
                }
                grey = false;
            }
            else if (collider.gameObject.name == "last")
            {
                if (collider.gameObject.GetComponent<Prerequisite>() && !collider.gameObject.GetComponent<Prerequisite>().Complete)
                {
                    return;
                }
                else if (last == true)
                {
                    display.SetText("last");
                }
                last = false;
            }
        }

       

    }
}