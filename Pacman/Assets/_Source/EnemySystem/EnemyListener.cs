using System;
using System.Collections.Generic;
using PlayerSystem.Movement;
using UnityEngine;

namespace EnemySystem
{
    public class EnemyListener : MonoBehaviour
    {
        private AEnemy _enemies;
        private PlayerMovement _enemyMovement;


        public void Construct(AEnemy enemies, PlayerMovement enemyMovement)
        {
            _enemies = enemies;
            _enemyMovement = enemyMovement;
        }

        private void FixedUpdate()
        {
            
                _enemyMovement.Move();
            
        }
    }
}
