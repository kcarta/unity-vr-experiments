using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CollisionBounce : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseUp()
    {
        gameObject.GetComponent<Rigidbody>().AddExplosionForce(500, transform.position - new Vector3(0, 0), 10);
        var systems = GetComponentsInChildren<ParticleSystem>();
        foreach (ParticleSystem system in systems)
        {
            ParticleSystem.MainModule mainModule = system.main;
            system.Clear();
            system.Play();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        //var systems = GetComponentsInChildren<ParticleSystem>();
        //foreach (ParticleSystem system in systems)
        //{
        //    ParticleSystem.MainModule mainModule = system.main;
        //    system.Clear();
        //    system.Play();
        //}
    }
}
