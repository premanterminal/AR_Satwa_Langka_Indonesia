﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

#if UNITY_5_3 || UNITY_5_3_OR_NEWER
using UnityEngine.SceneManagement;
#endif
using OpenCVForUnity;

namespace OpenCVForUnityExample
{
    /// <summary>
    /// MSER example.
    /// </summary>
    public class MSERExample : MonoBehaviour
    {
        // Use this for initialization
        void Start ()
        {
            Texture2D imgTexture = Resources.Load ("chessboard") as Texture2D;

            Mat imgMat = new Mat (imgTexture.height, imgTexture.width, CvType.CV_8UC3);

            Utils.texture2DToMat (imgTexture, imgMat);
            Debug.Log ("imgMat.ToString() " + imgMat.ToString ());

            MSER mserExtractor = MSER.create ();
            mserExtractor.setDelta (5);
            mserExtractor.setMinArea (60);
            mserExtractor.setMaxArea (14400);
            
            List<MatOfPoint> mserContours = new List<MatOfPoint> ();
            MatOfRect mserBbox = new MatOfRect ();
            mserExtractor.detectRegions (imgMat, mserContours, mserBbox);


            for (int i = 0; i<mserContours.Count; i++) {
                Imgproc.drawContours (imgMat, mserContours, i, new Scalar (Random.Range (0, 255), Random.Range (0, 255), Random.Range (0, 255)), 4);
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