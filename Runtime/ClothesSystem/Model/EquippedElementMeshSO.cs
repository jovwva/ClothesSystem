using UnityEngine;

// Для предметов использующих Mesh (BodyPart, Clothing)
[CreateAssetMenu(fileName = "EquippedElementMesh_", menuName = "ScriptableObjects/ItemData/EquippedElementMesh", order = 2)]
public class EquippedElementMeshSO : EquippedElementSO
{
    [field: SerializeField] public Mesh Mesh { get; private set; }
    [field: SerializeField] public Material Material { get; private set; }
}
