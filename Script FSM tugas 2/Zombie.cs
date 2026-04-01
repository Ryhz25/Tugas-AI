using UnityEngine;

public class Zombie : Enemy
{
    public override void Attack()
    {
        Debug.Log("Zombie menyerang jarak dekat! Damage: " + damage);
    }
}