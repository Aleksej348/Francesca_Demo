using System.Collections;
using UnityEngine;
using UnityEngine.Audio;

public class Audio : MonoBehaviour
{
    public AudioSource music,sound,sound2;
    public AudioClip[] musicClips,soundClips;
    public AudioMixer mixer;
	private bool turn;
    private GameManager gm=>GameManager.gm;

    private void Awake()
    {
        music=transform.GetChild(0).GetComponent<AudioSource>();
        sound=transform.GetChild(1).GetComponent<AudioSource>();
		sound2=transform.GetChild(2).GetComponent<AudioSource>();
		if(PlayerPrefs.GetFloat("MusicVolume")==0) PlayerPrefs.SetFloat("MusicVolume",1f);
        if(PlayerPrefs.GetFloat("SoundVolume")==0) PlayerPrefs.SetFloat("SoundVolume",1f);
    }

    private void Start()
    {
        float mus=PlayerPrefs.GetFloat("MusicVolume");
        float sou=PlayerPrefs.GetFloat("SoundVolume");
        mixer.SetFloat("MusicVolume", Mathf.Log10(mus) * 20);
        mixer.SetFloat("SoundVolume", Mathf.Log10(sou) * 20);
    }

    public void PlaySound(int number,float _pitch=1f,bool afterMusic=false)
    {
        sound.clip=soundClips[number];
        sound.pitch=_pitch;
        if(gm.st.skip){sound.Play();return;}
        if(afterMusic==false) sound.Play();
        else StartCoroutine("playSound");
    }

	public void PlaySound2(int number, float _pitch = 1f)
	{
		sound2.clip=soundClips[number];
		sound2.pitch=_pitch;
		sound2.Play();
	}
	public IEnumerator PlaySoundMultTimes(int num, int times)
	{
		for(int i=0;i<times;i++)
		{
			sound.clip=soundClips[num];
			sound.Play();
			yield return new WaitUntil(() => sound.isPlaying==false);
		}
	}
	public IEnumerator PlaySound2MultTimes(int num,int times)
	{
		for(int i = 0;i<times;i++)
		{
			sound2.clip=soundClips[num];
			sound2.Play();
			yield return new WaitUntil(() => sound2.isPlaying==false);
		}
	}
	private IEnumerator playSound()
    {
        StopMusic();
        yield return new WaitUntil(()=>music.isPlaying==false);
        sound.Play();
    }

    public void PlayMusic(int number,bool afterSound=false,float _pitch=1f)
    {
        if(gm.st.skip==false)
		{
			if(turn)
				StopAllCoroutines();
			StartCoroutine(routine: playMusic(musicClips[number],afterSound,_pitch));
		}
			
        else {music.clip=musicClips[number]; music.Play();}
    }

    public void StopMusic()
    {
        StartCoroutine(routine: stopMusic());
    }

    private IEnumerator playMusic(AudioClip newMus,bool afterSound,float _pitch)
    {
		turn=true;
        if(afterSound) yield return new WaitUntil(()=>sound.isPlaying==false);

        if(music.isPlaying)
        {
            while(music.volume>0)
            {
                music.volume-=0.01f;
                yield return new WaitForSecondsRealtime(0.01f);
            }
            music.pitch=_pitch;
            music.clip=newMus;
            music.Play();
            while(music.volume<1f)
            {
                music.volume+=0.01f;
                yield return new WaitForSecondsRealtime(0.01f);
            }
        }
        else
        {
            music.clip=newMus;
            music.Play();
            music.volume=0;
            while(music.volume<1f)
            {
                music.volume+=0.01f;
                yield return new WaitForSecondsRealtime(0.01f);
            }
        }
		turn=false;
    }

    private IEnumerator stopMusic()
    {
        while(music.volume>0)
        {
            music.volume-=0.01f;
            yield return new WaitForSecondsRealtime(0.01f);
        }
        music.Stop();
        music.volume=1f;
    }




}
