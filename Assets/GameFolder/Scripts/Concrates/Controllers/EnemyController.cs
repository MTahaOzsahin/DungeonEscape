using DungeonEscape.Abstracts;
using DungeonEscape.Concrates.Animations;
using DungeonEscape.Concrates.Movement;
using DungeonEscape.Concrates.StateMachines;
using DungeonEscape.Concrates.StateMachines.EnemyStates;
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

        StateMachine _stateMachine;

        IEntityController _player;
        IHealth _health;
        [Header("Movements")]
        [SerializeField] float moveSpeed = 2f;
        [SerializeField] Transform[] patrols;
        [Header("Attack")]
        [SerializeField] float chaseDistance = 3f;
        [SerializeField] float attackDistance = 0.5f;
        private void Awake()
        {
            mover = new Mover(this,moveSpeed);
            myAnimation = new CharacterAnimations(GetComponent<Animator>());
            fliper = new Fliper(this);
            _health = GetComponent<IHealth>();
            _stateMachine = new StateMachine();

            _player = FindObjectOfType<PlayerController>();
        }
        private void Start()
        {
            Idle idle = new Idle(mover,myAnimation);
            Walk walk = new Walk(this, mover,myAnimation,fliper,patrols);
            ChasePlayer chasePlayer = new ChasePlayer(this,_player,mover,fliper,myAnimation);
            Attack attack = new Attack();
            TakeHit takeHit = new TakeHit(_health,myAnimation);
            Dead dead = new Dead(this,myAnimation);

            _stateMachine.AddTransition(idle, walk,() => !idle.IsIdle);
            _stateMachine.AddTransition(idle, chasePlayer, () => DistanceFromMeToPlayer() < chaseDistance);
            _stateMachine.AddTransition(walk, chasePlayer, () => DistanceFromMeToPlayer() < chaseDistance);
            _stateMachine.AddTransition(chasePlayer, attack, () => DistanceFromMeToPlayer() < attackDistance);

            _stateMachine.AddTransition(walk, idle, () => !walk.IsWalking);
            _stateMachine.AddTransition(chasePlayer, idle, () => DistanceFromMeToPlayer() > chaseDistance);
            _stateMachine.AddTransition(attack, chasePlayer, () => DistanceFromMeToPlayer() > attackDistance);

            _stateMachine.AddAnyState(dead, () => _health.IsDead);
            _stateMachine.AddAnyState(takeHit, () => takeHit.IsTakeHit);

            _stateMachine.AddTransition(takeHit, chasePlayer, () => takeHit.IsTakeHit == false);

            _stateMachine.SetState(idle);
        }

        private void Update()
        {
            _stateMachine.Tick();
        }
        private void OnDrawGizmos()
        {
            OnDrawGizmosSelected();
        }
        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawWireSphere(transform.position, chaseDistance);
        }
        float DistanceFromMeToPlayer()
        {
            return Vector2.Distance(transform.position, _player.transform.position);
        }
    }
}
