using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player_ball : MonoBehaviour
{
    public int itemCount;
    public float jumpPower = 10;
    public GameManagerLogic manager;
    bool isjump;
    Rigidbody rigid;
    AudioSource audio;


    //find the Gamemanager in game and attatch GameManagerLogic c# file
    void Start()
    {
        manager = GameObject.Find("GameManager").GetComponent<GameManagerLogic>();
    }

    void Awake()
    {
        isjump = false;
        rigid = GetComponent<Rigidbody>(); // bring rigidbody
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(Input.GetButtonDown("Jump") && !isjump){ // for not eternal jump
            isjump = true;
            rigid.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal"); // keyboard wasd
        float v = Input.GetAxisRaw("Vertical"); // keyboard wasd
        rigid.AddForce(new Vector3(h, 0, v), ForceMode.Impulse); //x,y,z : y is the jump = 0 now no jump

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
            isjump = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "items"){ // if collision with player
            itemCount++;
            audio.Play();
            other.gameObject.SetActive(false);
            manager.GetItemCount(itemCount);
        }
        else if(other.tag == "Finish"){
            //Next Level
            if(manager.TotalItemCount == itemCount){
                if(manager.stage == 4){
                    SceneManager.LoadScene(5);
                }
                else{
                    SceneManager.LoadScene(manager.stage+1);
                }
            }
            else{
                //Restart Game..
                SceneManager.LoadScene(manager.stage);
            }
        }

    }   

}
