using UnityEngine;

public enum CharacterType
{
    Warrior,
    Mage,
    Archer
}

[CreateAssetMenu(fileName = "CharacterData", menuName = "RPG/Character Data")]
public class CharacterData : ScriptableObject
{
    public string characterName;
    public CharacterType type;
    public int health;
    public int damage;
}