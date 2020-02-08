using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIAnimation : MonoBehaviour
{
    
    GameObject player;
    NavMeshAgent enemy;
    Animator animCon;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        animCon = GetComponent<Animator>();

        animCon.SetBool("IsWalking", true);

        animCon.SetBool("IsEnnemy", false);

        if(player == null)
        {
            Debug.Log("Zapomniałeś ustawić TAGU gracza");
        }

        enemy = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if ( player != null)
        {
            Debug.Log(enemy.remainingDistance.ToString());
            if(     
                enemy.remainingDistance != Mathf.Infinity
                && enemy.remainingDistance <= enemy.stoppingDistance
              )
            {
                enemy.destination = player.transform.position;
                animCon.SetBool("IsWalking", false);
            }
            else
            {

                enemy.destination = player.transform.position;
                animCon.SetBool("IsWalking", true);
            }
        }
        
            

    }
}
