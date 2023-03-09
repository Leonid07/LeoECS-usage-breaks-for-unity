using Unity.Entities;

public class InventorySystem : SystemBase
{
    protected override void OnUpdate()
    {
        Entities.ForEach((Entity entity, ref Inventory inventory, in Item item) =>
        {
            // Add the item to the inventory
            inventory.items.Add(item);

            // Remove the item from the entity
            EntityManager.RemoveComponent<Item>(entity);
        }).Schedule();
    }
}
