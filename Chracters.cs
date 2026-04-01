using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public CharacterData data;

    public virtual void Attack()
    {
        Debug.Log(data.characterName + " attacks!");
    }
}