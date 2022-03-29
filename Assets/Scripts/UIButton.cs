using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {
    [SerializeField] Text textBtn;
    [SerializeField] Color colorNormal;
    [SerializeField] Color colorHover;

    public void OnPointerEnter(PointerEventData eventData) {
        textBtn.color = colorHover;
        textBtn.fontStyle = FontStyle.Bold; 
    }
    public void OnPointerExit(PointerEventData eventData) {
        textBtn.color = colorNormal;
        textBtn.fontStyle = FontStyle.Normal; 
    }

}
