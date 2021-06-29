using UnityEngine;

public class CameraObjFollow : MonoBehaviour
{
    public Transform Target;
    public Vector3 Offset;
    public float SpeedT = 5f;
    public float SpeedR = 5f;

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 finalPos = Target.position + (Target.rotation * Offset);
        Vector3 currPos = Vector3.Lerp(transform.position, finalPos, SpeedT * Time.deltaTime);
        transform.position = currPos;
        //Quaternion finalRot = Quaternion.LookRotation(Target.forward, Target.up);
        Quaternion finalRot = Target.rotation;
        Quaternion currRot = Quaternion.Slerp(transform.rotation, finalRot, SpeedR * Time.deltaTime);
        transform.rotation = currRot;
    }
}