public class Combo
{
    public uint currentCombo = 1;
    Timer Timer;

    void LessCombo()
    {
        currentCombo--;
        ResetTimer();
    }
    public void AddCombo()
    {
        currentCombo++;
        ResetTimer();
    }
    void ResetTimer()
    {
        Timer.Start(GameManager.Get().comboProgress.Evaluate(currentCombo), LessCombo, 1, false);
    }

    void Update()
    {
        if (currentCombo>1)
        {
            Timer.Update();
        }
    }
    public float GetTimerValue()
    {
        return Timer.GetCurrentValue();
    }
}
