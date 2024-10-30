using UnityEngine;
using UnityEngine.UI;
public class PanelOptions : MonoBehaviour
{
    private static PanelOptions Instance { get; set; }
    public RectTransform optionsPanel;
    public Vector3 hiddenPosition = new Vector3(1537f, 0f, 0f);
    public Vector3 visiblePosition = Vector3.zero;
    public float smoothTime = 0.3f;

    public float sliderValue = 0f;
    public Slider brilloSlider;
    public Image panelBrillo;
    public Image menu;

    private Vector3 velocity = Vector3.zero;
    private bool isOptionsVisible = false;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        brilloSlider.value = PlayerPrefs.GetFloat("brillo", 0f);
        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g, panelBrillo.color.b, brilloSlider.value);
        optionsPanel.localPosition = hiddenPosition;
    }
    void Update()
    {
        Vector3 targetPosition;

        if (isOptionsVisible)
        {
            targetPosition = visiblePosition;
        }
        else
        {
            targetPosition = hiddenPosition;
        }
        optionsPanel.localPosition = Vector3.SmoothDamp(optionsPanel.localPosition, targetPosition, ref velocity, smoothTime);
    }
    public void ToggleOptions()
    {
        isOptionsVisible = !isOptionsVisible;
    }
    public void UpdateBrillo(float newBrillo)
    {
        sliderValue = newBrillo;
        PlayerPrefs.SetFloat("brillo", sliderValue);
        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g, panelBrillo.color.b, brilloSlider.value);
    }
}