using UnityEngine;

namespace ClothesSystem.Wearable
{
    [CreateAssetMenu(fileName = "EquippedItem_", menuName = "ScriptableObjects/ItemData/EquippedItemSO", order = 3)]
    public class EquippedItemSO : ScriptableObject
    {
        [field: SerializeField] public ItemCategory Category { get; private set; }
        [field: SerializeField] public EquippedElementSO[] Equips { get; private set; }
    }

    public enum ItemCategory
    {
        BodyPart,    
        Attachment,  
        Clothing     
    }
}


