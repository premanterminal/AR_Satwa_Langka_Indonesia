using UnityEngine;
using System.Collections;

#if UNITY_5_3 || UNITY_5_3_OR_NEWER
using UnityEngine.SceneManagement;
#endif

namespace OpenCVForUnityExample
{
    public class OpenCVForUnityExample : MonoBehaviour
    {

        // Use this for initialization
        void Start ()
        {

        }
    
        // Update is called once per frame
        void Update ()
        {

        }

        public void OnShowLicenseButton ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("ShowLicense");
            #else
            Application.LoadLevel ("ShowLicense");
            #endif
        }

        public void OnTexture2DToMatExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("Texture2DToMatExample");
            #else
            Application.LoadLevel ("Texture2DToMatExample");
            #endif
        }

        public void OnThresholdExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("ThresholdExample");
            #else
            Application.LoadLevel ("ThresholdExample");
            #endif
        }
        
        public void OnDrawingExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("DrawingExample");
            #else
            Application.LoadLevel ("DrawingExample");
            #endif
        }
        
        public void OnConvexHullExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("ConvexHullExample");
            #else
            Application.LoadLevel ("ConvexHullExample");
            #endif
        }
        
        public void OnHoughLinesPExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("HoughLinesPExample");
            #else
            Application.LoadLevel ("HoughLinesPExample");
            #endif
        }
        
        public void OnFeature2DExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("Feature2DExample");
            #else
            Application.LoadLevel ("Feature2DExample");
            #endif
        }

        public void OnWrapPerspectiveExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("WrapPerspectiveExample");
            #else
            Application.LoadLevel ("WrapPerspectiveExample");
            #endif
        }
        
        public void OnFaceRecognizerExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("FaceRecognizerExample");
            #else
            Application.LoadLevel ("FaceRecognizerExample");
            #endif
        }
        
        public void OnDetectFaceExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("DetectFaceExample");
            #else
            Application.LoadLevel ("DetectFaceExample");
            #endif
        }
                
        public void OnWebCamTextureToMatExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("WebCamTextureToMatExample");
            #else
            Application.LoadLevel ("WebCamTextureToMatExample");
            #endif
        }

        public void OnWebCamTextureToMatHelperExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("WebCamTextureToMatHelperExample");
            #else
            Application.LoadLevel ("WebCamTextureToMatHelperExample");
            #endif
        }
                
        public void OnWebCamTextureDetectFaceExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("WebCamTextureDetectFaceExample");
            #else
            Application.LoadLevel ("WebCamTextureDetectFaceExample");
            #endif
        }
        
        public void OnWebCamTextureAsyncDetectFaceExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("WebCamTextureAsyncDetectFaceExample");
            #else
            Application.LoadLevel ("WebCamTextureAsyncDetectFaceExample");
            #endif
        }
        
        public void OnOpticalFlowExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("OpticalFlowExample");
            #else
            Application.LoadLevel ("OpticalFlowExample");
            #endif
        }
        
        public void OnComicFilterExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("ComicFilterExample");
            #else
            Application.LoadLevel ("ComicFilterExample");
            #endif
        }
        
        public void OnCamShiftExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("CamShiftExample");
            #else
            Application.LoadLevel ("CamShiftExample");
            #endif
        }

        public void OnHandPoseEstimationExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("HandPoseEstimationExample");
            #else
            Application.LoadLevel ("HandPoseEstimationExample");
            #endif
        }

        public void OnMultiObjectTrackingBasedOnColorExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("MultiObjectTrackingBasedOnColorExample");
            #else
            Application.LoadLevel ("MultiObjectTrackingBasedOnColorExample");
            #endif
        }

        public void OnPlotExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("PlotExample");
            #else
            Application.LoadLevel ("PlotExample");
            #endif
        }

        public void OnSimpleBlobExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("SimpleBlobExample");
            #else
            Application.LoadLevel ("SimpleBlobExample");
            #endif
        }

        public void OnBackgroundSubtractorMOG2Example ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("BackgroundSubtractorMOG2Example");
            #else
            Application.LoadLevel ("BackgroundSubtractorMOG2Example");
            #endif
        }

        public void OnVideoCaptureExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("VideoCaptureExample");
            #else
            Application.LoadLevel ("VideoCaptureExample");
            #endif
        }

        public void OnMatchTemplateExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("MatchTemplateExample");
            #else
            Application.LoadLevel ("MatchTemplateExample");
            #endif
        }

        public void OnStereoBMExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("StereoBMExample");
            #else
            Application.LoadLevel ("StereoBMExample");
            #endif
        }

        public void OnSeamlessCloneExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("SeamlessCloneExample");
            #else
            Application.LoadLevel ("SeamlessCloneExample");
            #endif
        }

        public void OnWebCamTextureDetectCirclesExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("WebCamTextureDetectCirclesExample");
            #else
            Application.LoadLevel ("WebCamTextureDetectCirclesExample");
            #endif
        }

        public void OnSVMExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("SVMExample");
            #else
            Application.LoadLevel ("SVMExample");
            #endif
        }

        public void OnHOGDescriptorExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("HOGDescriptorExample");
            #else
            Application.LoadLevel ("HOGDescriptorExample");
            #endif
        }

        public void OnArUcoCreateMarkerExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("ArUcoCreateMarkerExample");
            #else
            Application.LoadLevel ("ArUcoCreateMarkerExample");
            #endif
        }
        
        public void OnArUcoTexture2DExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("ArUcoTexture2DExample");
            #else
            Application.LoadLevel ("ArUcoTexture2DExample");
            #endif
        }

        public void OnArUcoWebCamTextureExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("ArUcoWebCamTextureExample");
            #else
            Application.LoadLevel ("ArUcoWebCamTextureExample");
            #endif
        }

        public void OnGrabCutExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("GrabCutExample");
            #else
            Application.LoadLevel ("GrabCutExample");
            #endif
        }

        public void OnInpaintExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("InpaintExample");
            #else
            Application.LoadLevel ("InpaintExample");
            #endif
        }
        
        public void OnMatchShapesExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("MatchShapesExample");
            #else
            Application.LoadLevel ("MatchShapesExample");
            #endif
        }
        
        public void OnMSERExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("MSERExample");
            #else
            Application.LoadLevel ("MSERExample");
            #endif
        }

        public void OnPolygonFilterExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("PolygonFilterExample");
            #else
            Application.LoadLevel ("PolygonFilterExample");
            #endif
        }

        public void OnConnectedComponentsExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("ConnectedComponentsExample");
            #else
            Application.LoadLevel ("ConnectedComponentsExample");
            #endif
        }

        public void OnGreenScreenExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("GreenScreenExample");
            #else
            Application.LoadLevel ("GreenScreenExample");
            #endif
        }

        public void OnTrackingExample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			Application.LoadLevel("TrackingExample");
            #else
            Application.LoadLevel ("TrackingExample");
            #endif
        }
    }
}