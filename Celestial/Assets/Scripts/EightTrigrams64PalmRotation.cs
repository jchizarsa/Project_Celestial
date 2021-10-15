using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EightTrigrams64PalmRotation : MonoBehaviour
{
    [SerializeField] private float yRotation = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, yRotation * Time.deltaTime, 0f, Space.Self);
    }
}
