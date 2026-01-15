using UnityEngine;

namespace ClothesSystem.Wearable
{
    public class SkinElementView : ElementView<EquippedElementMeshSO>
    {
        [SerializeField] private SkinnedMeshRenderer skinMR;
        
        private Mesh emptyMesh;
        private Material emptyMaterial;
        
        private void Awake()
        {
            emptyMesh = skinMR.sharedMesh;
            emptyMaterial = skinMR.material;
        }
    
        public override void ClearSocket()
        {
            skinMR.sharedMesh = emptyMesh;
            skinMR.material = emptyMaterial;
        }

        public override void UpdateSocket(EquippedElementMeshSO obj)
        {
            // Debug.Log($"Mesh: { obj.Mesh.name }, ItemEquipmentConfigSO: {obj.name}");
            skinMR.sharedMesh = obj.Mesh;
            skinMR.material   = obj.Material;
        }
    }
}

