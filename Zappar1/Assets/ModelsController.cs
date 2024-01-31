using System.Collections.Generic;
using DynamicBox.EventManagement;
using UnityEngine;

public class ModelsController : MonoBehaviour
{
    [Header("Links")] [SerializeField] private Test test;
    [SerializeField] private List<GameObject> modelsInScene;
    [SerializeField] private Transform modelParent;
    // [SerializeField] private TMP_Text text;

    private int index;

    void OnEnable()
    {
        EventManager.Instance.AddListener<ChangeModelEvent>(ChangeModelEventHandler);
    }

    void OnDisable()
    {
        EventManager.Instance.RemoveListener<ChangeModelEvent>(ChangeModelEventHandler);
    }

    void Start()
    {
        // SpawnNewModel(0);
        // Show(0);
    }

    public void Next()
    {
        EventManager.Instance.Raise(new ChangeModelEvent(ModelsChangeType.Next));
    }

    public void Previous()
    {
        EventManager.Instance.Raise(new ChangeModelEvent(ModelsChangeType.Previous));
    }

    private void DestroyCurrentModel()
    {
        foreach (Transform child in modelParent)
        {
            if (child.CompareTag("Model"))
            {
                Destroy(child.gameObject);
            }
        }
    }

    private void HideAll()
    {
        foreach (GameObject prefab in modelsInScene)
        {
            prefab.SetActive(false);
        }
    }

    private void Show(int index)
    {
        modelsInScene[index].SetActive(true);

        test.MatPanel(index == 0);
    }

    private void SpawnNewModel(int index)
    {
        // text.text = index.ToString ();
        // GameObject model = Instantiate(models[index], modelParent);
    }

    private void ChangeModelEventHandler(ChangeModelEvent eventDetails)
    {
        if (eventDetails.ModelsChangeType == ModelsChangeType.Next)
        {
            index++;
            if (index >= modelsInScene.Count)
            {
                index = 0;
            }
        }
        else
        {
            index--;
            if (index < 0)
            {
                index = modelsInScene.Count - 1;
            }
        }

        // DestroyCurrentModel();
        // SpawnNewModel(index);

        HideAll();
        Show(index);
    }
}