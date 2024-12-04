using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static System.Net.WebRequestMethods;

public class CameraController : MonoBehaviour
{
    public Transform Target = null;

    public Transform CameraArm;

    private void LateUpdate()
    {
        CalPosition();
    }

    private void CalPosition()
    {
        Vector2 mouseDelta = InputControl.instance.MouseInput;
        Vector3 camAngle = CameraArm.rotation.eulerAngles;

        CameraArm.rotation = Quaternion.Euler(camAngle.x - mouseDelta.y, camAngle.y + mouseDelta.x, camAngle.z);
    }
}
