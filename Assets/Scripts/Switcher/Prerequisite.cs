
using AlienColour.Assets.Scripts.UI_Inventory;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlienColour.Assets.Scripts.Switcher
{
    public class Prerequisite : MonoBehaviour
    {
        public Switcher watch;
        public bool requireItem;
        public bool requireItem2;
        public IInventoryItem IrequiredItem;
        public Transform requiredItem;
        public Transform requiredItem2;
        public Collector checkColl;


        public bool Complete
        {
            get
            {
                if (!requireItem && !requireItem2)
                {
                    return watch.state;
                }
                else if (requireItem && !requiredItem2)
                {

                    return checkColl.GetItemList().Contains(requiredItem.GetComponent<IInventoryItem>());
                }
                else if (requireItem2 && !requireItem)
                {
                    return checkColl.GetItemList().Contains(requiredItem2.GetComponent<IInventoryItem>());
                }
                else if(requireItem && requireItem2)
                {
                    return checkColl.GetItemList().Contains(requiredItem2.GetComponent<IInventoryItem>()) && checkColl.GetItemList().Contains(requiredItem.GetComponent<IInventoryItem>());
                }
                else
                {
                    return false;
                }
            }


           

        }

    }
}