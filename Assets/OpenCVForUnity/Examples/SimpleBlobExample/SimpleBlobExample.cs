﻿using UnityEngine;
using System.Collections.Generic;

#if UNITY_5_3 || UNITY_5_3_OR_NEWER
using UnityEngine.SceneManagement;
#endif
using OpenCVForUnity;

namespace OpenCVForUnityExample
{
    /// <summary>
    /// Simple BLOB example.
    /// </summary>
    public class SimpleBlobExample : MonoBehaviour
    {
        private string blobparams_yml_filepath;

        // Use this for initialization
        void Start ()
        {
            #if UNITY_WEBGL && !UNITY_EDITOR
            StartCoroutine(Utils.getFilePathAsync("blobparams.yml", (result) => {
                blobparams_yml_filepath = result;
                Run ();
            }));
            #else
            blobparams_yml_filepath = Utils.getFilePath ("blobparams.yml");
            Run ();
            #endif
        }

        private void Run ()
        {
            Texture2D imgTexture = Resources.Load ("detect_blob") as Texture2D;

            Mat imgMat = new Mat (imgTexture.height, imgTexture.width, CvType.CV_8UC1);

            Utils.texture2DToMat (imgTexture, imgMat);
            Debug.Log ("imgMat.ToString() " + imgMat.ToString ());

            Mat outImgMat = new Mat ();

            FeatureDetector blobDetector = FeatureDetector.create (FeatureDetector.SIMPLEBLOB);

            blobDetector.read (blobparams_yml_filepath);


            MatOfKeyPoint keypoints = new MatOfKeyPoint ();
            blobDetector.detect (imgMat, keypoints);
            Features2d.drawKeypoints (imgMat, keypoints, outImgMat);


            Texture2D texture = new Texture2D (outImgMat.cols (), outImgMat.rows (), TextureFormat.RGBA32, false);

            Utils.matToTexture2D (outImgMat, texture);

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