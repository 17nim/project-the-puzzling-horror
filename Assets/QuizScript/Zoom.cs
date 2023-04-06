using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    public GameObject sphere;
    public Vector3 scaleChange, positionChange;
     void Awake()
    {
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        GameObject plane = GameObject.CreatePrimitive(PrimitiveType.Plane);
        plane.transform.position = new Vector3(0, -0.5f, 0);
        Renderer rend = plane.GetComponent<Renderer>();
        rend.material = Resources.Load<Material>("blue");

        scaleChange = new Vector3(5, 5, 5);
        positionChange = new Vector3(0.0f, -0.005f, 0.0f);
    }

      void Update()
    {
        sphere.transform.localScale += scaleChange;
        sphere.transform.position += positionChange;
        if (sphere.transform.localScale.y < 0.1f || sphere.transform.localScale.y > 1.0f)
        {
            scaleChange = -scaleChange;
            positionChange = -positionChange;
        }
    }
}
