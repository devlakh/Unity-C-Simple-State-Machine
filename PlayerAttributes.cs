using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttributes : MonoBehaviour
{
    [Header("Drive Settings")]
    public float maxMotorTorque = 1000f;
	public float rotationTorque = 250;

    [Header("Health Settings")]
    public float health = 100f;
    public float maxHealth = 100f;

    [Header("Jump Time")]
    public float jumpClimb = 10f;
    public float jumpHang = 10f;
    public float jumpFall = 10f;
    
}

