using UnityEngine;

public class GameLogicBehavior : MonoBehaviour
{
#pragma warning disable CS0649

    [SerializeField] private StarBehaviour[] starBehaviours_;
    [SerializeField] private IBallBehaviour ballBehaviour_;
    [SerializeField] private GoalBehaviour goalBehaviour_;
    [SerializeField] private PlatformBehaviour platformBehaviour_;
    
    [SerializeField] private string nextLevel_;
    
#pragma warning restore CS0649

    private GameLogic gameLogic_;
    
    private void Start()
    {
        var sceneLoader = new SceneLoader(nextLevel_);
        gameLogic_ = new GameLogic(starBehaviours_, goalBehaviour_, ballBehaviour_, platformBehaviour_,
            sceneLoader);
    }
}