using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AudioClipType { grabclip, shopClip}
public class AudioManager : MonoBehaviour
{
   public static AudioManager instance;
   [SerializeField] private AudioSource audioSource;
   public AudioClip grabClip, shopClip;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(instance);
        }
    }


    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    public void PlayAudio(AudioClipType clipType)
    {
        if(audioSource != null)
        {
            AudioClip audioClip = null;
            if(clipType == AudioClipType.grabclip)
            {
                audioClip = grabClip;
            }
            else if (clipType == AudioClipType.shopClip)
            {
                audioClip = shopClip;
            }

            audioSource.PlayOneShot(audioClip, 0.6f);
        }
        
    }
}
