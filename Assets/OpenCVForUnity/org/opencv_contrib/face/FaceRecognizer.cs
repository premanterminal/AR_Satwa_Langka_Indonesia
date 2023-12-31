
//

//
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

// C++: class FaceRecognizer
//javadoc: FaceRecognizer
    public class FaceRecognizer : Algorithm
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5
            try {
                if (disposing) {
                }
                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        face_FaceRecognizer_delete (nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            } finally {
                base.Dispose (disposing);
            }
#else
            return;
#endif
        }

        protected internal FaceRecognizer (IntPtr addr) : base(addr)
        {
        }


        //
        // C++:  String getLabelInfo(int label)
        //

        //javadoc: FaceRecognizer::getLabelInfo(label)
        public  string getLabelInfo (int label)
        {
            ThrowIfDisposed ();
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5
        
            string retVal = Marshal.PtrToStringAnsi (face_FaceRecognizer_getLabelInfo_10 (nativeObj, label));
        
            return retVal;
            #else
            return null;
            #endif
        }


        //
        // C++:  int predict(Mat src)
        //

        //javadoc: FaceRecognizer::predict(src)
        public  int predict_label (Mat src)
        {
            ThrowIfDisposed ();
            if (src != null)
                src.ThrowIfDisposed ();
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5
        
            int retVal = face_FaceRecognizer_predict_1label_10 (nativeObj, src.nativeObj);
        
            return retVal;
            #else
            return -1;
            #endif
        }


        //
        // C++:  vector_int getLabelsByString(String str)
        //

        //javadoc: FaceRecognizer::getLabelsByString(str)
        public  MatOfInt getLabelsByString (string str)
        {
            ThrowIfDisposed ();
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5
        
            MatOfInt retVal = MatOfInt.fromNativeAddr (face_FaceRecognizer_getLabelsByString_10 (nativeObj, str));
        
            return retVal;
            #else
            return null;
            #endif
        }


        //
        // C++:  void load(String filename)
        //

        //javadoc: FaceRecognizer::load(filename)
        public  void load (string filename)
        {
            ThrowIfDisposed ();
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5
        
            face_FaceRecognizer_load_10 (nativeObj, filename);
        
            return;
            #else
            return;
            #endif
        }


        //
        // C++:  void predict(Mat src, Ptr_PredictCollector collector)
        //

        //javadoc: FaceRecognizer::predict(src, collector)
        public  void predict_collect (Mat src, PredictCollector collector)
        {
            ThrowIfDisposed ();
            if (src != null)
                src.ThrowIfDisposed ();
            if (collector != null)
                collector.ThrowIfDisposed ();
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5
        
            face_FaceRecognizer_predict_1collect_10 (nativeObj, src.nativeObj, collector.nativeObj);
        
            return;
            #else
            return;
            #endif
        }


        //
        // C++:  void predict(Mat src, int& label, double& confidence)
        //

        //javadoc: FaceRecognizer::predict(src, label, confidence)
        public  void predict (Mat src, int[] label, double[] confidence)
        {
            ThrowIfDisposed ();
            if (src != null)
                src.ThrowIfDisposed ();
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5
            double[] label_out = new double[1];
            double[] confidence_out = new double[1];
            face_FaceRecognizer_predict_10 (nativeObj, src.nativeObj, label_out, confidence_out);
            if (label != null)
                label [0] = (int)label_out [0];
            if (confidence != null)
                confidence [0] = (double)confidence_out [0];
            return;
            #else
            return;
            #endif
        }


        //
        // C++:  void save(String filename)
        //

        //javadoc: FaceRecognizer::save(filename)
        public override void save (string filename)
        {
            ThrowIfDisposed ();
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5
        
            face_FaceRecognizer_save_10 (nativeObj, filename);
        
            return;
            #else
            return;
            #endif
        }


        //
        // C++:  void setLabelInfo(int label, String strInfo)
        //

        //javadoc: FaceRecognizer::setLabelInfo(label, strInfo)
        public  void setLabelInfo (int label, string strInfo)
        {
            ThrowIfDisposed ();
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5
        
            face_FaceRecognizer_setLabelInfo_10 (nativeObj, label, strInfo);
        
            return;
            #else
            return;
            #endif
        }


        //
        // C++:  void train(vector_Mat src, Mat labels)
        //

        //javadoc: FaceRecognizer::train(src, labels)
        public  void train (List<Mat> src, Mat labels)
        {
            ThrowIfDisposed ();
            if (labels != null)
                labels.ThrowIfDisposed ();
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5
            Mat src_mat = Converters.vector_Mat_to_Mat (src);
            face_FaceRecognizer_train_10 (nativeObj, src_mat.nativeObj, labels.nativeObj);
        
            return;
            #else
            return;
            #endif
        }


        //
        // C++:  void update(vector_Mat src, Mat labels)
        //

        //javadoc: FaceRecognizer::update(src, labels)
        public  void update (List<Mat> src, Mat labels)
        {
            ThrowIfDisposed ();
            if (labels != null)
                labels.ThrowIfDisposed ();
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5
            Mat src_mat = Converters.vector_Mat_to_Mat (src);
            face_FaceRecognizer_update_10 (nativeObj, src_mat.nativeObj, labels.nativeObj);
        
            return;
            #else
            return;
            #endif
        }


        #if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
        #else
        const string LIBNAME = "opencvforunity";
        #endif



        // C++:  String getLabelInfo(int label)
        [DllImport(LIBNAME)]
        private static extern IntPtr face_FaceRecognizer_getLabelInfo_10 (IntPtr nativeObj, int label);

        // C++:  int predict(Mat src)
        [DllImport(LIBNAME)]
        private static extern int face_FaceRecognizer_predict_1label_10 (IntPtr nativeObj, IntPtr src_nativeObj);

        // C++:  vector_int getLabelsByString(String str)
        [DllImport(LIBNAME)]
        private static extern IntPtr face_FaceRecognizer_getLabelsByString_10 (IntPtr nativeObj, string str);

        // C++:  void load(String filename)
        [DllImport(LIBNAME)]
        private static extern void face_FaceRecognizer_load_10 (IntPtr nativeObj, string filename);

        // C++:  void predict(Mat src, Ptr_PredictCollector collector)
        [DllImport(LIBNAME)]
        private static extern void face_FaceRecognizer_predict_1collect_10 (IntPtr nativeObj, IntPtr src_nativeObj, IntPtr collector_nativeObj);

        // C++:  void predict(Mat src, int& label, double& confidence)
        [DllImport(LIBNAME)]
        private static extern void face_FaceRecognizer_predict_10 (IntPtr nativeObj, IntPtr src_nativeObj, double[] label_out, double[] confidence_out);

        // C++:  void save(String filename)
        [DllImport(LIBNAME)]
        private static extern void face_FaceRecognizer_save_10 (IntPtr nativeObj, string filename);

        // C++:  void setLabelInfo(int label, String strInfo)
        [DllImport(LIBNAME)]
        private static extern void face_FaceRecognizer_setLabelInfo_10 (IntPtr nativeObj, int label, string strInfo);

        // C++:  void train(vector_Mat src, Mat labels)
        [DllImport(LIBNAME)]
        private static extern void face_FaceRecognizer_train_10 (IntPtr nativeObj, IntPtr src_mat_nativeObj, IntPtr labels_nativeObj);

        // C++:  void update(vector_Mat src, Mat labels)
        [DllImport(LIBNAME)]
        private static extern void face_FaceRecognizer_update_10 (IntPtr nativeObj, IntPtr src_mat_nativeObj, IntPtr labels_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void face_FaceRecognizer_delete (IntPtr nativeObj);

    }
}
