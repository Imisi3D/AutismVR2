using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// using IBM.Watsson.Examples;
using Vosk;

public class voice : MonoBehaviour
{
    public VoiceProcessor externalScript;
    public AudioSource asabeVoice;
    public AudioClip[] allSpeech;
    public Text userResponse;
    public Text AudioSpeech;
    public int currentAudio;
    public GameObject asabe;
    public Animator anim;
    

    List<string> answer1 = new List<string>(){ "ail",
                                                    "email",
                                                    "female",
                                                    "mail",
                                                    "male",
                                                    "wail",
                                                    "wale",
                                                    "cmale",
                                                    "when"
                                                    };
    List<string> yesNo = new List<string>(){"yes","no"};

    void Start()
    {
        // externalScript.VoiceProcessor.StopRecording();
        asabeVoice = GetComponent<AudioSource> ();
//anim = GetComponent<Animator>();
        asabeVoice.clip=allSpeech[0]; 
        userResponse.text = "";
        currentAudio = 0;
        // anim.speed = 0;
        asabeVoice.Play();
        Invoke("changetext", asabeVoice.clip.length);

    }

    void activateMic(){
        asabe.GetComponent<Animator>().Play("idle");
        externalScript.StartRecording();
    }

    void changetext(){
        currentAudio++;
        AudioSpeech.text = "speech"+currentAudio;
    }
    void Update()
    {
        if(!asabeVoice.isPlaying && AudioSpeech.text == "speech1")
        {
            AudioSpeech.text = "speech2";
            asabeVoice.clip=allSpeech[1];
            asabeVoice.Play();
            asabe.GetComponent<Animator>().Play("1");
            Invoke("activateMic", asabeVoice.clip.length);
        }
         
         if(!asabeVoice.isPlaying && AudioSpeech.text == "speech2")
        {
            if(answer1.Contains(userResponse.text)){
                externalScript.StopRecording();
                asabeVoice.clip=allSpeech[2];
                asabeVoice.Play();
                asabe.GetComponent<Animator>().Play("1");
                AudioSpeech.text = "speech3";
                Invoke("activateMic",asabeVoice.clip.length);
            }
        }


        if(!asabeVoice.isPlaying && AudioSpeech.text == "speech3")
        {
            if(userResponse.text == "yes"){
                externalScript.StopRecording();
                asabeVoice.clip=allSpeech[3];
                asabeVoice.Play();
                asabe.GetComponent<Animator>().Play("1");
                AudioSpeech.text = "speech4";
                userResponse.text = "";
                Invoke("activateMic",asabeVoice.clip.length);
            } else if(userResponse.text == "no"){
                    AudioSpeech.text = "speech3";
                    externalScript.StopRecording();
                    asabeVoice.Play();
                    userResponse.text = "";
                    Invoke("activateMic",asabeVoice.clip.length);
                     }

        }



        if(!asabeVoice.isPlaying && AudioSpeech.text == "speech4")
        {
            if(userResponse.text == "yes"){
                externalScript.StopRecording();
                asabeVoice.clip=allSpeech[4];
                asabeVoice.Play();
                asabe.GetComponent<Animator>().Play("1");
                AudioSpeech.text = "speech5";
                userResponse.text = "";
                Invoke("activateMic",asabeVoice.clip.length);
            } else if(userResponse.text == "no"){
                    AudioSpeech.text = "speech4";
                    externalScript.StopRecording();
                    asabeVoice.Play();
                    userResponse.text = "";
                    Invoke("activateMic",asabeVoice.clip.length);
                     }
        }

if(!asabeVoice.isPlaying && AudioSpeech.text == "speech5")
        {
            if(userResponse.text == "yes"){
                externalScript.StopRecording();
                asabeVoice.clip=allSpeech[5];
                asabeVoice.Play();
                asabe.GetComponent<Animator>().Play("1");
                AudioSpeech.text = "speech6";
                userResponse.text = "";
                Invoke("activateMic",asabeVoice.clip.length);
            } else if(userResponse.text == "no"){
                    AudioSpeech.text = "speech5";
                    externalScript.StopRecording();
                    asabeVoice.Play();
                    userResponse.text = "";
                    Invoke("activateMic",asabeVoice.clip.length);
                     }
        }
        if(!asabeVoice.isPlaying && AudioSpeech.text == "speech6")
        {
            if(userResponse.text == "yes"){
                externalScript.StopRecording();
                asabeVoice.clip=allSpeech[6];
                asabeVoice.Play();
                asabe.GetComponent<Animator>().Play("1");
                AudioSpeech.text = "speech7";
                userResponse.text = "";
                Invoke("activateMic",asabeVoice.clip.length);
            } else if(userResponse.text == "no"){
                    AudioSpeech.text = "speech6";
                    externalScript.StopRecording();
                    asabeVoice.Play();
                    userResponse.text = "";
                   // Invoke("scene2",asabeVoice.clip.length);
                     }
        }
        
    }
}
