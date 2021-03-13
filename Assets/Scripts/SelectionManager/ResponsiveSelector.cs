using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace AlienColour.Assets.Scripts.SelectionManager
{
    public class ResponsiveSelector : MonoBehaviour, ISelector
    {

        [SerializeField] private List<Transform> selectables;
        [SerializeField] private float treshold = 0.98f;

        private Transform _selection;
        public void Check(Ray ray)
        {

            _selection = null;
            var closest = 0f;

            for (int i = 0; i < selectables.Count; i++)
            {
                //entfernung zum item
                if (Physics.Raycast(ray, 4))
                {
                    var vector1 = ray.direction;
                    var vector2 = selectables[i].transform.position - ray.origin;
                    //wie nah muss maus am item sein? -> 
                    var lookPercentage = Vector3.Dot(vector1.normalized, vector2.normalized);


                    if (lookPercentage > treshold && lookPercentage > closest)
                    {

                        closest = lookPercentage;
                        _selection = selectables[i].transform;
                    }
                }
            }

        }

        public Transform GetSelection()
        {
            return _selection;
        }

        public List<Transform> GetList()
        {
            return selectables;
        }
    }
}