using UnityEngine;
using System.Collections;

namespace AlienColour.Assets.Scripts.SelectionManager
{
    public class MouseScreenRayProvider : MonoBehaviour, IRayProvider
    {

        public Ray CreateRay()
        {
            //create ray 
            return Camera.main.ScreenPointToRay(Input.mousePosition);
        }
    }
}