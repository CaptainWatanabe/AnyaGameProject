using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacked : CharacterState
{
    public PlayerAttacked(PlayerController player) : base(player) { }

    float timer = 0;

    public override void EnterState()
    {
        _player.invulnerableCount = 0;
        _player.isInvulnerable = true;
        _player.isGetHitByEnemy = true;
    }

    public override void Tick()
    {

        if(timer < 1)
        {
            timer += Time.deltaTime;
        }else
        {
            timer = 1;
            _player.SetState(new PlayerLocomotion(_player));
        }    
    }

    public override void ExitState()
    {
        _player.isGetHitByEnemy = false;
    }
}
