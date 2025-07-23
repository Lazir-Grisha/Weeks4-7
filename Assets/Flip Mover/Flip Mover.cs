using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipMover : MonoBehaviour
{
    public AudioSource moveClickAudioSource;
    public AudioSource stopClickAudioSource;
    public AudioSource flipClickAudioSource;

    public AudioClip stopClickAudioClip;

    public List<AudioClip> flipClickAudioClips;


    public float speed;
    private bool moving = false;
    private float direction = 1;
    // Start is called before the first frame update
    void Start()
    {
        stopClickAudioSource.clip = stopClickAudioClip;
    }

    // Update is called once per frame
    void Update()
    {
        if (moving)
        {
            transform.position += Vector3.right * speed * Time.deltaTime * direction;
        }

    }

    public void OnMoveClick()
    {
        moving = true;
        moveClickAudioSource.Play();
    }

    public void OnStopClick()
    {
        stopClickAudioSource.Play();
        moving = false;
    }

    public void OnFlipClick()
    {
        direction *= -1;

        //Take our clips

        //Choose one randomly

        //Get a random number from 0 to (the size of the list minus one)
        //Make sure you're taking into account the exclusive nature of the maximum parameter
        //with Random.Range
        int randomIndex = UnityEngine.Random.Range(0, flipClickAudioClips.Count);
        AudioClip randomlyChosenClip = flipClickAudioClips[randomIndex];

        flipClickAudioSource.PlayOneShot(randomlyChosenClip);

    }

}
