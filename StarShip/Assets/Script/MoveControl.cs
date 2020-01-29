using UnityEngine;
using UnityEngine.EventSystems;

public class MoveControl : MonoBehaviour
{
    public GameObject moveSpaceShip;
    public bool _isMoving;
    public float speed = 8f;
    void Update()
    {
        if (_isMoving)
        {
            float Y = Input.GetAxis("Mouse Y") * speed * Time.deltaTime;
            float X = Input.GetAxis("Mouse X") * speed * Time.deltaTime;
            moveSpaceShip.transform.Translate(X, 0, 0);
            moveSpaceShip.transform.Translate(0, Y, 0);
        }
    }
    void OnMouseDown()
    {
        _isMoving = true;
        Cursor.visible = false;
    }
    void OnMouseUp()
    {
        Cursor.visible = true;
        _isMoving = false;
    }
}

