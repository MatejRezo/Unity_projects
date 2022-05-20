using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{   
    
     private Rigidbody playerRB;
     private Animator playerAnim;
     private AudioSource playerAudio;
     public ParticleSystem explosionParticle;
     public ParticleSystem dirtTray;
     public float jumpForce = 10;
     public float gravityModifier; 
     public AudioClip jumpSound;
     public AudioClip crashSound;
     

     public bool gameOver = false;

    public bool isOnGround = true;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        Physics.gravity*= gravityModifier;
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver ){
            playerRB.AddForce(Vector3.up * jumpForce);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
            dirtTray.Stop();
            playerAudio.PlayOneShot(jumpSound, 0.7f);
            
        }
        
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.CompareTag("Ground")){
            isOnGround =  true;
        }else if (collision.gameObject.CompareTag("Obstacle")){
            Debug.Log("GameOver");
            gameOver = true;
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
            dirtTray.Stop();
            playerAudio.PlayOneShot(crashSound, 0.7f);
        }
        if(isOnGround && !gameOver){
            dirtTray.Play();
        }
    }

}
