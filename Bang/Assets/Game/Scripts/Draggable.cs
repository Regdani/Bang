using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    public Transform parentToReturnTo = null;
    public static bool take = true;
    public CardsValue card;

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");

        parentToReturnTo = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);

        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");

        this.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");

        GetComponent<CanvasGroup>().blocksRaycasts = true;
        this.transform.SetParent(parentToReturnTo);
        dha();

    }

    public void dha()
    {
        take = false;
        HP.hP.GiveDamage(card.damage);
        SHp.sHp.TakeHeal(card.heal);
        SHp.sHp.Armor(card.armor);
    }
   
}