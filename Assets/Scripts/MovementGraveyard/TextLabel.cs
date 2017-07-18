using System;
using UnityEngine;
using UnityEngine.UI;

public class TextLabel : MonoBehaviour
{
    private Rigidbody _parentRigidBody;
    private Text _label;

    // Use this for initialization
    void Start()
    {
        _parentRigidBody = GetComponentInParent<Rigidbody>();
        _label = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateText();
        UpdateRotationToFaceCamera();
    }

    private void UpdateText()
    {
        _label.text = "Velocity: " + GetVelocity();
    }

    private string GetVelocity()
    {
        return _parentRigidBody.velocity.magnitude.ToString("0.00");
    }

    private void UpdateRotationToFaceCamera()
    {
        if (Camera.main != null)
        {
            var directionToCamera = GetDirectionToCamera();
            var rotationToCamera = Quaternion.LookRotation(directionToCamera);
            transform.rotation = rotationToCamera;
        }
    }

    private Vector3 GetDirectionToCamera()
    {
        // returns a vector pointing from this object to the main camera
        return transform.position - Camera.main.transform.position;
    }
}
