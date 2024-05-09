using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("mode", true);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            animator.SetBool("mode", false);
        }
    }
}
