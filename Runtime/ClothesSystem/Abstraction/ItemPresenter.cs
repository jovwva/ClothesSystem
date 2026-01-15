using UnityEngine;

namespace Wearable
{
    public abstract class ItemPresenter : MonoBehaviour
    {
        public bool IsEmpty { get; protected set; }
        [field: SerializeField] public ItemType ItemType { get; protected set; }
    
        public abstract void SetItem(EquippedItemSO data);
        public abstract void ClearItem();
    }
}