using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizer : MonoBehaviour
{
    public GameObject[] Mazes;
    public float height;
    private GameObject cur;
    private float timer = 0;
    private float[] total_timer = { 5, 5.5f, 5.7f, 6.3f};
    private int l = 0;
    void Start()
    {
        int r = Random.Range(0, 5);
        cur = Instantiate(Mazes[r]);
        l = r;
        cur.transform.position = new Vector3(0, 0, 0);
    }
    void Update()
    {
        if (timer < total_timer[3])
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
        }
        if (timer < total_timer[0])
        {
            return;
        }
        else if (timer < total_timer[1])
        {
            cur.transform.position -= new Vector3(0, height, 0);
        }
        else if (timer < total_timer[2])
        {
            Destroy(cur);
            int r = l;
            while(l == r)
            {
                r = Random.Range(0, 5);
            }
            l = r;
            cur = Instantiate(Mazes[r]);
            cur.transform.position = new Vector3(0,-25f,0);
            timer = total_timer[2];
        }
        else if (cur.transform.position.y < 0)
        {
            cur.transform.position += new Vector3(0, height, 0);
        }
    }
}
