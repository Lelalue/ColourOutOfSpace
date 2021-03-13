using AlienColour.Assets.Scripts.Interactables;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlienColour.Assets.Scripts.FirstPersonCamera
{
    public class RotateWithCamera : MonoBehaviour
    {

        Vector2 mouseLook;
        Vector2 smoothV;
        public float sensitivity = 5.0f;
        public float smoothing = 2.0f;
        bool leftclick = false;
        GameObject character;

        void Start()
        {
            character = transform.parent.gameObject;
        }
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
                leftclick = true;
            else if (Input.GetMouseButtonUp(0))
                leftclick = false;
        }

        void LateUpdate()
        {   //wenn bild aufgepoppt keine rotation mehr
            if (ImageViewer.imV.ivCanvas.gameObject.activeInHierarchy|| Observer.obs.obsCamera.gameObject.activeInHierarchy)
               return;

            if(leftclick)
            Rotate();
        }


        private void Rotate()
        {
            var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

            md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
            smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
            smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);
            mouseLook += smoothV;
            //no spinning
            mouseLook.y = Mathf.Clamp(mouseLook.y, -90f, 90f);

            transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
            character.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, character.transform.up);
        }
    }
}