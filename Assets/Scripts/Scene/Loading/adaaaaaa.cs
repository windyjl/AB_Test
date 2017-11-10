using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


public class adaaaaaa : MonoBehaviour {

	// Use this for initialization
	void Start () {

        //loadScene();
        loadObject();
    }
    // Update is called once per frame
    void Update () {
		
	}
    void loadObject()
    {
        var myLoadedAssetBundle = AssetBundle.LoadFromFile(Application.dataPath + "/AssetBundles/startgame.something");
        if (myLoadedAssetBundle == null)
        {
            Debug.Log("Failed to load AssetBundle!");
            return;
        }
        var prefab = myLoadedAssetBundle.LoadAsset<GameObject>("Enemy1");
        Instantiate(prefab);
    }
    void loadScene()
    {
        var myLoadedAssetBundle = AssetBundle.LoadFromFile(Application.dataPath + "/AssetBundles/startgame.scene");
        if (myLoadedAssetBundle == null)
        {
            Debug.Log("Failed to load AssetBundle!");
            return;
        }
        string[] scenePath = myLoadedAssetBundle.GetAllScenePaths();
        UnityEngine.SceneManagement.SceneManager.LoadScene(scenePath[0]);
    }
}
