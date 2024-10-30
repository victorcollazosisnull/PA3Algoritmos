using UnityEngine;

public class PanelCredits : MonoBehaviour
{
    public RectTransform optionsCredits;
    public Vector3 hiddenPosition = new Vector3(-1537f, 0f, 0f);
    public Vector3 visiblePosition = Vector3.zero;
    public float smoothTime = 0.3f;

    private Vector3 velocity = Vector3.zero;
    private bool isOptionsVisible = false;
    void Start()
    {
        optionsCredits.localPosition = hiddenPosition;
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
        optionsCredits.localPosition = Vector3.SmoothDamp(optionsCredits.localPosition, targetPosition, ref velocity, smoothTime);
    }
    public void ToggleOptionsCredits()
    {
        isOptionsVisible = !isOptionsVisible;
    }
}
