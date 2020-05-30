using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Firebase;
using XFFaceDetectMLkit.Droid.Services.MLVision;
using XFFaceDetectMLkit.Services.MLVision;

[assembly:Xamarin.Forms.Dependency(typeof(FaceDetector))]
namespace XFFaceDetectMLkit.Droid.Services.MLVision
{
    public class FaceDetector:IFaceDetector
    {
        public readonly FirebaseApp Firebase_App; 
        public FaceDetector()
        {
            var options = new FirebaseOptions.Builder()
                .SetApplicationId("なんでもいいよ")
                .Build();
            Firebase_App = FirebaseApp.InitializeApp(null, options);
        }
    }
}