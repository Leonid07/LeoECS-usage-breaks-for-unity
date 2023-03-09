using Leopotam.Ecs;
using UnityEngine;

public class AnimationSystem : IEcsRunSystem {
    private EcsFilter<TransformComponent, MovementComponent> _filter;

    public void Run() {
        foreach (var i in _filter) {
            var transform = _filter.Get1(i).transform;
            var movement = _filter.Get2(i);

            if (movement.direction.magnitude > 0f) {
                // Play walking animation
            } else {
                // Play idle animation
            }
        }
    }
}