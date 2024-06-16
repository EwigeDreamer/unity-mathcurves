using UnityEngine;

namespace ED.Curves
{
    public static class BezierUtility
    {
        public static float GetPointScalar(float a, float b, float c, float t)
        {
            var u = 1f - t;
            return a * (u * u) + 
                   b * (2f * t * u) + 
                   c * (t * t);
        }
        
        public static Vector2 GetPointV2(Vector2 a, Vector2 b, Vector2 c, float t)
        {
            var u = 1f - t;
            return a * (u * u) + 
                   b * (2f * t * u) + 
                   c * (t * t);
        }

        public static Vector3 GetPointV3(Vector3 a, Vector3 b, Vector3 c, float t)
        {
            var u = 1f - t;
            return a * (u * u) + 
                   b * (2f * t * u) + 
                   c * (t * t);
        }

        public static Vector4 GetPointV4(Vector4 a, Vector4 b, Vector4 c, float t)
        {
            var u = 1f - t;
            return a * (u * u) +
                   b * (2f * t * u) +
                   c * (t * t);
        }

        public static Color GetPointColor(Color a, Color b, Color c, float t)
        {
            var u = 1f - t;
            return a * (u * u) +
                   b * (2f * t * u) +
                   c * (t * t);
        }
        
        
        public static float GetPointScalar(float a, float b, float c, float d, float t)
        {
            var u = 1f - t;
            var uu = u * u;
            var tt = t * t;
            return a * (uu * u) +
                   b * (3f * uu * t) +
                   c * (3f * tt * u) +
                   d * (tt * t);
        }

        public static Vector2 GetPointV2(Vector2 a, Vector2 b, Vector2 c, Vector2 d, float t)
        {
            var u = 1f - t;
            var uu = u * u;
            var tt = t * t;
            return a * (uu * u) +
                   b * (3f * uu * t) +
                   c * (3f * tt * u) +
                   d * (tt * t);
        }

        public static Vector3 GetPointV3(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float t)
        {
            var u = 1f - t;
            var uu = u * u;
            var tt = t * t;
            return a * (uu * u) +
                   b * (3f * uu * t) +
                   c * (3f * tt * u) +
                   d * (tt * t);
        }

        public static Vector4 GetPointV4(Vector4 a, Vector4 b, Vector4 c, Vector4 d, float t)
        {
            var u = 1f - t;
            var uu = u * u;
            var tt = t * t;
            return a * (uu * u) +
                   b * (3f * uu * t) +
                   c * (3f * tt * u) +
                   d * (tt * t);
        }

        public static Color GetPointColor(Color a, Color b, Color c, Color d, float t)
        {
            var u = 1f - t;
            var uu = u * u;
            var tt = t * t;
            return a * (uu * u) +
                   b * (3f * uu * t) +
                   c * (3f * tt * u) +
                   d * (tt * t);
        }
        
        
        public static void GetPointScalar(float a, float b, float c, float t, out float point, out float tangent) {
            var u = 1f - t;
            var k = 1f - t * 2f;
            point = a * (u * u) + 
                    b * (2f * t * u) + 
                    c * (t * t);
            tangent = a * (-2f * u) +
                      b * (2f * k) +
                      c * (2f * t);
        }
        
        public static void GetPointV2(Vector2 a, Vector2 b, Vector2 c, float t, out Vector2 point, out Vector2 tangent) {
            var u = 1f - t;
            var k = 1f - t * 2f;
            point = a * (u * u) + 
                    b * (2f * t * u) + 
                    c * (t * t);
            tangent = a * (-2f * u) +
                      b * (2f * k) +
                      c * (2f * t);
        }

        public static void GetPointV3(Vector3 a, Vector3 b, Vector3 c, float t, out Vector3 point, out Vector3 tangent) {
            var u = 1f - t;
            var k = 1f - t * 2f;
            point = a * (u * u) + 
                    b * (2f * t * u) + 
                    c * (t * t);
            tangent = a * (-2f * u) +
                      b * (2f * k) +
                      c * (2f * t);
        }

        public static void GetPointV4(Vector4 a, Vector4 b, Vector4 c, float t, out Vector4 point, out Vector4 tangent) {
            var u = 1f - t;
            var k = 1f - t * 2f;
            point = a * (u * u) + 
                    b * (2f * t * u) + 
                    c * (t * t);
            tangent = a * (-2f * u) +
                      b * (2f * k) +
                      c * (2f * t);
        }

        public static void GetPointColor(Color a, Color b, Color c, float t, out Color point, out Color tangent) {
            var u = 1f - t;
            var k = 1f - t * 2f;
            point = a * (u * u) + 
                    b * (2f * t * u) + 
                    c * (t * t);
            tangent = a * (-2f * u) +
                      b * (2f * k) +
                      c * (2f * t);
        }
        
        
        public static void GetPointScalar(float a, float b, float c, float d, float t, out float point, out float tangent) {
            var u = 1f - t;
            var uu = u * u;
            var tt = t * t;
            var k = 6f - t * 9f;
            var n = 6f - u * 9f;
            point = a * (uu * u) +
                    b * (3f * uu * t) +
                    c * (3f * tt * u) +
                    d * (tt * t);
            tangent = a * (3f * -uu) +
                      b * (-u * n) +
                      c * (t * k) +
                      d * (3f * tt);
        }
        
        public static void GetPointV2(Vector2 a, Vector2 b, Vector2 c, Vector2 d, float t, out Vector2 point, out Vector2 tangent) {
            var u = 1f - t;
            var uu = u * u;
            var tt = t * t;
            var k = 6f - t * 9f;
            var n = 6f - u * 9f;
            point = a * (uu * u) +
                    b * (3f * uu * t) +
                    c * (3f * tt * u) +
                    d * (tt * t);
            tangent = a * (3f * -uu) +
                      b * (-u * n) +
                      c * (t * k) +
                      d * (3f * tt);
        }

        public static void GetPointV3(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float t, out Vector3 point, out Vector3 tangent) {
            var u = 1f - t;
            var uu = u * u;
            var tt = t * t;
            var k = 6f - t * 9f;
            var n = 6f - u * 9f;
            point = a * (uu * u) +
                    b * (3f * uu * t) +
                    c * (3f * tt * u) +
                    d * (tt * t);
            tangent = a * (3f * -uu) +
                      b * (-u * n) +
                      c * (t * k) +
                      d * (3f * tt);
        }

        public static void GetPointV4(Vector4 a, Vector4 b, Vector4 c, Vector4 d, float t, out Vector4 point, out Vector4 tangent) {
            var u = 1f - t;
            var uu = u * u;
            var tt = t * t;
            var k = 6f - t * 9f;
            var n = 6f - u * 9f;
            point = a * (uu * u) +
                    b * (3f * uu * t) +
                    c * (3f * tt * u) +
                    d * (tt * t);
            tangent = a * (3f * -uu) +
                      b * (-u * n) +
                      c * (t * k) +
                      d * (3f * tt);
        }

        public static void GetPointColor(Color a, Color b, Color c, Color d, float t, out Color point, out Color tangent) {
            var u = 1f - t;
            var uu = u * u;
            var tt = t * t;
            var k = 6f - t * 9f;
            var n = 6f - u * 9f;
            point = a * (uu * u) +
                    b * (3f * uu * t) +
                    c * (3f * tt * u) +
                    d * (tt * t);
            tangent = a * (3f * -uu) +
                      b * (-u * n) +
                      c * (t * k) +
                      d * (3f * tt);
        }
    }
}