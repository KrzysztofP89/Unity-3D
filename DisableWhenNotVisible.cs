using UnityEngine;

public class DisableWhenNotVisible : MonoBehaviour
{
    private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnBecameVisible()
    {
        enabled = true;
        print("cube became visible again");
    }

    void OnBecameInvisible()
    {
        enabled = false;
        print("cube became invisible");
    }

    void Update()
    {
        float d = Vector3.Distance(transform.position, player.transform.position);
        print(Time.time + ": distance from player to cube = " + d);
    }
}