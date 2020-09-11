using UnityEngine;
using UnityEngine.AI;

public class SC_NPCFollow : MonoBehaviour
{
    //Transform that NPC has to follow
    public Transform transformToFollow;
    //NavMesh Agent variable
    NavMeshAgent nm;
    Vector3 destination;

    // Start is called before the first frame update
    void Start()
    {
        nm = GetComponent<NavMeshAgent>();
        destination = nm.destination;
    }

    // Update is called once per frame
    void Update()
    {

       // Debug.Log(Vector3.Distance( transformToFollow.position, nm.destination));
       // if (Vector3.Distance(destination, transformToFollow.position) > 1.0f)
       // {
       //     destination = transformToFollow.position;
        //    nm.destination = destination;
       // }
       // else
        nm.SetDestination(transformToFollow.position);



        //Follow the player
        //nm.destination = transformToFollow.position;
        //Vector3 pos = transformToFollow.position; // get a copy
             
        //pos.x = Mathf.RoundToInt(gameObject.transform.position.x);
        //pos.y = Mathf.RoundToInt(gameObject.transform.position.y);
        //pos.z = Mathf.RoundToInt(gameObject.transform.position.z);
             
        //transformToFollow.position = pos;
        //Debug.Log(nm.destination);
        //Debug.Log(nm.destination);
        //if(nm.remainingDistance < 1)
        //{
        //    PlayerStats.Lives--;
		//    WaveSpawner.EnemiesAlive--;
		//    Destroy(gameObject);
        //    return;
        //}
        //nm.SetDestination(transformToFollow.position);
        
    }
}