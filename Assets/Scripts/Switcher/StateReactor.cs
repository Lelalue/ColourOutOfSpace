using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace AlienColour.Assets.Scripts.Switcher
{
    
    public abstract class StateReactor : MonoBehaviour
    {
        public Switcher switcher;

        protected virtual void Awake()
        {
           
            switcher.Change += React;
        }

        public virtual void React()
        {
            Debug.Log(name + " state is " + switcher.state);
        }
    }
}