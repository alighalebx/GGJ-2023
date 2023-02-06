using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swicher : MonoBehaviour
{
    bool move;
    public GameObject w1;
    public GameObject w2;
    public GameObject w3;
    public GameObject w4;
    float timer;
    public MeshRenderer s;
    public MeshRenderer left;
    public MeshRenderer right;
    public Animator al;
    public Animator ar;
    // Start is called before the first frame update
    void Start()
    {
        move = false;
        timer = 20;
        left.enabled = false;
        right.enabled = false;
        s.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if( timer > 1.4 && timer < 3)
        {
            move = true;
            left.enabled = false;
            right.enabled = false;
        }
        else if ( timer > 3)
        {
            timer = 1000000;
        }
        if (move)
        {
            w1.transform.position = Vector3.Lerp(w1.transform.position, w2.transform.position, timer*Time.deltaTime);
            w3.transform.position = Vector3.Lerp(w3.transform.position, w4.transform.position, timer*Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            timer = 0;
            left.enabled = true;
            right.enabled = true;
            s.enabled = false;
            ar.enabled = true;
            al.enabled = true;
        }
    }
}
