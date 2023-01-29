using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 50;
    private GameObject bull;

    void Start()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
        bull = gameObject;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other);
            Destroy(bull);
        }
        else
        {
            Destroy(bull);
        }
    }
}
