using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace USD.NET.Unity {

    [System.Serializable]
    [UsdSchema("UsdLuxSphereLight")]
    public class SphereLightSample : XformableSample {
        public static SphereLightSample FromTransform(UnityEngine.Light light) {
            var xf = new SphereLightSample();
            return xf;
        }

        public SphereLightSample() : base() {
        }

        public Connectable<float> radius = new Connectable<float>(0.0f);
        public bool treatAsPoint = false;
    }
}
