using UnityEngine;
using UnityEditor;

// This attribute makes the script execute in the editor
[InitializeOnLoad]
public class KeystorePasswordSetter
{
    // Static constructor that will run once when the Unity Editor loads the project
    static KeystorePasswordSetter()
    {
        // Set your keystore and key alias passwords here
        PlayerSettings.Android.keystorePass = "keystore_pass";
        PlayerSettings.Android.keyaliasPass = "keystore_pass";

        Debug.Log("Keystore and key alias passwords are set!");
    }
}
