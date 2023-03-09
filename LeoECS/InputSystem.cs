using Leopotam.Ecs;
using UnityEngine;

public class InputSystem : IEcsRunSystem {
    private EcsFilter<InputComponent> _filter;

    public void Run() {
        foreach (var i in _filter) {
            var input = _filter.Get1(i);

            input.direction = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        }
    }
}