using UnityEngine;

public class Hacks : MonoBehaviour
{
    [SerializeField] private uint scoreToAdd;

    public void ResetScore()
    {
        ScoreSystem.Get().score = 0;
    }
    public void AddScore()
    {
        ScoreSystem.Get().AddScore(scoreToAdd);
    }
}
