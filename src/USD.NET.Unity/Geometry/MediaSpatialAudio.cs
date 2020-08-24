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
  [UsdSchema("UsdMediaSpatialAudio")]
  public class SpatialAudio : pxr.UsdGeomXformable {
    public static SpatialAudio FromTransform(UnityEngine.AudioSource audioSource) {
      var xf = new SpatialAudio();
      return xf;
    }
    
    public SpatialAudio() : base() {
      auralMode = new pxr.TfToken("nonSpatial");
      playbackMode = new pxr.TfToken("loopFromStage");
      startTime = 0;
    }
    
    public SpatialAudio(string path) : this() {
      filePath.defaultValue = new pxr.SdfAssetPath(path);
    }
    
    [InputParameter("_File")]
    public Connectable<pxr.SdfAssetPath> filePath =
      new Connectable<pxr.SdfAssetPath>(new pxr.SdfAssetPath(""));
    
    public pxr.TfToken auralMode;
    public pxr.TfToken playbackMode;
    public pxr.UsdTimeCode startTime;
  }
}
