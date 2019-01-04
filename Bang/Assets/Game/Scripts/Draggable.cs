using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    
    public Transform parentToReturnTo = null;
    public CardsValue card;
    public static Draggable draggable;
    

   
    private void Awake()
    {
        
            draggable = this;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
       


            parentToReturnTo = this.transform.parent;
        
            this.transform.SetParent(this.transform.parent.parent);
        
            GetComponent<CanvasGroup>().blocksRaycasts = false;
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        
            this.transform.position = eventData.position;
        
       
    }

    public void OnEndDrag(PointerEventData eventData)
    {

        
            GetComponent<CanvasGroup>().blocksRaycasts = true;
            this.transform.SetParent(parentToReturnTo);

        
       
    }

    public void dha()
    {
       Turn.turn.kijatszottLapok++;
        SHp.sHp.Armor(card.armor);
        HP.hP.GiveDamage(card.damage);
        SHp.sHp.TakeHeal(card.heal);
        
        
        Destroy(gameObject);
        
    }
   
}