using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    Transform _t;
    // Start is called before the first frame update
    void Start()
    {
        _t = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        _t.Rotate(Vector3.one * 50.0f * Time.deltaTime);
    }
}
