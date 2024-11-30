using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

    public void OnStageSelectButtonClicked()
    {
        FadeManager.Instance.FadeToScene("StageSelect");
    }

    public void OnStage1Clicked()
    {
        FadeManager.Instance.FadeToScene("Main");
    }

    public void OnStage2Clicked()
    {
        FadeManager.Instance.FadeToScene("Stage2");
    }

    public void OnTitleBackClicked()
    {
        FadeManager.Instance.FadeToScene("Title");
    }
}
