using AlienColour.Assets.Scripts.Switcher;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlienColour.Assets.Scripts.Reactors
{
    [RequireComponent(typeof(Renderer))]
    public class ColorReactor : StateReactor

    {
        public Material active;
        public Material inactive;
        Renderer rend;

        protected override void Awake()
        {
            base.Awake();
            rend = GetComponent<Renderer>();
            React();
        }

        public override void React()
        {
            if (switcher.state){
                rend.material = active;

            } else
            {
                rend.material = inactive;
            }
            

        }
    }
}