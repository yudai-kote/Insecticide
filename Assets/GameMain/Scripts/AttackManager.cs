﻿using UnityEngine;
using System.Collections;

/// <summary>
/// 攻撃処理をするクラス
/// </summary>
public class AttackManager : MonoBehaviour
{
    [SerializeField]
    PlayerController player;
    [SerializeField]
    WeponController weponcontroller;

    void Start()
    {

    }

    void Update()
    {
        if (player.is_attack)
        {
            var hitobject = weponcontroller.hitobject;
            if (hitobject != null)
            {
                var enemy = hitobject.GetComponent<Enemy>();
                enemy.hit(player.attackPower());
            }
        }

    }
}
