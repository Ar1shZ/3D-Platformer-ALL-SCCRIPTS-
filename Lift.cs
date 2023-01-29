using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift : MonoBehaviour
{
    public GameObject top;
    public GameObject under;
    bool goUp = true;

    private void OnTriggerStay(Collider other)
    {
        float a = gameObject.transform.position.x;
        float b = gameObject.transform.position.z;

        if (goUp)
        {
            if (other.tag == "Under" && other.tag == "Player")
            {
                for (float i = gameObject.transform.position.y; i < top.transform.position.y; i += 1f)
                {
                    gameObject.transform.position = new Vector3(a, i*Time.deltaTime, b);
                    Debug.Log(i);
                }
            }
            goUp = false;
        }
        else
        {
            if (other.tag == "Top" && other.tag == "Player")
            {
                for (float i = gameObject.transform.position.y; i > under.transform.position.y; i -= 0.1f)
                {
                    gameObject.transform.position = new Vector3(a, i*Time.deltaTime, b);
                    Debug.Log(i);
                }
                goUp = true;
            }
        }
    }
}
