using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneEnter2 : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject cutsceneCam;

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        cutsceneCam.SetActive(true);
        thePlayer.SetActive(false);
        StartCoroutine(SecondFinishCut());
    }

    IEnumerator SecondFinishCut()
    {
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene("BadEnding", LoadSceneMode.Single);
    }
}
