﻿using UnityEngine;


public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "Obstacle")
        {
            movement.enabled = false;
        }
    }


}
    
