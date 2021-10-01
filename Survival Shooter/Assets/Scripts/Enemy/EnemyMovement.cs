using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    Transform player;
    PlayerHealth playerHealth;
    EnemyHealth enemyHealth;

    //float playerHealth = 100; //nyambung sama kode selanjutnya dari playerhealth.cs
    //float enemyHealth = 100; //sementara di buat nilainya buat ngakalin di if

    UnityEngine.AI.NavMeshAgent nav;


    void Awake ()
    {
        //Cari game object dengan tag player
        player = GameObject.FindGameObjectWithTag ("Player").transform;

        playerHealth = player.GetComponent <PlayerHealth> ();
        enemyHealth = GetComponent <EnemyHealth> ();
        nav = GetComponent <UnityEngine.AI.NavMeshAgent> ();
    }


    void Update ()
    {
        // print(enemyHealth);
        // print(playerHealth);
        if (enemyHealth.currentHealth > 0 && playerHealth.currentHealth> 0)
        {
            nav.SetDestination (player.position);
        }
        else
        {
           nav.enabled = false;
        }
    }
}
