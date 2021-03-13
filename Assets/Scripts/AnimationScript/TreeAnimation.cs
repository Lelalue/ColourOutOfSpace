using UnityEngine;
using System.Collections;
using AlienColour.Assets.Scripts.SelectionManager;
using System.Collections.Generic;
using AlienColour.Assets.Scripts.Tree;

namespace AlienColour.Assets.Animation.AnimationScript
{
    public class TreeAnimation : MonoBehaviour, ISelectionResponse
    {
      
        private List<Transform> trees;
        [SerializeField] public ResponsiveSelectorTree selector;

        public void Start()
        {
            trees = selector.GetList();
           /* if (trees.Count >= 1)
            {
                for (int i = 0; i < trees.Count; i++)
                {
                    treeAnimators.Add(trees[i].GetComponent<Animator>());
                    treeAnimators[i].enabled = false;
                }
            }
            else return;*/
        }


        public void OnSelect(Transform selection)
        {
            selection.GetComponent<Animator>().enabled= true;
            /* foreach (Transform t in trees)
             {
                 t.GetComponent<Animator>().SetBool("Pulse", true);
                 Debug.Log("FALSE");
             }*/
        }

        public void OnDeselect(Transform selection)
        {
            /* foreach (Transform t in trees)
             {
                 t.GetComponent<Animator>().SetBool("Pulse", false);
                 Debug.Log("TRUE");
             }*/
           selection.GetComponent<Animator>().enabled= false;
        }
    }  
}