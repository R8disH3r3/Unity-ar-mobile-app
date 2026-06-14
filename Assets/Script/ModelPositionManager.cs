using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelPositionManager : MonoBehaviour
{
    void Start()
    {
        LoadModelPosition();
    }

    void OnApplicationQuit()
    {
        SaveModelPosition();
    }

    public void SaveModelPosition()
    {
        PlayerPrefs.SetFloat("ModelPosX", transform.position.x);
        PlayerPrefs.SetFloat("ModelPosY", transform.position.y);
        PlayerPrefs.SetFloat("ModelPosZ", transform.position.z);

        PlayerPrefs.SetFloat("ModelRotX", transform.rotation.eulerAngles.x);
        PlayerPrefs.SetFloat("ModelRotY", transform.rotation.eulerAngles.y);
        PlayerPrefs.SetFloat("ModelRotZ", transform.rotation.eulerAngles.z);

        PlayerPrefs.Save(); // Save it to disk
    }

    public void LoadModelPosition()
    {
        if (PlayerPrefs.HasKey("ModelPosX"))
        {
            float x = PlayerPrefs.GetFloat("ModelPosX");
            float y = PlayerPrefs.GetFloat("ModelPosY");
            float z = PlayerPrefs.GetFloat("ModelPosZ");

            float rx = PlayerPrefs.GetFloat("ModelRotX");
            float ry = PlayerPrefs.GetFloat("ModelRotY");
            float rz = PlayerPrefs.GetFloat("ModelRotZ");

            transform.position = new Vector3(x, y, z);
            transform.rotation = Quaternion.Euler(rx, ry, rz);
        }
    }
}
