using Unity.Entities;
using Unity.Physics;

public class PhysicsSystem : SystemBase
{
    private BuildPhysicsWorld _buildPhysicsWorldSystem;

    protected override void OnCreate()
    {
        _buildPhysicsWorldSystem = World.GetOrCreateSystem<BuildPhysicsWorld>();
    }

    protected override void OnUpdate()
    {
        // Get the physics world
        var physicsWorld = _buildPhysicsWorldSystem.PhysicsWorld;

        // Update the physics world
        SimulationCallbacks.Callback cb = (ref PhysicsWorld world, ref SimulationCallbacks.CallbackContext context) =>
        {
            // Perform physics interactions between entities
            // You can use the Rigidbody and Collider components to perform physics calculations
        };
        SimulationCallbacks.ScheduleCallback(physicsWorld, cb).Complete();
    }
}
