using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{


    public int life = 0;

    public int damage = 5;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnCollisionEnter(Collision col)
    {
        Debug.Log("bang");
        //If the object that triggered this collision is tagged "bullet"
        if (col.gameObject.tag == "Bullet")
        {
                Destroy(gameObject);
        }
    }

}




