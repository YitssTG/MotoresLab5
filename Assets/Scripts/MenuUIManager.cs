using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUIManager : MonoBehaviour
{
    public GameObject canvasStart;
    public GameObject canvasSettings;
    public GameObject canvasStartOptions;


    private void Start()
    {
        canvasSettings.SetActive(false);
        canvasStart.SetActive(true);
        canvasStartOptions.SetActive(false);
    }
    public void ShowSettings()
    {
        canvasStart.SetActive(false);
        canvasSettings.SetActive(true);
        canvasStartOptions.SetActive(false);
        CameraEvents.CambiarACamSettings();
    }
    public void BackToStart()
    {
        canvasSettings.SetActive(false);
        canvasStart.SetActive(true);
        canvasStartOptions.SetActive(false);
        CameraEvents.CambiarACamInicio();
    }
    public void StartGame()
    {
        canvasStart.SetActive(false);
        canvasStartOptions.SetActive(true);
        CameraEvents.CambiarACamPlay();
    } 
    public void ExitGame()
    {
        Debug.Log("Saliendo del juego.... :c");
        Application.Quit();
    }
}
