using UnityEngine;

public class GameManager : MonoBehaviour
{
    public CharacterData warriorData;
    public CharacterData mageData;
    public CharacterData archerData;

    void Start()
    {
        Warrior warrior = new GameObject("Warrior").AddComponent<Warrior>();
        warrior.data = warriorData;

        Mage mage = new GameObject("Mage").AddComponent<Mage>();
        mage.data = mageData;

        Archer archer = new GameObject("Archer").AddComponent<Archer>();
        archer.data = archerData;

        warrior.Attack();
        mage.Attack();
        archer.Attack();
    }
}