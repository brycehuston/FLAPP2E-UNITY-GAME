using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

#if UNITY_WEBGL

public class WebGLSignOut : MonoBehaviour
{
    public AudioSource soundPlayer;
    public void OnSignOut()
    {
        // Clear Account
        PlayerPrefs.SetString("Account", "0x0000000000000000000000000000000000000001");
        // go to login scene
        SceneManager.LoadScene(0);
    }
        public void playThisSoundEffect()
    {
        soundPlayer.Play();
    }

}
#endif