using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
// using IBM.Watsson.Examples;
using Vosk;

public class voice : MonoBehaviour
{
    public VoiceProcessor externalScript;
    public AudioSource asabeVoice;
    public Text AudioSpeech;
    public Animator anim;
    public List<AudioClip> audioClips;
    public Text userResponse;
    private AudioSource audioSource;
    private int currentAudio = 0;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClips[currentAudio];
        audioSource.Play();
    }
    private void Update()
    {
        if (!audioSource.isPlaying)
        {
            externalScript.StartRecording();
            anim.Play("idle");

            switch (currentAudio)
            {
                case 0:
                    if (userResponse.text.Contains("male") || userResponse.text.Contains("female"))
                    {
                        currentAudio = 1;
                        audioSource.clip = audioClips[currentAudio];
                        audioSource.Play();
                        userResponse.text = "";
                    }
                    break;
                case 1:
                    if (userResponse.text.Contains("yes"))
                    {
                        currentAudio = 2;
                        audioSource.clip = audioClips[currentAudio];
                        audioSource.Play();
                        userResponse.text = "";
                    }
                    else if (userResponse.text.Contains("no"))
                    {
                        audioSource.clip = audioClips[currentAudio];
                        audioSource.Play();
                        userResponse.text = "";
                    }
                    break;
                case 2:
                    if (userResponse.text.Contains("yes"))
                    {
                        currentAudio = 3;
                        audioSource.clip = audioClips[currentAudio];
                        audioSource.Play();
                        userResponse.text = "";
                    }
                    else if (userResponse.text.Contains("no"))
                    {
                        audioSource.clip = audioClips[currentAudio];
                        audioSource.Play();
                        userResponse.text = "";
                    }
                    break;
                case 3:
                    if (userResponse.text.Contains("yes"))
                    {
                        currentAudio = 4;
                        audioSource.clip = audioClips[currentAudio];
                        audioSource.Play();
                        userResponse.text = "";
                    }
                    else if (userResponse.text.Contains("no"))
                    {
                        audioSource.clip = audioClips[currentAudio];
                        audioSource.Play();
                        userResponse.text = "";
                    }
                    break;
                case 4:
                    if (userResponse.text.Contains("yes"))
                    {
                        currentAudio = 5;
                        audioSource.clip = audioClips[currentAudio];
                        audioSource.Play();
                        userResponse.text = "";
                    }
                    else if (userResponse.text.Contains("no"))
                    {
                        audioSource.clip = audioClips[currentAudio];
                        audioSource.Play();
                        userResponse.text = "";
                    }
                    break;
                case 5:
                 SceneManager.LoadScene("Scene1");
                    break;
            }
        }

        else if (audioSource.isPlaying)
        {
            externalScript.StopRecording();
            // anim.Play("talking");

        }
    }
}