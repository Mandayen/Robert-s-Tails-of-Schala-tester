using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    // https://www.youtube.com/watch?v=NwsUxJ3kDR4&list=PL4vbr3u7UKWp0iM1WIfRjCDTI03u43Zfu&index=7 covers the follow/smoothing element
    // https://www.youtube.com/watch?v=OWJa6lcFTXk&list=PL4vbr3u7UKWp0iM1WIfRjCDTI03u43Zfu&index=8 covers the bounding element
    public Transform target;
    public float smoothing;

    void Start()
    {
        
    }

    void LateUpdate() {
        if(transform.position != target.position)
        {
            Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
        }
    }
  
}
