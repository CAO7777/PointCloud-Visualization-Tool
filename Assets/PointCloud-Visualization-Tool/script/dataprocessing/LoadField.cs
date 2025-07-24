using UnityEngine;
using UnityEditor;
using System.IO;
using System;

public class LoadField : MonoBehaviour
{
static public Texture3D LoadTexture3D(string filename)
    {
        Texture3D loadedTexture3D = AssetDatabase.LoadAssetAtPath<Texture3D>(filename);
        if (loadedTexture3D == null)
        {
            UnityEngine.Debug.LogError("Failed to load Texture3D asset at: " + filename);
            return null;
        }

        return loadedTexture3D;
        
        }
    
}
