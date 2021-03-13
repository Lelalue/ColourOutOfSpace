using AlienColour.Assets.Scripts.SelectionManager;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AlienColour.Assets.Scripts.UI_Inventory
{
    public class Collector : MonoBehaviour, ISelectionResponse 
    {

        private List<IInventoryItem> itemList = new List<IInventoryItem>();
        public Inventory inventory;
        private const int SLOTS = 6;
        [HideInInspector] IInventoryItem item;
        public IDisplay display;

        public event EventHandler<InventoryEventHandler> ItemAdded;

        public void Awake()
        {
            display = transform.parent.GetComponentInChildren<IDisplay>();
        }

        public void OnSelect(Transform selection)
        {
            if (itemList.Count < SLOTS)
            {
                Collider collider = selection.GetComponent<Collider>();
                if (collider.enabled)
                {
                    collider.enabled = false;
                    item = selection.GetComponent<IInventoryItem>();
                    selection.gameObject.SetActive(false);

                    itemList.Add(item); 
                    item.OnPickUp();
             
                    ItemAdded?.Invoke(this, new InventoryEventHandler(item));
                    
                }
            }
        }

        public void OnDeselect(Transform selection)
        { 
            
            
        }
        

        public List<IInventoryItem> GetItemList()
        {
            return itemList;
        }
        
    }
}