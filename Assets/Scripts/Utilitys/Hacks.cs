using UnityEngine;

public class Hacks : MonoBehaviour
{
    [SerializeField] private uint scoreToAdd;

    void ResetScore()
    {
        GameManager.Get().score = 0;
    }
    void AddScore()
    {
        GameManager.Get().AddScore(scoreToAdd);
    }
}
