using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; 
using UnityEngine.UI; 


public class Clickybutton : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    [SerializeField] private Image image;
    [SerializeField] private Sprite beg, pressed; 
    [SerializeField] private AudioClip click; 
    [SerializeField] private AudioSource source; 
    public void OnPointerDown(PointerEventData eventData)
    {
        source.PlayOneShot(click);
        image.sprite = pressed;
        throw new System.NotImplementedException();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }


}
