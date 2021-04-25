using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public AudioClip collectedClip;

    public ParticleSystem heal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            controller.speed = 5;
            Instantiate(heal, transform.position, transform.rotation);
            controller.PlaySound(collectedClip);
            Destroy(gameObject);
        }
    }
}
