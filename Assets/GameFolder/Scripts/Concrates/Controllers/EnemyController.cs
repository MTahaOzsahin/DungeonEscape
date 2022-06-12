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

        [SerializeField] float moveSpeed = 2f;
        [SerializeField] float chaseDistance = 3f;
        [SerializeField] float attackDistance = 0.5f;
        [SerializeField] Transform[] patrols;
        [SerializeField] bool isTakeHit = false;
        private void Awake()
        {
            mover = new Mover(this,moveSpeed);
            myAnimation = new CharacterAnimations(GetComponent<Animator>());
            fliper = new Fliper(this);
            _health = GetComponent<IHealth>();
            _stateMachine = new StateMachine();

            _player = FindObjectOfType<PlayerController>();
        }
        private void OnEnable()
        {
            _health.OnHealthChange += HandleHealthChange;   
        }
        private void OnDisable()
        {
            _health.OnHealthChange -= HandleHealthChange;
        }
        private void Start()
        {
            Idle idle = new Idle(this,mover,myAnimation,fliper);
            Walk walk = new Walk(this, mover,myAnimation,patrols);
            ChasePlayer chasePlayer = new ChasePlayer(this,_player,mover,fliper,myAnimation);
            Attack attack = new Attack();
            TakeHit takeHit = new TakeHit();
            Dead dead = new Dead();

            _stateMachine.AddTransition(idle, walk,() => !idle.IsIdle);
            _stateMachine.AddTransition(idle, chasePlayer, () => DistanceFromMeToPlayer() < chaseDistance);
            _stateMachine.AddTransition(walk, chasePlayer, () => DistanceFromMeToPlayer() < chaseDistance);
            _stateMachine.AddTransition(chasePlayer, attack, () => DistanceFromMeToPlayer() < attackDistance);

            _stateMachine.AddTransition(walk, idle, () => !walk.IsWalking);
            _stateMachine.AddTransition(chasePlayer, idle, () => DistanceFromMeToPlayer() > chaseDistance);
            _stateMachine.AddTransition(attack, chasePlayer, () => DistanceFromMeToPlayer() > attackDistance);

            _stateMachine.AddAnyState(dead, () => _health.CurrentHealth < 1);
            _stateMachine.AddAnyState(takeHit, () => isTakeHit);

            _stateMachine.AddTransition(takeHit, chasePlayer, () => isTakeHit == false);

            _stateMachine.SetState(idle);
        }

        private void Update()
        {
            _stateMachine.Tick();
        }
        void HandleHealthChange()
        {
            isTakeHit = true;
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
