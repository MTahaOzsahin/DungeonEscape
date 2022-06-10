using DungeonEscape.Abstracts;
using DungeonEscape.Concrates.Animations;
using DungeonEscape.Concrates.Movement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Concrates.Controllers
{
    public class EnemyController : MonoBehaviour ,IEntityController
    {
        IMover mover;
        IMyAnimation myAnimation;
        IFliper fliper;
        IOnGroundChecker onGroundChecker;

        [SerializeField] float moveSpeed = 2f;
        private void Awake()
        {
            mover = new Mover(this,moveSpeed);
            myAnimation = new CharacterAnimations(GetComponent<Animator>());
            fliper = new Fliper(this);
            onGroundChecker = GetComponent<IOnGroundChecker>();
        }
    }
}
