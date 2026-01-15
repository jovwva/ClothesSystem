using UnityEngine;

namespace Wearable
{
    public class SocketElementView : ElementView<EquippedElementPrefabSO>
    {
        private GameObject soсketView;
    
        public override void ClearSocket()
        {
            if (soсketView == null) return;
        
            Destroy(soсketView);
        }
        public override void UpdateSocket(EquippedElementPrefabSO config)
        {
            ClearSocket();
            soсketView = Instantiate(config.Prefab, transform);
    
            soсketView.transform.localPosition = config.Pos;
            soсketView.transform.localScale = Vector3.one;
        
            // Debug.Log($"UpdateSocket {soсketView.name}");
        }
    }
}

