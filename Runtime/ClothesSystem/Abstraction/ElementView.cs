using UnityEngine;

namespace Wearable
{
    public abstract class ElementView<T> : MonoBehaviour
    {
        [field: SerializeField] public SocketType SocketType { get; protected set; }

        public abstract void ClearSocket();
        public abstract void UpdateSocket(T config);
    }
}