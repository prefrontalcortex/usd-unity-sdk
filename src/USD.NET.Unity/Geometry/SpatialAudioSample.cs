// Copyright 2018 Jeremy Cowles. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using UnityEngine;

namespace USD.NET.Unity {

  [System.Serializable]
  [UsdSchema("SpatialAudio")]
  public class SpatialAudioSample : XformableSample {
    public static SpatialAudioSample FromTransform(UnityEngine.AudioSource audioSource) {
      var xf = new SpatialAudioSample();
      return xf;
    }
    
    public SpatialAudioSample() : base() {
      auralMode = new pxr.TfToken("spatial");
      playbackMode = new pxr.TfToken("onceFromStart");
      startTime = 0;
    }
    
    public SpatialAudioSample(string path) : this() {
      filePath.defaultValue = new pxr.SdfAssetPath(path);
    }
    
    [UsdVariability(Variability.Uniform)]
    public Connectable<pxr.SdfAssetPath> filePath =
      new Connectable<pxr.SdfAssetPath>(new pxr.SdfAssetPath(""));
    
    [UsdVariability(Variability.Uniform)]
    public pxr.TfToken auralMode;
    
    [UsdVariability(Variability.Uniform)]
    public pxr.TfToken playbackMode;
    
    [UsdVariability(Variability.Uniform)]
    public pxr.UsdTimeCode startTime;
    
    [UsdVariability(Variability.Uniform)]
    public pxr.UsdTimeCode endTime;

    [UsdVariability(Variability.Uniform)]
    public double mediaOffset;

    public Connectable<double> gain = new Connectable<double>(1.0);
  }
}
