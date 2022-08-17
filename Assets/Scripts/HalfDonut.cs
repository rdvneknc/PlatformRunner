using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfDonut : MonoBehaviour
{
    public float speed;
    public float lenght;
    public float delay;

    public Vector3 direction;
    private Vector3 startPosition;


    private void Start()
    {
        startPosition = transform.position;

        StartCoroutine(IPlayAnimation());
    }
    private IEnumerator IPlayAnimation()
    {
        while (true)
        {
            yield return new WaitForEndOfFrame();

            var targetPos = startPosition + direction * lenght;
            float dist = Vector3.Distance(transform.position, targetPos);
            transform.position = Vector3.Lerp(transform.position, targetPos, speed * Time.deltaTime);

            if (dist < 0.1f)
            {
                direction *= -1;
                yield return new WaitForSeconds(delay);
            }
        }
    }

}
