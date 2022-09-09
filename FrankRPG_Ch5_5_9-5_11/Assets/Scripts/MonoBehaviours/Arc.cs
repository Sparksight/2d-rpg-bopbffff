using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arc : MonoBehaviour
{
    public IEnumerator TravelArc(Vector3 destination, float duration)
    {
        var startPosition = transform.position;
        var personComplete = 0.0f;
        while (percentComplete <= 1.0f)
        {
            percentComplete += deltaTime / duration
            var currentHelight = Mathf.Sin(Mathf.PI * percentComplete);
            transfrom.position = Vector3.Lep(startPosition, destination, percentComplete) + Vector3 up* currentHelight

                yield return null;
        }
        gameObject.SetActive(false);
    }


}



