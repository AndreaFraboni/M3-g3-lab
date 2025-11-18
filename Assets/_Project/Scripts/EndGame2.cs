using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame2 : MonoBehaviour
{
    [SerializeField] int playerInsideTrigger = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInsideTrigger++;
            Debug.Log($"player inside trigger = {playerInsideTrigger}");
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInsideTrigger--;
            Debug.Log($"player inside trigger = {playerInsideTrigger}");
        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {

    }

    private void Update()
    {
        if (playerInsideTrigger == 2)
        {
            Debug.Log($"player inside trigger = {playerInsideTrigger}");
            Debug.Log("LIVELLO COMPLETATO !!!!");
        }
    }
}
