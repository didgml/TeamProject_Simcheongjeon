using UnityEngine;
using UnityEngine.SceneManagement;

public class Experiment : MonoBehaviour
{
    public SpriteRenderer targetSprite;
    public Vector3 max;
    public Vector3 min;
    public Transform cursorTransform;

    private float camHeight;
    private float camWidth;

    private static int stageLevel = 0;

    private void Start()
    {
        if (targetSprite == null)
            targetSprite = GetComponent<SpriteRenderer>();

        camHeight = Camera.main.orthographicSize;
        camWidth = camHeight * Screen.width / Screen.height;

        InitCursor();

        if (stageLevel > 0)
            SceneManager.LoadScene(stageLevel);
    }

    private void Update()
    {
        UpdateMousePosition();
        FlipCursor();
    }

    private void InitCursor()
    {
        Cursor.visible = false;
    }

    private void UpdateMousePosition()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        cursorTransform.position = mousePos;

        float clampedX = Mathf.Clamp(
            cursorTransform.position.x,
            -camWidth + targetSprite.bounds.size.x * 0.5f,
            camWidth - targetSprite.bounds.size.x * 0.5f
        );

        float clampedY = Mathf.Clamp(
            cursorTransform.position.y,
            -camHeight + targetSprite.bounds.size.y * 0.5f,
            camHeight - targetSprite.bounds.size.y * 0.5f
        );

        transform.position = new Vector3(clampedX, clampedY, 0);
    }

    private void FlipCursor()
    {
        float deltaX = Input.GetAxis("Mouse X");

        if (deltaX > 0.01f)
        {
            cursorTransform.localScale = new Vector3(1, 1, 1);
        }
        else if (deltaX < -0.01f)
        {
            cursorTransform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
