using UnityEngine;
using System.Collections;

namespace AlienColour.Assets.Scripts.UI_Inventory
{
    public interface IInventoryItem 
    {

      
        string Name { get; }
       Sprite Image { get; }


       void OnPickUp();


    }
}