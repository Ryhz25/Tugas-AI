using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Enemy zombie = new GameObject("Zombie").AddComponent<Zombie>();
        Enemy turret = new GameObject("Turret").AddComponent<Turret>();
        Enemy boss = new GameObject("Boss").AddComponent<Boss>();

        zombie.Attack();
        turret.Attack();
        boss.Attack();

        zombie.TakeDamage(30);
        turret.TakeDamage(40);
        boss.TakeDamage(50);
    }
}