using UnityEngine;
using System.Collections;
using System;

namespace AlienColour.Assets.Scripts.UI_Inventory
{
    public class InventoryEventHandler : EventArgs
    {

        public InventoryEventHandler(IInventoryItem item)
        {
            Item = item;
        }

        public IInventoryItem Item;
    }
}