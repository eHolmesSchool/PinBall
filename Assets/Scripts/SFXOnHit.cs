using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class SFXOnHit : MonoBehaviour
{

    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip clip1;
    [SerializeField] Transform collidable1;     //When we collide, we check the tag of the object we hit. 
    string collTag1;                                            //If it matches the one we set, play Sound 1
                                                

    void Start()
    {
        collTag1 = collidable1.tag;
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag(collTag1)) 
        {
            audioSource.clip = clip1;
            audioSource.Play();

        }
    }
}
