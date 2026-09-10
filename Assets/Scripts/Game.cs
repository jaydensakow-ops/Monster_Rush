using UnityEngine;

public class Game : MonoBehaviour
{
    public UI Ui;

    private bool isGameRunning = false;

    public void Start()
    {
        Ui.HideGameOverScreen();
        Ui.HidePauseScreen();
        Ui.HideGUIScreen();
        Ui.ShowStartScreen();
    }
    public void Update()
    {
        
    }

    public bool IsPlaying()
    {
        return isGameRunning;
    }

    public void OnPlayButtonClicked()
    {
        Ui.HideStartScreen();
        InitializeGame();
        Ui.ShowGUIScreen();
    }
    
    public void OnPauseButtonClicked()
    {
        Ui.HideGUIScreen();
        Ui.ShowPauseScreen();
        //add suspend functionality
    }
    
    public void OnResumeButtonClicked()
    {
        Ui.HidePauseScreen();
        Ui.ShowGUIScreen();
        //add unsuspend functionality
    }
    
    public void InitializeGame()
    {
        isGameRunning = true;
    }
    
    
    public void OnPlayAgainButtonClicked()
    {
        Ui.HideGameOverScreen();
        InitializeGame();
        Ui.ShowGUIScreen();
    }
    
    public void OnGameOverButtonClicked()
    {
        Ui.HideGUIScreen();
        Ui.ShowGameOverScreen();
    }
    
    public void OnStartScreenReturnButtonClicked()
    {
        Ui.HideGameOverScreen();
        Ui.HidePauseScreen();
        isGameRunning = false;
        Ui.ShowStartScreen();
    }

    public void OnStartRoundButtonClicked()
    {
        
    }
}