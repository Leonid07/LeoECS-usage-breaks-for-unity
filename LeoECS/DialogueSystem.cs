using Unity.Entities;

public class DialogueSystem : SystemBase
{
    protected override void OnUpdate()
    {
        Entities.ForEach((Entity entity, ref Dialogue dialogue, in Speaker speaker) =>
        {
            // Display the speaker's dialogue
            // You can use Unity's UI system or a custom dialogue system to display the dialogue
        }).Schedule();
    }
}
