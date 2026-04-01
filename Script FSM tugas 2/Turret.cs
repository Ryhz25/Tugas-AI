using UnityEngine;

public class Turret : Enemy
{
    public override void Attack()
    {
        Debug.Log("Turret menembak dari jarak jauh! Damage: " + damage);
    }
}