using UnityEngine;
using System.Collections;
using System;

public class MusicManager1 : MonoBehaviour {
    [SerializeField]
    AudioSource BackgroundMusic;

        private static AudioSource _instance;

    void Awake()
    {
        //if we don't have an [_instance] set yet
        if (!_instance)
            _instance =BackgroundMusic;
        //otherwise, if we do, kill this thing
        else
            Destroy(BackgroundMusic.gameObject);


        DontDestroyOnLoad(BackgroundMusic.gameObject);
    }
}
    

