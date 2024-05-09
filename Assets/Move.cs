using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    //アニメターコントローラー
    public Animator animator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 velocity = new Vector3(0, 0, 1.0f);
            transform.position += transform.rotation * velocity*Time.deltaTime;
            animator.SetBool("mode",true);
        }
        else
        {
            animator.SetBool("mode",false);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 worldAngle = transform.eulerAngles;
            worldAngle.y += 1.0f;
            transform.eulerAngles= worldAngle;
        }
    }
}
