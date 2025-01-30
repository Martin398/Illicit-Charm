using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaManager : MonoBehaviour
{
    // cheap script taken from: https://www.youtube.com/watch?v=yaQlRvHgIvE

    public GameObject virtualCamera;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && !other.isTrigger)
        {
            virtualCamera.SetActive(true);
            Debug.Log("what");
        }

            Debug.Log("what");
        
    }    

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player") && !other.isTrigger)
        {
            virtualCamera.SetActive(false);
        }
    }

}
