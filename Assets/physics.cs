using UnityEngine;

public class physics : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform player;
    public SpriteRenderer shadowRenderer;
    public LayerMask groundLayer;
    public float maxRayDistance = 20f;

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(player.position, Vector2.down, maxRayDistance, groundLayer);

        if (hit.collider != null)
        {
            shadowRenderer.enabled = true;
            transform.position = new Vector2(player.position.x, hit.point.y + 0.1f);
        }
        else
        {
            shadowRenderer.enabled = false;
        }
    }
}
