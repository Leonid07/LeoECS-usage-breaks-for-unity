using Unity.Entities;

public class StateMachineSystem : SystemBase
{
    protected override void OnUpdate()
    {
        Entities.ForEach((Entity entity, ref State state, in Transition transition) =>
        {
            // Change the entity's state based on the transition conditions
        }).Schedule();
    }
}
