using UnityEngine;

public class UI : MonoBehaviour
{
    public CanvasGroup StartScreenCanvasGroup;
    public CanvasGroup GameOverScreenCanvasGroup;
    public CanvasGroup GUICanvasGroup;
    public CanvasGroup PauseScreenCanvasGroup;
    public CanvasGroup StartRoundButtonCanvasGroup;
    public CanvasGroup GameOverButtonCanvasGroup;
    public CanvasGroup TowerSelectPanelCanvasGroup;
    public CanvasGroup OpenPanelCanvasGroup;

    public void HideStartScreen()
    {
        CanvasGroupDisplayer.Hide(StartScreenCanvasGroup);
    }
    
    public void ShowStartScreen()
    {
        CanvasGroupDisplayer.Show(StartScreenCanvasGroup);
    }
    
    public void HideGameOverScreen()
    {
        CanvasGroupDisplayer.Hide(GameOverScreenCanvasGroup);
    }
    
    public void ShowGameOverScreen()
    {
        CanvasGroupDisplayer.Show(GameOverScreenCanvasGroup);
    }
    
    public void HideGUIScreen()
    {
        CanvasGroupDisplayer.Hide(GUICanvasGroup);
    }
    
    public void ShowGUIScreen()
    {
        CanvasGroupDisplayer.Show(GUICanvasGroup);
    }
    
    public void HidePauseScreen()
    {
        CanvasGroupDisplayer.Hide(PauseScreenCanvasGroup);
    }
    
    public void ShowPauseScreen()
    {
        CanvasGroupDisplayer.Show(PauseScreenCanvasGroup);
    }

    public void HideStartRoundButton()
    {
        CanvasGroupDisplayer.Hide(StartRoundButtonCanvasGroup);
    }

    public void ShowStartRoundButton()
    {
        CanvasGroupDisplayer.Show(StartRoundButtonCanvasGroup);
    }

    public void HideGameOverButton()
    {
        CanvasGroupDisplayer.Hide(GameOverButtonCanvasGroup);
    }

    public void ShowGameOverButton()
    {
        CanvasGroupDisplayer.Show(GameOverButtonCanvasGroup);
    }

    public void HideTowerSelectPanel()
    {
        CanvasGroupDisplayer.Hide(TowerSelectPanelCanvasGroup);
    }

    public void ShowTowerSelectPanel()
    {
        CanvasGroupDisplayer.Show(TowerSelectPanelCanvasGroup);
    }

    public void HideOpenPanelButton()
    {
        CanvasGroupDisplayer.Hide(OpenPanelCanvasGroup);
    }
    
    public void ShowOpenPanelButton()
    {
        CanvasGroupDisplayer.Show(OpenPanelCanvasGroup);
    }

}
