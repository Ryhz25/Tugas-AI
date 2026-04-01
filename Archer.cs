using UnityEngine;

public class Archer : Character
{
    public override void Attack()
    {
        Debug.Log(data.characterName + " menyerang dengan panah! Damage: " + data.damage);
    }
}