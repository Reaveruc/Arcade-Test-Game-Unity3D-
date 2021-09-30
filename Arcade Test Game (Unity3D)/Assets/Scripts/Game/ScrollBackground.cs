using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour
{
    [SerializeField]
    private float speed = -2f;
    [SerializeField]
    private float lowerYValue = -20f;
    [SerializeField]
    private float upperYValue = 40;

    private void ScrolBackGround()
    {
        transform.Translate(0f, speed * Time.deltaTime, 0f);
        if (transform.position.y <= lowerYValue)
        {
            transform.Translate(0f, upperYValue, 0f);
        }
    }
    void Update()
    {
        ScrolBackGround();
    }

}
