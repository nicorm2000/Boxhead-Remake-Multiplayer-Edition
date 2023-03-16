using TMPro;
using UnityEngine;

public class UIDebug : MonoBehaviour
{
     [SerializeField] TextMeshProUGUI scoreDebugText;
     [SerializeField] TextMeshProUGUI comboDebugText;
     [SerializeField] TextMeshProUGUI timerDebugText; 

    void Update()
    {
        scoreDebugText.text = ScoreSystem.Get().score.ToString() + " is the score";
        comboDebugText.text = ScoreSystem.Get().combo.currentCombo.ToString() + " is the combo";
        timerDebugText.text = ScoreSystem.Get().combo.GetTimerValue().ToString() + " is the timeToEndCombo";
    }
}
