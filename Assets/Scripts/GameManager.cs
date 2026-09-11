using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioManager AudioManager;
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
        AudioManager.PlayStartGameSound();
        InitializeGame();
        Ui.ShowGUIScreen();
        Ui.ShowTowerSelectPanel();
        Ui.ShowStartRoundButton();
        Ui.HideOpenPanelButton();
        Ui.HideGameOverButton();
    }
    
    public void OnPauseButtonClicked()
    {
        Ui.HideGUIScreen();
        AudioManager.PlayPauseSound();
        Ui.ShowPauseScreen();
        //add suspend functionality
    }
    
    public void OnResumeButtonClicked()
    {
        Ui.HidePauseScreen();
        AudioManager.PlayUnpauseSound();
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
        AudioManager.PlayStartGameSound();
        InitializeGame();
        Ui.ShowGUIScreen();
        Ui.ShowStartRoundButton();
        Ui.HideGameOverButton();
    }
    
    public void OnGameOverButtonClicked()
    {
        Ui.HideGUIScreen();
        Ui.ShowGameOverScreen();
        AudioManager.PlayGameOverSound();
    }
    
    public void OnStartScreenReturnButtonClicked()
    {
        Ui.HideGameOverScreen();
        Ui.HidePauseScreen();
        isGameRunning = false;
        Ui.ShowStartScreen();
        AudioManager.PlayStartScreenReturnSound();
    }

    public void OnStartRoundButtonClicked()
    {
        Ui.HideStartRoundButton();
        AudioManager.PlayRoundStartSound();
        Ui.ShowGameOverButton();
    }

    public void OnBaseTowerButtonClicked()
    {
        AudioManager.PlayPurchaseSound();
        
        //if the player doesn't have enough money deny purchase with sound 
    }

    public void OnClosePanelButtonClicked()
    {
        Ui.HideTowerSelectPanel();
        Ui.ShowOpenPanelButton();
    }

    public void OnOpenPanelButtonClicked()
    {
        Ui.HideOpenPanelButton();
        Ui.ShowTowerSelectPanel();
    }
}