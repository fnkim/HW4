using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _jump;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private Animator pigeonAnimator;
    //delegate stuff
    public delegate void Delegate();
    public event Delegate GotPoint;

    public event Delegate Died;
    public event Delegate Flapped;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Flapped?.Invoke();
            
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _jump);
            
            pigeonAnimator.SetTrigger("Flap");
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Death")
        {
            Died?.Invoke();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        
        if (other.gameObject.tag == "PointCollider")
        {
            Debug.Log("Got Point");
            GotPoint?.Invoke();
        }

        

    }



}
