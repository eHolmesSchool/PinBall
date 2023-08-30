using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PitBehaviour : MonoBehaviour
{
    [SerializeField] Transform SpawnPoint;
    [SerializeField] GameObject lifeTracker;

    private void OnTriggerEnter2D(Collider2D collided)
    { //Variable name "collided" prevents ambiguity
        StartCoroutine(WaitToRespawn(collided));
    }

    IEnumerator WaitToRespawn(Collider2D collided)
    {
        yield return new WaitForSeconds(1);
        collided.attachedRigidbody.transform.position = SpawnPoint.transform.position;
        collided.attachedRigidbody.transform.rotation = SpawnPoint.transform.rotation;
        collided.attachedRigidbody.velocity = new Vector2 (0,0) ;

        //if (collided == lifeTracker)
        //{
            //lifeTracker.GetComponent<LifeTracker>().lives -- ;
            //if (lifeTracker.GetComponent<LifeTracker>().lives <= 0)
            //{
                SceneManager.LoadScene(0);
            //}
        //}
    }
}
