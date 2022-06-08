using DungeonEscape.Abstracts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Concrates.Movement
{
    public class OnGroundChecker : MonoBehaviour,IOnGroundChecker
    {
        [SerializeField] Transform[] footTransforms;
        [SerializeField] LayerMask landLayerMask;
        float maxDistance = 0.3f;
        bool isground = false;
        public bool IsGround => isground;

        private void Update()
        {
            foreach (Transform transform in footTransforms)
            {
                CheckerIfFootsOnGround(transform);

                if (isground) break;
            }
        }

        void CheckerIfFootsOnGround(Transform footTransforms)
        {
            RaycastHit2D hit2D = Physics2D.Raycast(footTransforms.position, footTransforms.forward, maxDistance, landLayerMask);
            Debug.DrawRay(footTransforms.position, footTransforms.forward * maxDistance, Color.red);

            if (hit2D.collider != null)
            {
                isground = true;
            }
            else
            {
                isground = false;
            }
        }

    }
}
