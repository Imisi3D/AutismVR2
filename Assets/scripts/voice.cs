using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using IBM.Watsson.Examples;

public class voice : MonoBehaviour
{
    public ExampleStreaming externalScript;
    public AudioSource asabeVoice;
    public AudioClip[] allSpeech;
    public Text userResponse;
    public int currentAudio;
    public GameObject asabe;
    public Animator anim;
    

    List<string> wordTocheck = new List<string>(){ "ail",
                                                    "email",
                                                    "female",
                                                    "mail",
                                                    "male",
                                                    "wail",
                                                    "wale",
                                                    "cmale"};
    List<string> yesNo = new List<string>(){"yes","no"};

    void Start()
    {
        externalScript.StopRecording();
        asabeVoice = GetComponent<AudioSource> ();
        asabeVoice.clip=allSpeech[0]; 
        asabeVoice.Play();
        Invoke("activateMic",asabeVoice.clip.length);
    }
    void activateMic(){
        externalScript.StartRecording();
        anim.speed = 0;
    }
    void Update()
    {
        foreach (string x in wordTocheck)
        {
            if (userResponse.text.ToLower().Contains(x.ToLower()))
            {
               externalScript.StopRecording();
               userResponse.text = "OK";
               break;
            }
        }
        
        if (userResponse.text =="OK")
            {
               asabeVoice.clip=allSpeech[1];
               asabeVoice.Play();
               anim.speed = 1;
               userResponse.text = "Autism";
              Invoke("activateMic",asabeVoice.clip.length);
            }

        // if (!asabeVoice.isPlaying && userResponse.text =="Autism")
        //     {
        //        asabeVoice.clip=allSpeech[2];
        //        asabeVoice.Play();
        //        anim.speed = 1;
        //        userResponse.text = "More-Autism";
        //        Invoke("activateMic",asabeVoice.clip.length);
        //     }
        
    }
}
