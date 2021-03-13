using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace AlienColour.Assets.Scripts.SelectionManager
{
    public interface ISelector
    {

        void Check(Ray ray);

        Transform GetSelection();

        List<Transform> GetList();

    }
}