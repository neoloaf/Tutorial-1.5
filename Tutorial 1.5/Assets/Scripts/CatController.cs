using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{

    public AudioClip musicClipOne;
    public AudioClip musicClipTwo;
    public AudioSource musicSource;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            musicSource.clip = musicClipOne;
            musicSource.Play();
            musicSource.loop = true;
            anim.SetInteger("State", 1);
        }
        
        if(Input.GetKeyUp(KeyCode.W))
        {
            musicSource.Stop();
            musicSource.loop = false;
            anim.SetInteger("State", 0);
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            musicSource.clip = musicClipTwo;
            musicSource.Play();
            musicSource.loop = true;
            anim.SetInteger("State", 2);
        }

        if(Input.GetKeyUp(KeyCode.R))
        {
            musicSource.Stop();
            musicSource.loop = false;
            anim.SetInteger("State", 0);
        }

        if(Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
