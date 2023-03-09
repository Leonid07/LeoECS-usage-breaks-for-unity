using Leopotam.Ecs;
using UnityEngine.UI;

public class ScoreSystem : IEcsRunSystem {
    private EcsFilter<ScoreComponent> _filter;
    private readonly Text _scoreText;

    public ScoreSystem(Text scoreText) {
        _scoreText = scoreText;
    }

    public void Run() {
        foreach (var i in _filter) {
            var score = _filter.Get1(i).value;

            _scoreText.text = $"Score: {score}";
        }
    }
}