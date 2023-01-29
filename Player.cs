using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float coins;
    public float health = 20;
    public float speed = 5f;
    public GameObject bulletPrefab;
    public GameObject boxPrefab;

    public Transform target;
    public Text HP;
    public Slider slider;

    public AudioSource playerSound;
    public AudioClip hitSound;
    private void Start()
    {
        HP.text = health.ToString();
    }
    public void MoreCoin()
    {
        coins++;
    }

    public void MinusHealth(int damage) 
    {
        playerSound.PlayOneShot(hitSound);
        health -= damage;
    }

    private void Update()
    {
        slider.value = health;
        HP.text = health.ToString();

        if (health <= 0)
        {
            SceneManager.LoadScene(0);
        }

        if (Input.GetMouseButtonDown(1))
        {
            Instantiate(boxPrefab,target.position,target.rotation);
        }

        if (Input.GetMouseButton(0))
        {
            Instantiate(bulletPrefab,target.position,target.rotation);
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Debug.Log("в меня попало");
            HP.text = health.ToString();
        }
    }
}
