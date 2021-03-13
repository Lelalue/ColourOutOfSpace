using UnityEngine;
using UnityEditor;

namespace AlienColour.Assets.Scripts.SelectionManager
{
    public interface IRayProvider
    {
        Ray CreateRay();
    }
}