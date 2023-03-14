using TMPro;
using UnityEngine;

public class UIDebug : MonoBehaviour
{
     [SerializeField] TextMeshProUGUI scoreDebugText;
     [SerializeField] TextMeshProUGUI comboDebugText;
     [SerializeField] TextMeshProUGUI timerDebugText; 

    void Update()
    {
        scoreDebugText.text = GameManager.Get().score.ToString() + " is the score";
        comboDebugText.text = GameManager.Get().combo.currentCombo.ToString() + " is the combo";
        timerDebugText.text = GameManager.Get().combo.GetTimerValue().ToString() + " is the timeToEndCombo";
    }
}
