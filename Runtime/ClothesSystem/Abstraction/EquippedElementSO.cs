using UnityEngine;

public abstract class EquippedElementSO : ScriptableObject
{
    [field: SerializeField] public SocketType SocketType { get; private set; }
}

public enum SocketType
{
    Body,
    Head,
    Foot_L,
    Foot_R,
    Foot,
    Hand_L,
    Hand_R,
    Belt,
    Pants,
}