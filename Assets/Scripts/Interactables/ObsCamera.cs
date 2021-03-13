using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlienColour.Assets.Scripts.Interactables
{

    //https://www.youtube.com/watch?v=JuE5RlBhaMU


    public class ObsCamera : MonoBehaviour
    {
        [HideInInspector]
        public Transform model;

        public Transform rig;

        Quaternion modelRot;
        Quaternion rigRot;
        public float sensitivity = 3.0f;
        

        public void Start()
        {
            gameObject.SetActive(false);
        }

        private void Update()
        {
            if ( (Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0))
            {
                if (model == null)
                    return;

                modelRot = model.rotation;
                rigRot = rig.rotation;
                Rotate();
                Debug.Log("test , bin ich weg?");
            }
           
        }

        private void Rotate()
        {
            float yRot = Input.GetAxis("Mouse X") * sensitivity;
            float xRot = Input.GetAxis("Mouse Y") * sensitivity;

            modelRot *= Quaternion.Euler(0f, -yRot, 0f);
            rigRot *= Quaternion.Euler(xRot, 0f, 0f);

            rigRot = ClampRotationAroundXAxis(rigRot);

            model.rotation = modelRot;
            rig.rotation = rigRot;
           
        }

        private Quaternion ClampRotationAroundXAxis(Quaternion q)
        {
            q.x /= q.w;
            q.y /= q.w;
            q.z /= q.w;
            q.w /= 1.0f;

            float angleX = 2.0f * Mathf.Rad2Deg * Mathf.Rad2Deg * Mathf.Atan(q.x);
            angleX = Mathf.Clamp(angleX, -80f, 80);

            q.x = Mathf.Tan(0.5f * Mathf.Deg2Rad * angleX);

            return q;

        }

        public void Close()
        {
            Destroy(model.gameObject);
            rig.rotation = Quaternion.identity;
            gameObject.SetActive(false);
        }

    }
}