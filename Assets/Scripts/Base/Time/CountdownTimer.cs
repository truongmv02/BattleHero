﻿
public class CountdownTimer : Timer
{
    public bool IsFinished => Time <= 0;
    public CountdownTimer(float initTime) : base(initTime)
    {
    }

    public override void Tick(float deltaTime)
    {
        if (IsRunning && Time > 0)
        {
            Time -= deltaTime;
        }

        if (IsRunning && Time <= 0)
        {
            Stop();
        }
    }

    public void Reset() => Time = initialTime;

    public void Reset(float newTime)
    {
        initialTime = newTime;
        Reset();
    }


}
