﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;


public class Enemy : MonoBehaviour
{
    NavMeshAgent nav;
    GameObject target;
    
    // Use this for initialization
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        target = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (nav.destination != target.transform.position)
        {
            nav.SetDestination(target.transform.position);
        }
        else
        {
            nav.SetDestination(transform.position);
        }

        /*void OnTriggerEnter()
        {
            if (tag == "ghost")
            {
                SceneManager.LoadScene("01");
            }
        }*/

    }


}
