using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeScript : MonoBehaviour
{
    public void Explode()
    {
        gameObject.SetActive(false);
        gameObject.SetActive(true);
    }
}