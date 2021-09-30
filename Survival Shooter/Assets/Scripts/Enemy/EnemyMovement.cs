using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    Transform player;
    float playerHealth = 100; //mus ini tuh dia harusnya nyambung sama kode selanjutnya dari playerhealth.cs
    float enemyHealth = 100; //sama ini juga. jadi sementara di buat aja nilainya buat ngakalin di if
    UnityEngine.AI.NavMeshAgent nav;


    void Awake ()
    {
        //Cari game object dengan tag player
        player = GameObject.FindGameObjectWithTag ("Player").transform;

        // playerHealth = player.GetComponent <PlayerHealth> ();
        // enemyHealth = GetComponent <EnemyHealth> ();
        nav = GetComponent <UnityEngine.AI.NavMeshAgent> ();
    }


    void Update ()
    {
        print(enemyHealth);
        print(playerHealth);
        if (enemyHealth > 0 && playerHealth > 0)
        {
            nav.SetDestination (player.position);
        }
        else
        {
           nav.enabled = false;
        }
    }
}
