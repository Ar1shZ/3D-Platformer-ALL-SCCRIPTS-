using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2;

    public Transform target;
    public GameObject thiss;
    public int damager = 1;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        transform.LookAt(target.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Player play = other.GetComponent<Player>();
            play.MinusHealth(damager);
        }
       

        if (other.tag == "Bullet")
        {
            Debug.Log("попал");
            Destroy(thiss);
        }
    }
}
