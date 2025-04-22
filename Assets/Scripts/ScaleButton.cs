using UnityEngine;
using UnityEngine.EventSystems;

public class ScaleButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Vector3 escalaOriginal;
    private Vector3 escalaObjetivo;
    private float velocidad = 8f;

    public AudioClip sonidoHover;
    //public AudioClip sonidoClick;

    void Start()
    {
        escalaOriginal = transform.localScale;
        escalaObjetivo = escalaOriginal;
    }

    void Update()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, escalaObjetivo, Time.deltaTime * velocidad);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        escalaObjetivo = escalaOriginal * 1.1f;
        if (AudioManager.instancia != null)
            AudioManager.instancia.ReproducirSFX(sonidoHover);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        escalaObjetivo = escalaOriginal;
    }

    //public void OnPointerClick(PointerEventData eventData)
    //{
    //    //if (AudioManager.instancia != null)
    //    //    AudioManager.instancia.ReproducirSFX(sonidoClick);
    //}
}