using Leopotam.Ecs;
using UnityEngine;

public class MovementSystem : IEcsRunSystem {
    private EcsFilter<TransformComponent, MovementComponent> _filter;

    public void Run() {
        foreach (var i in _filter) {
            var transform = _filter.Get1(i).transform;
            var movement = _filter.Get2(i);

            transform.position += movement.direction * movement.speed * Time.deltaTime;
        }
    }
}