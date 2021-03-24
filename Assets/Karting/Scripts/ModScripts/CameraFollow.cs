using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	public GameObject FollowTarget;
	public GameObject LookAtTarget;
	public float cameraVelocity = 3;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()//depois do update
    {
		//faz a camera seguir o player de uma forma mais fluida/suave
        transform.position = Vector3.Lerp(transform.position, FollowTarget.transform.position, Time.smoothDeltaTime * cameraVelocity);
		//faz a camera virar para a direcao do player
		transform.LookAt(LookAtTarget.transform);
    }
}
