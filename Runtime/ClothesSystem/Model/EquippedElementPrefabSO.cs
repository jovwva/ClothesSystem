using UnityEngine;

// Для предметов использующих GameObject (Attachment)
[CreateAssetMenu(fileName = "EquippedElementPrefab_", menuName = "ScriptableObjects/ItemData/EquippedElementPrefabSO", order = 3)]
public class EquippedElementPrefabSO : EquippedElementSO
{
    [field: SerializeField] public GameObject Prefab { get; private set; }
    [field: SerializeField] public Vector3    Pos { get; private set; }
}