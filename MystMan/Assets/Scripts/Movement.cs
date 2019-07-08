using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float mSpeed;
    // Start is called before the first frame update
    void Start()
    {
        mSpeed = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-1 * mSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, -1 * mSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
        /*
       if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;
            position.x++;
            this.transform.position = position;
        }
        else if ((Input.GetKeyDown(KeyCode.RightArrow)))
        {
            Vector3 position = this.transform.position;
            position.x--;
            this.transform.position = position;
        }
        else if ((Input.GetKeyDown(KeyCode.UpArrow)))
        {
            Vector3 position = this.transform.position;
            position.z--;
            this.transform.position = position;
        }
        else if ((Input.GetKeyDown(KeyCode.DownArrow)))
        {
            Vector3 position = this.transform.position;
            position.z++;
            this.transform.position = position;
        }
        */
    }
}
