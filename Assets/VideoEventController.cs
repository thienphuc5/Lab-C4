using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoEventController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject endUI;   // UI hiện khi video kết thúc

    void Start()
    {
        // Đăng ký event
        videoPlayer.prepareCompleted += OnVideoPrepared;
        videoPlayer.loopPointReached += OnVideoFinished;

        // Chuẩn bị video
        

        videoPlayer.Prepare();
    }

    void OnVideoPrepared(VideoPlayer vp)
    {
        Debug.Log("Video prepared!");
        vp.Play();
    }

    void OnVideoFinished(VideoPlayer vp)
    {
        Debug.Log("Video finished!");

        // Cách 1: Hiện UI
        if (endUI != null)
        {
            endUI.SetActive(true);
        }

        // Cách 2: Chuyển scene (comment lại nếu chưa dùng)
        // SceneManager.LoadScene("MainMenu");
    }
}
