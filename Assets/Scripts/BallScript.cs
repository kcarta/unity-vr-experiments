using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public GameObject floor;

    // Update is called once per frame
    void Update()
    {
        if(floor != null && transform.position.y < floor.transform.position.y)
        {
            Destroy(gameObject, 1);
        }
    }

    void OnMouseUp()
    {
        var canvas = GetComponentInChildren<Canvas>(true);
        canvas.gameObject.SetActive(true);
        //canvas.enabled = true;
    }
}
