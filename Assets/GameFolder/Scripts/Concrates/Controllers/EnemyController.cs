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
        StateMachine _stateMachine;
        IEntityController _player;

        [Header("Movements")]
        [SerializeField] float moveSpeed = 2f;
        [SerializeField] Transform[] patrols;
        [Header("Attack")]
        [SerializeField] float maxAttackTime = 2f;
        [SerializeField] float chaseDistance = 3f;
        [SerializeField] float attackDistance = 0.5f;
        private void Awake()
        {
            _stateMachine = new StateMachine();
            _player = FindObjectOfType<PlayerController>();
        }
        private void Start()
        {
            IMover mover = new Mover(this, moveSpeed);
            IMyAnimation myAnimation = new CharacterAnimations(GetComponent<Animator>());
            IFliper fliper = new Fliper(this);
            IAttacker attacker = GetComponent<IAttacker>();
            IHealth health = GetComponent<IHealth>();

            Idle idle = new Idle(mover,myAnimation);
            Walk walk = new Walk(this, mover,myAnimation,fliper,patrols);
            ChasePlayer chasePlayer = new ChasePlayer(this,mover,fliper,myAnimation,IsPlayerRightSide);
            Attack attack = new Attack(_player.transform.GetComponent<IHealth>(),fliper,myAnimation,attacker,maxAttackTime, IsPlayerRightSide);
            TakeHit takeHit = new TakeHit(health,myAnimation);
            Dead dead = new Dead(this,myAnimation);

            _stateMachine.AddTransition(idle, walk,() => !idle.IsIdle);
            _stateMachine.AddTransition(idle, chasePlayer, () => DistanceFromMeToPlayer() < chaseDistance);
            _stateMachine.AddTransition(walk, chasePlayer, () => DistanceFromMeToPlayer() < chaseDistance);
            _stateMachine.AddTransition(chasePlayer, attack, () => DistanceFromMeToPlayer() < attackDistance);

            _stateMachine.AddTransition(walk, idle, () => !walk.IsWalking);
            _stateMachine.AddTransition(chasePlayer, idle, () => DistanceFromMeToPlayer() > chaseDistance);
            _stateMachine.AddTransition(attack, chasePlayer, () => DistanceFromMeToPlayer() > attackDistance);

            _stateMachine.AddAnyState(dead, () => health.IsDead);
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
        bool IsPlayerRightSide()
        {
            Vector3 result = _player.transform.position - this.transform.position;
            return result.x > 0f ? true : false;
        }
    }
}
