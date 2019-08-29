using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    // Parameters
    [SerializeField] int breakableBlocks;   // Serialized for debugging purpose

    // Cached referece
    SceneLoader sceneLoader;

    private void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();    
    }

    public void CountBlocks()
    {
        breakableBlocks++;
    }

    public void BlockDestoryed()
    {
        breakableBlocks--;
        if (breakableBlocks <= 0)
        {
            sceneLoader.LoadNextScene();
        }
    }
}
