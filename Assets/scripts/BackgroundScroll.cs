using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{

    private Transform cameraTransform;
    private Vector3 lastCameraPosition;
    [SerializeField] private Vector2 effectMultiplier;

    // Start is called before the first frame update
    private void Start()
    {
        cameraTransform = Camera.main.transform;
        lastCameraPosition = cameraTransform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 deltaMovement = cameraTransform.position - lastCameraPosition;
        transform.position += new Vector3(deltaMovement.x * effectMultiplier.x,
                                            deltaMovement.y * effectMultiplier.y);
        lastCameraPosition = cameraTransform.position;
        
    }
}
