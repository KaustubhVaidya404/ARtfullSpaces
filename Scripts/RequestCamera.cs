using UnityEngine;
using UnityEngine.Android;

public class CameraPermission : MonoBehaviour
{
    void Start()
    {
        RequestCameraPermission();
    }

    void RequestCameraPermission()
    {
        if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
        {
            Permission.RequestUserPermission(Permission.Camera);
        }
    }
}
