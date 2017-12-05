﻿using UnityEngine;

public class DisableWhenExitTrigger : MonoBehaviour
{
    private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnTriggerEnter(Collider hitObjectCollider)
    {
        if (hitObjectCollider.CompareTag("Player"))
        {
            print("cube close to Player again");
            enabled = true;
        }
    }

    void OnTriggerExit(Collider hitObjectCollider)
    {
        if (hitObjectCollider.CompareTag("Player"))
        {
            print("cube away from Player");
            enabled = false;
        }
    }

    void Update()
    {
        float d = Vector3.Distance(transform.position, player.transform.position);
        print(Time.time + ": distance from player to cube = " + d);
    }
}
