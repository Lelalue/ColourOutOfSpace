using AlienColour.Assets.Scripts.Reactors;
using AlienColour.Assets.Scripts.SelectionManager;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlienColour.Assets.Scripts.Switcher
{
    public class Switcher : MonoBehaviour, ISelectionResponse
    {
        public bool state;

        //event setup
        public delegate void OnStateChange();
        public event OnStateChange Change;


        public void OnSelect(Transform selection)
        {
            state = true;
            Change?.Invoke();
        }

        public void OnDeselect(Transform selection)
        {
            state = false;
            Change?.Invoke();
        }
    }
}