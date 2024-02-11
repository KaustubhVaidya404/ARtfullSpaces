using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlanManager : MonoBehaviour
{
    public Material planMaterial;
    public Button[] buttons;
    public Button backButton;

    void Start()
    {
        foreach (var button in buttons)
        {
            RawImage rawImage = button.transform.Find("mask/RawImage").GetComponent<RawImage>();

            if (rawImage != null)
            {
                button.onClick.AddListener(() => OnClickButton(rawImage.texture));
            }
            else
            {
                Debug.LogError("RawImage component not found in the expected hierarchy for button: " + button.name);
            }
        }

        backButton.onClick.AddListener(OnBackButtonDown);
    }

    void OnBackButtonDown()
    {
        SceneManager.LoadScene("Main Menu");
    }

    void OnClickButton(Texture texture)
    {
        if (planMaterial != null)
        {
            planMaterial.mainTexture = texture;
        }
        else
        {
            Debug.LogError("PlanMaterial is not assigned in the Inspector.");
        }
    }
}
