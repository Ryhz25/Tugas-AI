using UnityEngine;

public class Warrior : Character
{
    public override void Attack()
    {
        Debug.Log(data.characterName + " menyerang dengan pedang! Damage: " + data.damage);
    }
}