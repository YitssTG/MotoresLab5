using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class CameraControll : MonoBehaviour
{
    public CinemachineVirtualCamera camInicio;
    public CinemachineVirtualCamera camSettings;
    public CinemachineVirtualCamera camPlay;
    void OnEnable()
    {
        CameraEvents.OnCamInicio += IrAInicio;
        CameraEvents.OnCamSettings += IrASettings;
        CameraEvents.OnCamPlay += IrAPlay;
    }
    void OnDisable()
    {
        CameraEvents.OnCamInicio -= IrAInicio;
        CameraEvents.OnCamSettings -= IrASettings;
        CameraEvents.OnCamPlay -= IrAPlay;
    }
    void Start()
    {
        ActivarCamara(camInicio);
    }
    void IrAInicio()
    {
        ActivarCamara(camInicio);
    }
    void IrASettings()
    {
        ActivarCamara(camSettings);
    }
    void IrAPlay()
    {
        ActivarCamara(camPlay);
    }
    void ActivarCamara(CinemachineVirtualCamera camActiva)
    {
        camInicio.Priority = (camActiva == camInicio) ? 10 : 0;
        camSettings.Priority = (camActiva == camSettings) ? 10 : 0;
        camPlay.Priority = (camActiva == camPlay) ? 10 : 0;
    }
}
