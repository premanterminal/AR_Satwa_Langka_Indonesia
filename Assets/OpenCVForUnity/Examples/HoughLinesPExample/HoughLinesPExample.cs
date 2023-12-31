﻿using UnityEngine;
using System.Collections;

#if UNITY_5_3 || UNITY_5_3_OR_NEWER
using UnityEngine.SceneManagement;
#endif
using OpenCVForUnity;

namespace OpenCVForUnityExample
{
    /// <summary>
    /// HoughLinesP example.
    /// </summary>
    public class HoughLinesPExample : MonoBehaviour
    {
        // Use this for initialization
        void Start ()
        {
            Texture2D imgTexture = Resources.Load ("chessboard") as Texture2D;
            
            Mat imgMat = new Mat (imgTexture.height, imgTexture.width, CvType.CV_8UC3);
            
            Utils.texture2DToMat (imgTexture, imgMat);
            Debug.Log ("imgMat.ToString() " + imgMat.ToString ());


            Mat grayMat = new Mat ();
            Imgproc.cvtColor (imgMat, grayMat, Imgproc.COLOR_RGB2GRAY);


            Imgproc.Canny (grayMat, grayMat, 50, 200);

            Mat lines = new Mat ();

            Imgproc.HoughLinesP (grayMat, lines, 1, Mathf.PI / 180, 50, 50, 10);

//                      Debug.Log ("lines.toStirng() " + lines.ToString ());
//                      Debug.Log ("lines.dump()" + lines.dump ());

            int[] linesArray = new int[lines.cols () * lines.rows () * lines.channels ()];
            lines.get (0, 0, linesArray);

            for (int i = 0; i < linesArray.Length; i=i+4) {
                Imgproc.line (imgMat, new Point (linesArray [i + 0], linesArray [i + 1]), new Point (linesArray [i + 2], linesArray [i + 3]), new Scalar (255, 0, 0), 2);
            }

        
            Texture2D texture = new Texture2D (imgMat.cols (), imgMat.rows (), TextureFormat.RGBA32, false);
            Utils.matToTexture2D (imgMat, texture);
        
            gameObject.GetComponent<Renderer> ().material.mainTexture = texture;
        }
    
        // Update is called once per frame
        void Update ()
        {
        
        }
    
        public void OnBackButton ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("OpenCVForUnityExample");
            #else
            Application.LoadLevel ("OpenCVForUnityExample");
            #endif
        }
    }
}