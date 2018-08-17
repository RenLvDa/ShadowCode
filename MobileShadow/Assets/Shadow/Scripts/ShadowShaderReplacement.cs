using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
public class ShadowShaderReplacement : MonoBehaviour
{
	public Shader replacementShader;
	private Camera mCam;

	void OnEnable ()
	{
		mCam = GetComponent<Camera> ();
		replacementShader = Shader.Find ("ShadowSystem/ReplacementShadow");
		if (replacementShader != null) {
			mCam.SetReplacementShader (replacementShader, "RenderType");
		}
	}

	void OnDisable ()
	{
		mCam.ResetReplacementShader ();
	}
    
}