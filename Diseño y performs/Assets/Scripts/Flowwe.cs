using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName="Setings", menuName="SetingsMenu")]
public class Flowwe : ScriptableObject

{
    public int SwarmIndex;
    public float NoClumpingRadius = 5f;
    public float LocalAreaRadius = 5f;
    public float Speed = 10f;
    public float SteeringSpeed = 100f;


}
