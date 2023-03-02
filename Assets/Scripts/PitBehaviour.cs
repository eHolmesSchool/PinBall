using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitBehaviour : MonoBehaviour
{
    [SerializeField] Transform SpawnPoint;


    void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collided)
    { //Variable name "collided" prevents ambiguity
        StartCoroutine(WaitToRespawn(collided));
    }

    IEnumerator WaitToRespawn(Collider2D collided)
    {
        yield return new WaitForSeconds(2);
        collided.attachedRigidbody.transform.position = SpawnPoint.transform.position;
        collided.attachedRigidbody.transform.rotation = SpawnPoint.transform.rotation;
        collided.attachedRigidbody.velocity = new Vector2 (0,0) ;
    }
}
