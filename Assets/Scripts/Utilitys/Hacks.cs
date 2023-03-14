using UnityEngine;

public class Hacks : MonoBehaviour
{
    [SerializeField] private uint scoreToAdd;

    public void ResetScore()
    {
        GameManager.Get().score = 0;
    }
    public void AddScore()
    {
        GameManager.Get().AddScore(scoreToAdd);
    }
}
