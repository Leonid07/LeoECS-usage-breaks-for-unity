using Leopotam.Ecs;
using UnityEngine;

public class CollisionSystem : IEcsRunSystem {
    private EcsFilter<TransformComponent, ColliderComponent> _filter;

    public void Run() {
        foreach (var i in _filter) {
            var transform = _filter.Get1(i).transform;
            var collider = _filter.Get2(i).collider;

            if (collider.bounds.Contains(transform.position)) {
                // Handle collision logic here
            }
        }
    }
}