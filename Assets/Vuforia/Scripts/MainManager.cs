using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class MainManager : MonoBehaviour
{
    public GameObject[] videoPlayer;
    public int CurrentPlayer = 0;
    // Start is called before the first frame update
    void Start()
    {
        DisableAll();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play(int video)
    {
        videoPlayer[video].SetActive(true);

        videoPlayer[video].GetComponent<VideoPlayer>().Play();    
    }

    public void DisableAll() {
        foreach (var item in videoPlayer)
        {
            item.SetActive(false);
        }
    }
}
