using UnityEngine;
using UnityEngine.SceneManagement;

public class Cat : MonoBehaviour
{
    [SerializeField] private float _launchPower = 500;
    
    private Vector3 _initialPosition; //Vec3 ~ x, y, z cords lementve
    private bool _birdWasLaunched;
    private float _timeSittingAround;

    private void Awake()
    {
        _initialPosition = transform.position;
    }

    private void Update()
    {   
        GetComponent<LineRenderer>().SetPosition(0, transform.position);
        GetComponent<LineRenderer>().SetPosition(1, _initialPosition); //indik?tor vonal a cic?t?l --> a kezd? pontba

        if (_birdWasLaunched && GetComponent<Rigidbody2D>().velocity.magnitude <= 0.1)
        {
            _timeSittingAround += Time.deltaTime;
        }

        if (transform.position.y > 35 ||
            transform.position.y < -35 ||
            transform.position.x > 35 ||
            transform.position.x < -45 ||
            _timeSittingAround > 3 ||
                Input.GetKeyDown(KeyCode.R))
        {
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }
    }

    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
        GetComponent<LineRenderer>().enabled = true; // line renderer (indik?tor) bekapcsolva
    }

    private void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
        Vector2 directonToInitialPosition = _initialPosition - transform.position;
        GetComponent<Rigidbody2D>().AddForce(directonToInitialPosition * _launchPower);
        GetComponent<Rigidbody2D>().gravityScale = 1;
        _birdWasLaunched = true;

        GetComponent<LineRenderer>().enabled = false; // line renderer (indik?tor) kikapcsolva
    }

    private void OnMouseDrag()
    {
        Vector3 newposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);  // monitor f?ggetlen lesz(Camera.main)
        transform.position = new Vector3(Mathf.Clamp(newposition.x, _initialPosition.x -10f, _initialPosition.x +10f),
            Mathf.Clamp(newposition.y, _initialPosition.y -5f, _initialPosition.y +10f)); //mozgat?s + az initial possition-t?l,
                                                                                           //ami a macska kezd? ?llapota 10x10 box-on bel?l tud mozogni
    }
}
