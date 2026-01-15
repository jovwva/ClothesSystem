using UnityEngine;

[CreateAssetMenu(fileName = "Item_", menuName = "ScriptableObjects/ItemData/ItemRoot", order = 1)]
public class ItemSO : ScriptableObject
{
    [SerializeField] private int ID;

    [field: SerializeField] public ItemType Type { get; private set; }
    [field: SerializeField] public EquippedItemSO EquippedItemSO { get; private set; }
}

public enum ItemType 
{
    Body_Armor,
    Head_Armor,
    Foot_Armor,
    Hands_Armor,
    Belt_Armor,
    Pants_Armor,
}