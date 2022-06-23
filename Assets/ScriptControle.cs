using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptControle : MonoBehaviour
{
    private Animator Anim;
    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) Anim.SetBool("Jump", true);
    }
}
