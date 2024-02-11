using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button FloorButton;
    public Button WallButton;
    public Button FurnitureButton;
    public Button quitButton;

    void Start()
    {
        // Add click listeners to the buttons
        FloorButton.onClick.AddListener(OnFloorButtonDown);
        WallButton.onClick.AddListener(OnWallButtonDown);
        FurnitureButton.onClick.AddListener(OnFurnitureButtonDown);
        quitButton.onClick.AddListener(OnQuitButtonDown);
    }
    void OnFloorButtonDown()
    {
        SceneManager.LoadScene("Floor");

    }
    void OnWallButtonDown()
    {
        SceneManager.LoadScene("Wall");

    }
    void OnFurnitureButtonDown()
    {
        SceneManager.LoadScene("Furniture");

    }
    void OnQuitButtonDown()
    {
        Application.Quit(); 

    }

}
