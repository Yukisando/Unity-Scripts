using System;
using System.Collections;
using Sirenix.OdinInspector;
using UnityEngine;

public class FakeKeyboarder : MonoBehaviour
{
    [SerializeField] string input = "abs";
    [SerializeField] float inputDelay = .05f;
    event Action<string> OnType;

    [Button]
    public void StartTyping() {
        StartCoroutine(_FakeType());
    }

    IEnumerator _FakeType() {
        foreach (char c in input) {
            yield return new WaitForSeconds(inputDelay);
            OnType?.Invoke(c.ToString());
        }
    }
}