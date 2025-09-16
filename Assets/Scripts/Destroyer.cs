using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField] private int delay = 3;
    
    public void DestroySelf()
    {
        Destroy(gameObject);
    }
    
    public void HideAndDestroyDelayed()
    {
        HideVisibility();
        Invoke(nameof(DestroySelf), delay);
    }

    private void HideVisibility()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
    }
}
