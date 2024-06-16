using UnityEngine;

namespace ED.Curves
{
    public static class CatmullRomUtility
    {
        public static float GetPointScalar(float a, float b, float c, float d, float t)
        {
            var tt = t * t;
            var ttt = tt * t;
            return (a * (-ttt + 2f * tt - t) +
                    b * (3f * ttt - 5f * tt + 2f) +
                    c * (-3f * ttt + 4f * tt + t) +
                    d * (ttt - tt))
                   / 2f;
        }
        public static Vector2 GetPointV2(Vector2 a, Vector2 b, Vector2 c, Vector2 d, float t)
        {
            var tt = t * t;
            var ttt = tt * t;
            return (a * (-ttt + 2f * tt - t) +
                    b * (3f * ttt - 5f * tt + 2f) +
                    c * (-3f * ttt + 4f * tt + t) +
                    d * (ttt - tt))
                   / 2f;
        }
        
        public static Vector3 GetPointV3(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float t)
        {
            var tt = t * t;
            var ttt = tt * t;
            return (a * (-ttt + 2f * tt - t) +
                    b * (3f * ttt - 5f * tt + 2f) +
                    c * (-3f * ttt + 4f * tt + t) +
                    d * (ttt - tt))
                   / 2f;
        }
        
        public static Vector4 GetPointV4(Vector4 a, Vector4 b, Vector4 c, Vector4 d, float t)
        {
            var tt = t * t;
            var ttt = tt * t;
            return (a * (-ttt + 2f * tt - t) +
                    b * (3f * ttt - 5f * tt + 2f) +
                    c * (-3f * ttt + 4f * tt + t) +
                    d * (ttt - tt))
                   / 2f;
        }
        
        public static Color GetPointColor(Color a, Color b, Color c, Color d, float t)
        {
            var tt = t * t;
            var ttt = tt * t;
            return (a * (-ttt + 2f * tt - t) +
                    b * (3f * ttt - 5f * tt + 2f) +
                    c * (-3f * ttt + 4f * tt + t) +
                    d * (ttt - tt))
                   / 2f;
        }
        
        
        public static void GetPointScalar(float a, float b, float c, float d, float t, out float point, out float tangent)
        {
            var tt = t * t;
            var ttt = tt * t;
            var m1 = (c - a) * 0.5f;
            var m2 = (d - b) * 0.5f;
            point = (a * (-ttt + 2f * tt - t) +
                     b * (3f * ttt - 5f * tt + 2f) +
                     c * (-3f * ttt + 4f * tt + t) +
                     d * (ttt - tt))
                    / 2f;
            tangent = m1 * (3f * tt - 4f * t + 1f) +
                      b * (6f * tt - 6f * t) +
                      c * (-6f * tt + 6f * t) +
                      m2 * (3f * tt - 2f * t);
        }

        public static void GetPointV2(Vector2 a, Vector2 b, Vector2 c, Vector2 d, float t, out Vector2 point, out Vector2 tangent)
        {
            var tt = t * t;
            var ttt = tt * t;
            var m1 = (c - a) * 0.5f;
            var m2 = (d - b) * 0.5f;
            point = (a * (-ttt + 2f * tt - t) +
                     b * (3f * ttt - 5f * tt + 2f) +
                     c * (-3f * ttt + 4f * tt + t) +
                     d * (ttt - tt))
                    / 2f;
            tangent = m1 * (3f * tt - 4f * t + 1f) +
                      b * (6f * tt - 6f * t) +
                      c * (-6f * tt + 6f * t) +
                      m2 * (3f * tt - 2f * t);
        }
        
        public static void GetPointV3(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float t, out Vector3 point, out Vector3 tangent)
        {
            var tt = t * t;
            var ttt = tt * t;
            var m1 = (c - a) * 0.5f;
            var m2 = (d - b) * 0.5f;
            point = (a * (-ttt + 2f * tt - t) +
                     b * (3f * ttt - 5f * tt + 2f) +
                     c * (-3f * ttt + 4f * tt + t) +
                     d * (ttt - tt))
                    / 2f;
            tangent = m1 * (3f * tt - 4f * t + 1f) +
                      b * (6f * tt - 6f * t) +
                      c * (-6f * tt + 6f * t) +
                      m2 * (3f * tt - 2f * t);
        }
        
        public static void GetPointV4(Vector4 a, Vector4 b, Vector4 c, Vector4 d, float t, out Vector4 point, out Vector4 tangent)
        {
            var tt = t * t;
            var ttt = tt * t;
            var m1 = (c - a) * 0.5f;
            var m2 = (d - b) * 0.5f;
            point = (a * (-ttt + 2f * tt - t) +
                     b * (3f * ttt - 5f * tt + 2f) +
                     c * (-3f * ttt + 4f * tt + t) +
                     d * (ttt - tt))
                    / 2f;
            tangent = m1 * (3f * tt - 4f * t + 1f) +
                      b * (6f * tt - 6f * t) +
                      c * (-6f * tt + 6f * t) +
                      m2 * (3f * tt - 2f * t);
        }
        
        public static void GetPointColor(Color a, Color b, Color c, Color d, float t, out Color point, out Color tangent)
        {
            var tt = t * t;
            var ttt = tt * t;
            var m1 = (c - a) * 0.5f;
            var m2 = (d - b) * 0.5f;
            point = (a * (-ttt + 2f * tt - t) +
                     b * (3f * ttt - 5f * tt + 2f) +
                     c * (-3f * ttt + 4f * tt + t) +
                     d * (ttt - tt))
                    / 2f;
            tangent = m1 * (3f * tt - 4f * t + 1f) +
                      b * (6f * tt - 6f * t) +
                      c * (-6f * tt + 6f * t) +
                      m2 * (3f * tt - 2f * t);
        }
    }
}