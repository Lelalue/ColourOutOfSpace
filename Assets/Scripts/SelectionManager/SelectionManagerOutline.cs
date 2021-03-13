using AlienColour.Assets.Scripts.Switcher;
using AlienColour.Assets.Scripts.UI_Inventory;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlienColour.Assets.Scripts.SelectionManager
{


    //https://www.youtube.com/watch?v=QDldZWvNK_E&list=PLKERDLXpXl_jmiWBfkcM4mSCa9MvdGpf9&index=22


    public class SelectionManagerOutline : MonoBehaviour
    {
        private IRayProvider _rayProvider;
        private ISelectionResponse _selectionResponse;
        private Transform _currentSelection;
        private ISelector _selector;




        private void Awake()
        {

            _rayProvider = GetComponent<IRayProvider>();
            _selector = GetComponent<ISelector>();
            _selectionResponse = GetComponent<ISelectionResponse>();


        }

        // Update is called once per frame
        void Update()
        {
            //deselection  response
            if ( _currentSelection != null)
            {

                _selectionResponse.OnDeselect(_currentSelection);

            }

            _selector.Check(_rayProvider.CreateRay());

            _currentSelection = _selector.GetSelection(); ;

            //selection response
            if ( _currentSelection != null)
            {
                //if object has prerequisite and is not complete, do nothing
                if (_currentSelection.GetComponent<Prerequisite>() && !_currentSelection.GetComponent<Prerequisite>().Complete)
                {

                    return;
                }



                _selectionResponse.OnSelect(_currentSelection);

            }
        }


    }
}