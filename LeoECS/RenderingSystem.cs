using Unity.Entities;
using Unity.Transforms;
using Unity.Rendering;

public class RenderingSystem : SystemBase
{
    protected override void OnUpdate()
    {
        Entities.ForEach((Entity entity, in MeshRenderer meshRenderer, in Material material, in Translation translation) =>
        {
            // Create an instance of the mesh renderer
            var renderer = EntityManager.GetSharedComponentData(meshRenderer);

            // Create a new material instance
            var materialInstance = EntityManager.GetSharedComponentData(material);
            materialInstance.material = new Material(materialInstance.material);

            // Set the position of the renderer
            renderer.transformMatrix = Matrix4x4.Translate(translation.Value);

            // Add the renderer to the entity
            EntityManager.AddSharedComponentData(entity, renderer);
            EntityManager.AddSharedComponentData(entity, materialInstance);
        }).Schedule();
    }
}