using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class VideoController : MonoBehaviour
{
    public VideoClip[] videoClips;
    private VideoPlayer videoPlayer;
    private int videoClipIndex;

    public GameObject[] canvas;

    public AudioSource fireAlarm;

    void Awake() {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    void Start()
    {
        fireAlarm = GetComponent<AudioSource>();
        fireAlarm.Stop();
    }

    public void StartEvacuation() {
        playNext(0);
        //canvas[0].SetActive(false);
        videoPlayer.loopPointReached += ActivateCanvas1;
    }

    public void tolong1A() {
        playNext(1);
        //canvas[1].SetActive(false);
        videoPlayer.loopPointReached += ActivateCanvas1B3;
        //fireAlarm.Play();
    }

    public void biarkan1B() {
        playNext(2);
        //canvas[1].SetActive(false);
        videoPlayer.loopPointReached += ActivateCanvas1B;
    }

    public void CekKebarakan1B2() {
        playNext(3);
        //canvas[2].SetActive(false);
        videoPlayer.loopPointReached += ActivateCanvas1B2;
    }

    public void Lari1B3() {
        playNext(4);
        //canvas[3].SetActive(false);
        videoPlayer.loopPointReached += ActivateCanvas1B3;
    }

    public void SusulTeman() {
        playNext(5);
        //canvas[4].SetActive(false);
        videoPlayer.loopPointReached += ActivateCanvas2;
    }
    
    public void LanjutSusul() {
        playNext(7);
        //canvas[5].SetActive(false);
        videoPlayer.loopPointReached += ActivateCanvas3;
    }

    public void FireAlarm() {
        playNext(6);
        //canvas[5].SetActive(false);
        videoPlayer.loopPointReached += ActivateCanvas2A;
    }

    public void Lift3A() {
        playNext(8);
        //canvas[6].SetActive(false);
        videoPlayer.loopPointReached += ActivateCanvas4A;
    }

    public void Tangga3B() {
        playNext(10);
        //canvas[6].SetActive(false);
        videoPlayer.loopPointReached += ActivateCanvas4B;
    }
    
    public void Lift4A() {
        playNext(9);
        //canvas[6].SetActive(false);
        videoPlayer.loopPointReached += ActivateCanvasMati;
    }

    public void Tangga4B() {
        playNext(11);
        //canvas[6].SetActive(false);
        videoPlayer.loopPointReached += ActivateCanvasEvac;
    }

    public void Evac() {
        playNext(12);
        //canvas[6].SetActive(false);
        videoPlayer.loopPointReached += ActivateCanvasSelamat;

        fireAlarm.Stop();
    }

    public void playNext(int i) {
        videoPlayer.clip = videoClips[i];

        for (int x = 0; x < canvas.Length; x++) {
            canvas[x].SetActive(false);
            Debug.Log("Canvas " + x + "deactivated");
        }
    }

    void ActivateCanvas1(VideoPlayer vp) {
        for (int x = 0; x < canvas.Length; x++) {
            canvas[x].SetActive(false);
            Debug.Log("Canvas " + x + "deactivated");
        }

        canvas[1].SetActive(true);
    }

    void ActivateCanvas1B(VideoPlayer vp) {
        for (int x = 0; x < canvas.Length; x++) {
            canvas[x].SetActive(false);
            Debug.Log("Canvas " + x + "deactivated");
        }

        canvas[2].SetActive(true);
        //fireAlarm.Play();
    }

    void ActivateCanvas1B2(VideoPlayer vp) {
        for (int x = 0; x < canvas.Length; x++) {
            canvas[x].SetActive(false);
            Debug.Log("Canvas " + x + "deactivated");
        }

        canvas[3].SetActive(true);
    }

    void ActivateCanvas1B3(VideoPlayer vp) {
        for (int x = 0; x < canvas.Length; x++) {
            canvas[x].SetActive(false);
            Debug.Log("Canvas " + x + "deactivated");
        }

        canvas[4].SetActive(true);
        //fireAlarm.Play();
    }

    void ActivateCanvas2(VideoPlayer vp) {
        for (int x = 0; x < canvas.Length; x++) {
            canvas[x].SetActive(false);
            Debug.Log("Canvas " + x + "deactivated");
        }

        canvas[5].SetActive(true);
    }

    void ActivateCanvas3(VideoPlayer vp) {
        for (int x = 0; x < canvas.Length; x++) {
            canvas[x].SetActive(false);
            Debug.Log("Canvas " + x + "deactivated");
        }

        canvas[6].SetActive(true);
    }

    void ActivateCanvas4A(VideoPlayer vp) {
        for (int x = 0; x < canvas.Length; x++) {
            canvas[x].SetActive(false);
            Debug.Log("Canvas " + x + "deactivated");
        }

        canvas[7].SetActive(true);
    }

    void ActivateCanvas4B(VideoPlayer vp) {
        for (int x = 0; x < canvas.Length; x++) {
            canvas[x].SetActive(false);
            Debug.Log("Canvas " + x + "deactivated");
        }

        canvas[8].SetActive(true);
    }

    void ActivateCanvas2A(VideoPlayer vp) {
        for (int x = 0; x < canvas.Length; x++) {
            canvas[x].SetActive(false);
            Debug.Log("Canvas " + x + "deactivated");
        }

        canvas[9].SetActive(true);
        fireAlarm.Play();
    }

    void ActivateCanvasSelamat(VideoPlayer vp) {
        for (int x = 0; x < canvas.Length; x++) {
            canvas[x].SetActive(false);
            Debug.Log("Canvas " + x + "deactivated");
        }

        canvas[10].SetActive(true);
    }

    void ActivateCanvasEvac(VideoPlayer vp) {
        for (int x = 0; x < canvas.Length; x++) {
            canvas[x].SetActive(false);
            Debug.Log("Canvas " + x + "deactivated");
        }

        canvas[12].SetActive(true);
    }

    void ActivateCanvasMati(VideoPlayer vp) {
        for (int x = 0; x < canvas.Length; x++) {
            canvas[x].SetActive(false);
            Debug.Log("Canvas " + x + "deactivated");
        }

        canvas[11].SetActive(true);
    }
}
