using System.Collections.Generic;
using UnityEngine;
using Zappar;

public class Test : MonoBehaviour
{
    public GameObject greyPanel;

    public List<Renderer> parts;
    public Material mat1;
    public Material mat2;

    public ZapparInstantTrackingTarget instant;

    public GameObject placeButtonObject;
    public GameObject resetButtonObject;

    public GameObject matPanel;

    private void Start()
    {
        greyPanel.SetActive(false);
        Mat1();
    }

    public void MatPanel(bool value)
    {
        matPanel.SetActive(value);
    }

    public void PlaceModel()
    {
        instant.PlaceTrackerAnchor();

        placeButtonObject.SetActive(false);
        resetButtonObject.SetActive(true);
    }

    public void ResetModel()
    {
        instant.ResetTrackerAnchor();

        placeButtonObject.SetActive(true);
        resetButtonObject.SetActive(false);
    }

    public void Mat1()
    {
        foreach (Renderer renderer in parts)
        {
            renderer.material = mat1;
        }
    }

    public void Mat2()
    {
        foreach (Renderer renderer in parts)
        {
            renderer.material = mat2;
        }
    }
}