using UnityEngine;
using System.Collections.Generic;
using Vuforia;

public class VirtualButtonManager : MonoBehaviour, IVirtualButtonEventHandler{
    public GameObject model;
    public GameObject video;
    private VideoPlayerHelper mvideoPlayerHelper;
   
	// Use this for initialization
	void Start () {
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i)
        {
            vbs[i].RegisterEventHandler(this);
        }
	
	}

    void OnEnable() {
        
		
    }

	// Update is called once per frame
	void Update () {
	
	}

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb){

        Debug.Log("OnButtonPressed:" + vb.VirtualButtonName);

       
        switch (vb.VirtualButtonName)
        {
            case "btnModel":
                Debug.Log("Boton modelo pressed");
                video.gameObject.SetActive(false);
               
                model.gameObject.SetActive(true);
                break;

            case "btnVideo":
                Debug.Log("Boton video pressed");
                video.gameObject.SetActive(true);
                model.gameObject.SetActive(false);
                break;

            case "btnVR":
                Debug.Log("Boton vr pressed");
                break;
        }

  }
    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) {
        Debug.Log("Button released");
    }


}
