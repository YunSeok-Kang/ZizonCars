using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(SkillSystemRoot))]
public class SkillSystemRootEditor : Editor
{
    void OnEnable()
    {
        SkillSystemRoot targetComponent = target as SkillSystemRoot;
        VehicleControl vehicleControl = targetComponent.gameObject.GetComponent<VehicleControl>();
        if (vehicleControl == null)
        {
            Debug.LogError("해당 스크립트가 Attach 되기 위해서는 VehicleControl 스크립트가 존재하여야 합니다.");
            DestroyImmediate(targetComponent);
        }
    }
}
