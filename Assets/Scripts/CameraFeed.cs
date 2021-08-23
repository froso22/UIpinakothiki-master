using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraFeed : MonoBehaviour
{
    private bool camAvailable;
    private WebCamTexture backCam;
    private Texture defaultBackground;

    public RawImage background;
    public AspectRatioFitter fit;
    //public bool frontFacing;
    // Start is called before the first frame update
    void Start()
    {
		defaultBackground = background.texture;
		WebCamDevice[] devices = WebCamTexture.devices;

		//if (devices.Length == 0)
		//return;
		if (devices.Length == 0) {
			Debug.Log("No Camera Detected");
			camAvailable = false;
			return;
		}

		for (int i = 0; i < devices.Length; i++)
		{
			if (!devices[i].isFrontFacing)
			{
				backCam = new WebCamTexture(devices[i].name, Screen.width, Screen.height);
				//break;
			}
		}
		if (backCam==null) {
			Debug.Log("Unable to find back camera");
			return;
		}

		backCam.Play();
		background.texture = backCam;
		/*if (cameraTexture == null)
			return;

		cameraTexture.Play(); // Start the camera
		background.texture = cameraTexture; // Set the texture*/

		camAvailable = true; // Set the camAvailable for future purposes.
	}

    // Update is called once per frame
    void Update()
    {
		if (!camAvailable)
			return;

		float ratio = (float)backCam.width / (float)backCam.height;
		fit.aspectRatio = ratio; // Set the aspect ratio

		float scaleY = backCam.videoVerticallyMirrored ? -1f : 1f; // Find if the camera is mirrored or not
		background.rectTransform.localScale = new Vector3(1f, scaleY, 1f); // Swap the mirrored camera
		//background.rectTransform.localScale = new Vector3(1f*ratio, scaleY*ratio, 1f*ratio); //zoom fixing vertically

		int orient = -backCam.videoRotationAngle;
		background.rectTransform.localEulerAngles = new Vector3(0, 0, orient);
	}
}
