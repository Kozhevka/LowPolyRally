using System;
using TMPro;
using UnityEngine;

public class CarControl : MonoBehaviour
{
    public float speed;

    [SerializeField] TextMeshProUGUI spedometr;

    [SerializeField] private float kmPhSpeed;
    Rigidbody thisRb;


    private void Start()
    {
        thisRb = gameObject.GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
        speed = thisRb.velocity.magnitude;
        kmPhSpeed = speed * 3.6f;
        spedometr.text = "Km/h: " + Math.Round(kmPhSpeed, 2);
    }

    public void FixRotate()
    {
        transform.position += new Vector3(0f, 2f, 0f);
        transform.rotation = Quaternion.Euler(0f, transform.eulerAngles.y, 0f);
    }
}
