using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public int health = 100;
    public int damage = 10;

    public virtual void Attack()
    {
        Debug.Log("Enemy attacks!");
    }

    public virtual void TakeDamage(int amount)
    {
        health -= amount;
        Debug.Log(gameObject.name + " menerima damage: " + amount);

        if (health <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        Debug.Log(gameObject.name + " mati!");
        Destroy(gameObject);
    }
}