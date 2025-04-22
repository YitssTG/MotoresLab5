using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class CameraEvents
{
    public static event Action OnCamInicio;
    public static event Action OnCamSettings;
    public static event Action OnCamPlay;

    public static void CambiarACamInicio() => OnCamInicio?.Invoke();
    public static void CambiarACamSettings() => OnCamSettings?.Invoke();
    public static void CambiarACamPlay() => OnCamPlay?.Invoke();
}