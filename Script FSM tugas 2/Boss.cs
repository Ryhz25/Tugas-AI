using UnityEngine;

public class Boss : Enemy
{
    public override void Attack()
    {
        Debug.Log("Boss menggunakan serangan spesial! Damage: " + damage * 2);
    }

    public override void TakeDamage(int amount)
    {
        // Boss lebih kuat (damage dikurangi)
        int reducedDamage = amount / 2;
        health -= reducedDamage;

        Debug.Log("Boss menerima damage (reduced): " + reducedDamage);

        if (health <= 0)
        {
            Die();
        }
    }
}