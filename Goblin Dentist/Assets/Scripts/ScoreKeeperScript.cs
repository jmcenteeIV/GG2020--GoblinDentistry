using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeperScript : MonoBehaviour
{
    private int misclicks = 0;
    private int correctClicks = 0;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void updateMisclicks()
    {
        misclicks = misclicks+1;
    }

    public int getMisclicks()
    {
        return misclicks;
    }

    public void updateCorrectClicks()
    {
        correctClicks = correctClicks + 1;
    }

    public int getCorrectClicks()
    {
        return correctClicks;
    }
}