using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObjects : MonoBehaviour
{
    [Header("Wheels")]
    public List<AxleInfo> axleInfos;
    [Header("Rigidbody")]
    public Rigidbody rb;
}

[System.Serializable]
public class AxleInfo 
{
    public WheelCollider leftWheel;
    public WheelCollider rightWheel;
    public bool motor;
}

