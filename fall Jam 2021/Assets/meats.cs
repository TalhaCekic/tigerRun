using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meats : MonoBehaviour
{
    public AudioClip eatSound;

void OnTriggerEnter2D(Collider2D player)
    {
        Destroy(this.gameObject);
        AudioSource.PlayClipAtPoint(eatSound, transform.position);
    }
}

