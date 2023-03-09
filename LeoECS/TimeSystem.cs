using Unity.Entities;

public class TimeSystem : SystemBase
{
    protected override void OnUpdate()
    {
        Entities.ForEach((Entity entity, ref Timer timer, in Delay delay) =>
        {
            // Update the timer based on the delay
            timer.time += Time.DeltaTime;

            // Destroy the entity if the timer is greater than the delay
            if (timer.time >= delay.duration)
            {
                EntityManager.DestroyEntity(entity);
            }
        }).Schedule();
    }
}
