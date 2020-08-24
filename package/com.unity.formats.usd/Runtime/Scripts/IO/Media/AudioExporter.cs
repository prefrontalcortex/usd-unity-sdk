using System.Collections;
using System.Collections.Generic;
using System.IO;
using pxr;
using Unity.Formats.USD;
using UnityEngine;
using USD.NET;
using USD.NET.Unity;

namespace Unity.Formats.USD { 
    public class AudioExporter
    {
        public static void ExportAudio(ObjectContext objContext, ExportContext exportContext) {
            AudioSource mf = objContext.gameObject.GetComponent<AudioSource>();
            
            UnityEngine.Profiling.Profiler.BeginSample("USD: Audio");

            ExportAudio(objContext,
                exportContext,
                mf,
                mf.clip);

            UnityEngine.Profiling.Profiler.EndSample();
        }

        static void ExportAudio(ObjectContext objContext, ExportContext exportContext, AudioSource audioSource, AudioClip audioClip) {
            string path = objContext.path;
            var scene = exportContext.scene;
            
            UnityEngine.Profiling.Profiler.BeginSample("USD: Audio Write");
            var sample = (SpatialAudioSample) objContext.sample;

            var texPath = System.IO.Path.GetDirectoryName(scene.FilePath);
            var clipPath = SetupAudioClip(scene, texPath, objContext.gameObject.GetComponent<AudioSource>().clip);

            var filePath = clipPath;
            if(Path.IsPathRooted(clipPath))
                filePath = ImporterBase.MakeRelativePath(scene.FilePath, clipPath);
            filePath = filePath.Replace("\\", "/");
            
            // http://graphics.pixar.com/usd/docs/UsdAudio-Proposal.html
            sample.auralMode = new TfToken(audioSource.spatialBlend > 0.5f ? "spatial" : "nonSpatial");
            // Debug.Log(audioSource + ": " + audioClip + ": " + sample.auralMode.ToString());
            
            sample.playbackMode = new TfToken(audioSource.loop ? "loopFromStage" : "onceFromStart");
            sample.gain.defaultValue = audioSource.volume;
            sample.filePath.defaultValue = new pxr.SdfAssetPath(filePath);

            scene.Write(path, sample);
            UnityEngine.Profiling.Profiler.EndSample();
        }

        static string SetupAudioClip(Scene scene, string texPath, AudioClip clip) {
            string fileName = null;
            bool textureIsExported = false;
            
    #if UNITY_EDITOR
            // only export from disk if there's no need to do any type of data conversion here
            if(true) {
                var srcPath = UnityEditor.AssetDatabase.GetAssetPath(clip);

                if (!string.IsNullOrEmpty(srcPath)) {
    #if UNITY_2019_2_OR_GREATER
                    // Since textures might be inside of packages for various reasons we should support that.
                    // Usually this would just be "Path.GetFullPath(srcPath)", but USD export messes with the CWD (Working Directory)
                    // and so we have to do a bit more path wrangling here.
                    if(srcPath.StartsWith("Packages")) {
                    var pi = UnityEditor.PackageManager.PackageInfo.FindForAssetPath(srcPath);
                    srcPath = pi.resolvedPath + srcPath.Substring(("Packages/" + pi.name).Length);
                    }
    #endif
                    if(srcPath.StartsWith("Assets")) {
                        srcPath = Application.dataPath + "/" + srcPath.Substring("Assets/".Length);
                    }
                    fileName = System.IO.Path.GetFileName(srcPath);
                    var filePath = System.IO.Path.Combine(texPath, fileName);

                    if (System.IO.File.Exists(srcPath)) {
                        // USDZ officially only supports png / jpg / jpeg
                        // https://graphics.pixar.com/usd/docs/Usdz-File-Format-Specification.html

                        var ext = System.IO.Path.GetExtension(srcPath).ToLowerInvariant();
                        if (ext == ".m4a" || ext == ".mp3" || ext == ".wav") {
                            System.IO.File.Copy(srcPath, filePath, overwrite: true);
                            if (System.IO.File.Exists(filePath)) {
                                textureIsExported = true;
                            }
                        }
                    }
                }
            }
    #endif
            if (!textureIsExported) {
                Debug.LogWarning("Wasn't able to export AudioClip: " + clip, clip);
            }
            return fileName;
        }
    }
}