using AlienColour.Assets.Scripts.SelectionManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlienColour.Assets.Scripts.Tree
{
    public class ResponsiveSelectorTree : MonoBehaviour, ISelector
    {

        [SerializeField] private List<Transform> selectables;
        [SerializeField] private float treshold = 0.8f;

        private Transform _selection;
        public void Check(Ray ray)
        {

            _selection = null;
            var closest = 0f;
            for (int i = 0; i < selectables.Count; i++)
            {

                if (Physics.Raycast(ray,  20))
                {
                    
                        var vector1 = ray.direction;
                        var vector2 = selectables[i].transform.position - ray.origin;

                        var lookPercentage = Vector3.Dot(vector1.normalized, vector2.normalized);


                        if (lookPercentage < treshold && lookPercentage > closest)
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
