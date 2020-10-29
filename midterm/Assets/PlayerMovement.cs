using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public AudioClip audioClipEPIC;
    private AudioSource audioSource;
    public BoxCollider2D boxCollider2D;
    public Rigidbody2D rigidbody2d;
    public Animator animator;

    Vector2 movement;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        if(Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        {
            animator.SetFloat("Last_Horizontal", Input.GetAxisRaw("Horizontal"));
            animator.SetFloat("Last_Vertical", Input.GetAxisRaw("Vertical"));
        }
    }

    void FixedUpdate()
    {
        // Movement
        rigidbody2d.MovePosition(rigidbody2d.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.gameObject.name == "Gift")
        {
            audioSource.PlayOneShot(audioClipEPIC);
            rigidbody2d.constraints = RigidbodyConstraints2D.FreezeAll;
        }

    }
}
