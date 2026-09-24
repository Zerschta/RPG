using UnityEngine;

public class Trigger : MonoBehaviour
{
    public Transform inventar;
    public Transform player;

    private GameObject Object;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Object"))
        {
            Object = collision.gameObject;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Object"))
        {
            Object = null;
        }
    }

    private void Update()
    {
        if (Object != null)
        {
            // Aufheben
            if (Input.GetKeyDown(KeyCode.E) && Object != null)
            {
                Object.transform.SetParent(inventar);
                Object.SetActive(false);
            }
        }
        // Droppen
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            if (inventar.childCount > 0)
            {
                Transform item = inventar.GetChild(0);

                item.SetParent(null);
                item.gameObject.SetActive(true);

                item.position = player.position + player.up * 1.5f;
            }
        }
    }
}
