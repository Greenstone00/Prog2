using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClampCat : MonoBehaviour
{
    private Vector3 _initialPosition;

    private void Awake()
    {
        _initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(_initialPosition.x, -10f, 10f),
            Mathf.Clamp(_initialPosition.y, -10, 10), _initialPosition.z);
    }
}
