using Unity.Entities;

public class HealthSystem : SystemBase
{
    protected override void OnUpdate()
    {
        Entities.ForEach((Entity entity, ref Health health, in Damage damage) =>
        {
            // Decrease the health of the entity based on the damage amount
            health.value -= damage.amount;

            // Destroy the entity if its health is below zero
            if (health.value <= 0)
            {
                EntityManager.DestroyEntity(entity);
            }
        }).Schedule();
    }
}
