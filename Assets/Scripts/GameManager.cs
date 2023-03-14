using UnityEngine;

public class GameManager : MonoBehaviourSingleton<GameManager>
{
    public uint score;
    [SerializeField] public Combo combo;
    /// <summary>
    /// Time in animation curve was lvl combo.
    /// Te float value is the thime to combo duration.
    /// </summary>
    [SerializeField] public AnimationCurve comboProgress;



    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(uint addScore)
    {
        score += addScore;
        combo.AddCombo();
    }
}
