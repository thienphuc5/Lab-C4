using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class IntroController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public AudioSource audioSource;

    void Start()
    {
        videoPlayer.prepareCompleted += OnVideoPrepared;
        videoPlayer.loopPointReached += OnVideoFinished;

        videoPlayer.Prepare();
    }

    void OnVideoPrepared(VideoPlayer vp)
    {
        vp.Play();
        audioSource.Play();
    }

    void OnVideoFinished(VideoPlayer vp)
    {
        LoadGameplay();
    }

    public void SkipIntro()
    {
        LoadGameplay();
    }

    void LoadGameplay()
    {
        audioSource.Stop();
        SceneManager.LoadScene("in");
    }
}
