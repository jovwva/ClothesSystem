using System.Collections.Generic;
using UnityEngine;

namespace Wearable
{
    public class ItemCombinedPresenter<T, G> : ItemPresenter where T : ElementView<G>
    {
        [SerializeField] private T[] points;
        private Dictionary<SocketType, T> socketPoints;
    
        protected void Awake()
        {
            socketPoints = new();

            foreach (T point in points)
            {
                socketPoints[point.SocketType] = point;
            }
        }
    
        public override void SetItem(EquippedItemSO data)
        {
            foreach (EquippedElementSO equip in data.Equips)
            {
                if (equip is G prefConfig)
                {
                    if (socketPoints.ContainsKey(equip.SocketType))
                    {
                        socketPoints[equip.SocketType].UpdateSocket(prefConfig);
                    }
                    else
                    {
                        Debug.LogWarning("Type miss match");
                    }
                }
            }
        }

        public override void ClearItem()
        {
            foreach (T point in points)
            {
                point.ClearSocket();
            }
        
            IsEmpty = true;
        }
    }
}