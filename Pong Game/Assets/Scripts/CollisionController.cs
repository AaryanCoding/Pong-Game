using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public BallMovement ballMovement;

    void BounceFromRacket(Collision2D c)
    {
        Vector3 ballPosition = this.transform.position;
        Vector3 racketPosition = c.gameObject.transform.position;

        float racketHeight = c.collider.bounds.size.y;

        float x;

        if(c.gameObject.name == "RacketPlayer1")
        {
            x = 1;
        }
        else
        {
            x = -1;
        }
    }
}
