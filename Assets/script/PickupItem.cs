using UnityEngine;

public class PickupItem : MonoBehaviour
{
    public AudioSource pickupSound;

    void OnMouseDown()
    {
        pickupSound.Play();
        // Add logic to pick up the item
    }
}
