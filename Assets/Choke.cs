using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choke : MonoBehaviour
{
    private float timeToChoke = 1;
    public void doChoke()
    {
        ControlArduino.sendChoke();
        StartCoroutine(stop());
    }

    IEnumerator stop()
    {
        yield return new WaitForSeconds(timeToChoke);
        ControlArduino.sendStop();
    }
}
