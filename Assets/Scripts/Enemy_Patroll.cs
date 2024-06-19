using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Patroll : MonoBehaviour
{
    const string LEFT = "left";
    const string RIGHT = "right";
    [SerializeField] Transform castPos;
    [SerializeField] float baseCastDist;
    string facingDirection;
    Vector3 baseScale;
    Rigidbody2D rb2d;
    float moveSpeed = 5;

    private void Start()
    {
        baseScale = transform.localScale;
        facingDirection = RIGHT;
        rb2d = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        float vX = moveSpeed;
        if (facingDirection == LEFT)
            vX = -moveSpeed;

        rb2d.velocity = new Vector2(vX, rb2d.velocity.y);
        
        if (IsNearEdge())
        {
            if (facingDirection == LEFT)
                ChangeFacingDirection(RIGHT);
            else
                ChangeFacingDirection(LEFT);
        }
    }

    void ChangeFacingDirection(string newDirection)
    {
        Vector3 newScale = baseScale;
        if (newDirection == LEFT)
            newScale.x = -baseScale.x;
        else
            newScale.x = baseScale.x;
        transform.localScale = newScale;
        facingDirection = newDirection;
    }

    bool IsNearEdge()
    {
        bool val = true;
        float castDist = baseCastDist;

        Vector3 targetPos = castPos.position;
        targetPos.y -= castDist;

        Debug.DrawLine(castPos.position, targetPos, Color.black);

        if (Physics2D.Linecast(castPos.position, targetPos, 1 << LayerMask.NameToLayer("Ground")))
            val = false;
        else
            val = true;

        return val;
    }

}
