using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirsPlaneCamera : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public Vector3 offset;
    public float lerp;
    public float planoCorte;

    private Camera thisCamera;


    void Start()
    {
        thisCamera = gameObject.GetComponent<Camera>();
        gameObject.transform.position = player.position + offset;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, player.position + offset, lerp);
        thisCamera.nearClipPlane = planoCorte;
    }
}
