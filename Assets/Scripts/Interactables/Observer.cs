using AlienColour.Assets.Scripts.SelectionManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlienColour.Assets.Scripts.Interactables
{
    public class Observer : MonoBehaviour, ISelectionResponse
    {
        [SerializeField] public ObsCamera obsCamera;

        [HideInInspector] public static Observer obs;

  
        public void Start()
        {
            obs = this;
        }

        public void OnSelect(Transform selection)
        {
            GameObject item = Instantiate(selection.gameObject);
           // selection.GetComponent<Collider>().enabled = false;
            item.transform.SetParent(obsCamera.rig);
            item.transform.localPosition = Vector3.zero;
           
            obsCamera.model = item.transform;         
            obsCamera.gameObject.SetActive(true);
            
        }
       

        public void OnDeselect(Transform selection)
        {
            if (obsCamera.gameObject.activeInHierarchy) { 
            obsCamera.Close();

           // selection.GetComponent<Collider>().enabled = true;

            }
        }
    }
}