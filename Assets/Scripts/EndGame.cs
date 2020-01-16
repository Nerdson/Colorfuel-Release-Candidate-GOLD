using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(GameEnds());
    }

    IEnumerator GameEnds()
    {
        yield return new WaitForSeconds(61f);
        Debug.Log("Game is ending");
        Application.Quit();
    }
}
