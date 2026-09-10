using UnityEngine;

public class UI : MonoBehaviour
{
    public CanvasGroup StartScreenCanvasGroup;
    public CanvasGroup GameOverScreenCanvasGroup;
    public CanvasGroup GUICanvasGroup;
    public CanvasGroup PauseScreenCanvasGroup;

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
}
