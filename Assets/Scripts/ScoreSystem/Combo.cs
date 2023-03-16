public class Combo
{
    public uint currentCombo = 1;
    Timer Timer;

    public Combo()
    {
        Timer = new Timer();
    }

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
        Timer.Pause();
        Timer.Start(ScoreSystem.Get().comboProgress.Evaluate(currentCombo), LessCombo, 1, false);
    }

    public void Update()
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
