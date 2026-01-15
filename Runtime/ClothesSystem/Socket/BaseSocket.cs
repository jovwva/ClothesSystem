using UnityEngine;

namespace  Wearable
{
    public class BaseSocket : ItemPresenter
    {
        [SerializeField] private SocketElementView elementView;
        // [SerializeField] private Transform emptyRoot;
    
        public override void ClearItem()
        {
            elementView.ClearSocket();
            // emptyRoot.gameObject.SetActive(true);
        
            IsEmpty = true;
        }

        public override void SetItem(EquippedItemSO data)
        {
            if (!IsEmpty) elementView.ClearSocket();
        
            if (data.Equips[0] is EquippedElementPrefabSO prefConfig)
            {
                // emptyRoot.gameObject.SetActive(false); 
                elementView.UpdateSocket(prefConfig);
            }
        
            IsEmpty = false;
        }
    }
}

