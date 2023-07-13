using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Portal : MonoBehaviour
{

    public new Collider2D collider2D;

    private bool portalOpen = false;

    [SerializeField] private GameEngine gameEngine;


    [SerializeReference]  private List<PortalTrigger> triggers;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && portalOpen)
        {
            gameEngine.ActivateWinScreen();
         }

        else if (collision.CompareTag("Player")){
            Debug.Log("I am lost in darkness exdee");
        }
    }

    public void checkPortalTriggers() {

        bool check = true;

        foreach (PortalTrigger trigger in triggers)
        {
            if (!trigger.getActivated())
            {
                check = false;
            }
        }

        if (check)
        {
            portalOpen = true;
            Debug.Log("Portal now active");
        }
        
    }


}
