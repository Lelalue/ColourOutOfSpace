using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace AlienColour.Assets.Scripts.UI_Inventory
{
    public class Graphics : Graphic
    {

        protected override void OnPopulateMesh(VertexHelper vh)
        {
            vh.Clear();
        }
    }
}