using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float speedSide;
    [SerializeField] private float thrust = 150f;
    [SerializeField] private Rigidbody rb;
    private Vector2 lastMousePos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        {
            float Player = Input.GetAxis("Horizontal") * speedSide * Time.deltaTime;
            this.transform.Translate(Player, 0, speed * Time.deltaTime);

            Vector2 deltaPos = Vector2.zero;
            if (Input.GetMouseButton(0))
            {
                Vector2 currentMousePos = Input.mousePosition;
                if (lastMousePos == Vector2.zero)
                    lastMousePos = currentMousePos;

                deltaPos = currentMousePos - lastMousePos;
                lastMousePos = currentMousePos;

                Vector3 force = new Vector3(deltaPos.x, 0, 0) * thrust;
                rb.AddForce(force);
            }
            else
            {
                lastMousePos = Vector3.zero;
            }
        }
    }


}
