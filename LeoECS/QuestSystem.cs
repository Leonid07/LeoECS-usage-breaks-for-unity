using Unity.Entities;

public class QuestSystem : SystemBase
{
    protected override void OnUpdate()
    {
        Entities.ForEach((Entity entity, ref Quest quest, in Objective objective) =>
        {
            // Update the quest progress based on the objective
            quest.progress += objective.progress;

            // Mark the objective as completed
            EntityManager.RemoveComponent<Objective>(entity);
        }).Schedule();
    }
}
