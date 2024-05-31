using UnityEngine;
using UnityEngine.UI;

public class AlphaButtonMask : MonoBehaviour
{
    [SerializeField] float alphaThreshold = 0.1f;

    void Awake() {
        GetComponent<Image>().alphaHitTestMinimumThreshold = alphaThreshold;
    }
}