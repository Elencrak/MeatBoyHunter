using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        rigidBody.MovePosition( transform.position +  new Vector3( Input.GetAxis( "Horizontal" ), 0, 0 )* speed );
        
        if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown( KeyCode.Z ) )
        {
            RaycastHit hit;
            if(Physics.Raycast(transform.position,  - Vector3.up , out hit, 1.5f ) )
                if( hit.transform.tag == "Jumpable")
                {
                    rigidBody.AddForce( Vector3.up* jumpForce );
                }
        }
	}

    [SerializeField]
    private float speed = 15.0f;
    [SerializeField]
    private float jumpForce = 15.0f;

    private Rigidbody rigidBody;
}
