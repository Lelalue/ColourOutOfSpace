using AlienColour.Assets.Scripts.SelectionManager;
using AlienColour.Assets.Scripts.Sound;
using AlienColour.Assets.Scripts.Switcher;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlienColour.Assets.Animation.AnimationScript
{
    public class ThingsAnimation : MonoBehaviour, ISelectionResponse
    {
       


        public void OnSelect(Transform selection)
        {
            if (selection.GetComponent<Prerequisite>() && !selection.GetComponent<Prerequisite>().Complete)
                return;
            SoundManager.PlaySound(SoundManager.Sound.door);
            selection.GetComponent<Animator>().SetBool("Neu", true);
        }

        public void OnDeselect(Transform selection)
        {

            selection.GetComponent<Animator>().SetBool("Neu", false);
        }
    }
}