using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zappar;

public class Test : MonoBehaviour
{
    public GameObject greyPanel;
    public Renderer cube;

    public List<Renderer> parts;
    public Material mat1;
    public Material mat2;

    public ZapparInstantTrackingTarget instant;

    public GameObject placeButtonObject;
    public GameObject resetButtonObject;

    private void Start()
    {
        greyPanel.SetActive(false);
        Mat1();
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

        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Mat1() 
    {
        // cube.material = mat1;

        foreach (Renderer renderer in parts)
        {
            renderer.material = mat1;
        }
    }

    public void Mat2()
    {
        // cube.material = mat2;

        foreach (Renderer renderer in parts)
        {
            renderer.material = mat2;
        }
    }
}