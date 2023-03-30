
public class Timer
{
    private bool Enabled = false;

    private float initialTime = 0;

    private float currentTime = 0;

    private int currentLoop = 1;

    public System.Action onEndTimer;

    private void Start(float initialTime, System.Action onEndTimer)
    {
        if (Enabled) return;
        Resume();
        this.initialTime = initialTime;
        currentTime = initialTime;
        this.onEndTimer = onEndTimer;
    }
    private void Start(float initialTime, System.Action onEndTimer, int loops)
    {
        if (Enabled) return;
        Start(initialTime, onEndTimer);
        currentLoop = loops;
    }

    /// <summary>
    /// call Action first call start.
    /// </summary>
    public void Start(float initialTime, System.Action onEndTimer, int loops, bool firstCall)
    {
        if (Enabled) return;
        Start(initialTime, onEndTimer,loops);
        if (firstCall)
            onEndTimer?.Invoke();
    }

    public void Pause()
    {
        Enabled = false;
    }
    public void Resume()
    {
        Enabled = true;
    }

    public void Update()
    {
        if (!Enabled) return;

        currentTime -= UnityEngine.Time.deltaTime;
        if (currentTime < 0f)
        {
            if (currentLoop<=0)
            {
                Enabled = false;
            }
            else
            {
                currentLoop--;
                if (currentLoop <= 0)
                {
                    Enabled = false;
                }
                currentTime = initialTime;
                onEndTimer?.Invoke();
            }
        }
    }

    public float GetCurrentValue()
    {
        return currentTime;
    }
}
