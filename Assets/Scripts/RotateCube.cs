using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    private Transform cube;
    // Start is called before the first frame update
    void Start()
    {
        cube = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        cube.Rotate(Vector3.one * 50.0f * Time.deltaTime);
    }
}
