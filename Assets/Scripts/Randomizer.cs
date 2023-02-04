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
    int l = 0;
    // Start is called before the first frame update
    void Start()
    {
        int r = Random.Range(0, 5);
        cur = Instantiate(Mazes[r]);
        l = r;
        cur.transform.position = new Vector3(0,0,0);
    }
    // Update is called once per frame
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
            cur.transform.position = new Vector3(0,-2.5f,0);
            timer = total_timer[2];
        }
        else
        {
            cur.transform.position += new Vector3(0, height, 0);
        }
    }
}
