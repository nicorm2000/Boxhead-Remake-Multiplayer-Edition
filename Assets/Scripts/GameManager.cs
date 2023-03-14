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

    [SerializeField] private float maxCombo;



    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        combo = new Combo();
    }

    // Update is called once per frame
    void Update()
    {
        combo.Update();        
    }

    public void AddScore(uint addScore)
    {
        score += addScore* combo.currentCombo;

        if (combo.currentCombo< comboProgress.keys[^1].time)
        {
            combo.AddCombo();
        }
    }
}
