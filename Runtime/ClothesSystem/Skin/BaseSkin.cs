using UnityEngine;

namespace Wearable
{
    public class BaseSkin : ItemPresenter
    {
        [SerializeField] private SkinElementView elementView;
    
        public override void ClearItem()
        {
            elementView.ClearSocket();
        
            IsEmpty = true;
        }
    
        public override void SetItem(EquippedItemSO data)
        {
            if (data.Equips[0] is EquippedElementMeshSO meshConfig)
            {
                elementView.UpdateSocket(meshConfig);
            }
        
            IsEmpty = false;
        }
    }
}

