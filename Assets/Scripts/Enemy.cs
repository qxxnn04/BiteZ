using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private Player player;

    public int life = 5;

    public int damage = 5;

    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(player.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.transform.position);
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




