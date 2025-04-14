using UnityEngine;

public class Lever : MonoBehaviour
{
    public bool isOpen;
    public GameObject toOpen;

    void Update()
    {
        if (isOpen)
        {
            toOpen.SetActive(false);
        }
        else
        {
            toOpen.SetActive(true);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Key")
        {
            if (isOpen)
            {
                isOpen = false;
            }
            else
            {
                isOpen = true;
            }
        }        
    }
}
