using UnityEngine.Audio;
using System;
using UnityEngine;
using System.Collections;


public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    public float sum_score = 0f;

    //更新的时间间隔
    public float UpdateInterval = 0.5F;
    //最后的时间间隔
    private float _lastInterval;
    //帧[中间变量 辅助]
    private int _frames = 0;
    //当前的帧率
    private float _fps;

    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("MUSIC");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);

        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }


    void Start()
    {
        Play("theme");
        //Application.targetFrameRate=60;
        UpdateInterval = Time.realtimeSinceStartup;
        _frames = 0;
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 8, 200, 200), "FPS:" + _fps.ToString("f2"));
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);

        s.source.Play();
    }

        void Update()
        {
            ++_frames;
            if (Time.realtimeSinceStartup > _lastInterval + UpdateInterval)
            {
                _fps = _frames / (Time.realtimeSinceStartup - _lastInterval);
                _frames = 0;
                _lastInterval = Time.realtimeSinceStartup;
            }
        }
    

}
