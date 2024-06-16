using UnityEngine;

namespace ED.Curves.Sample
{
    public class BezierSample : MonoBehaviour
    {
        public Transform a1;
        public Transform b1;
        public Transform c1;
        [Space]
        public Transform a2;
        public Transform b2;
        public Transform c2;
        public Transform d2;

        private void OnDrawGizmos()
        {
            if (a1 && b1 && c1)
            {
                var colorTmp = Gizmos.color;
                Gizmos.color = Color.yellow.SetA(0.5f);
                Gizmos.DrawLine(a1.position, b1.position);
                Gizmos.DrawLine(b1.position, c1.position);
                Gizmos.color = Color.Lerp(Color.green, Color.white, 0.25f);
                for (int i = 0; i < 100; ++i) {
                    var p1 = BezierUtility.GetPointV3(a1.position, b1.position, c1.position, i / 100f);
                    var p2 = BezierUtility.GetPointV3(a1.position, b1.position, c1.position, (i + 1) / 100f);
                    Gizmos.DrawLine(p1, p2);
                }
                Gizmos.color = Color.white.SetA(0.25f);
                for (int i = 0; i < 10; ++i) {
                    BezierUtility.GetPointV3(a1.position, b1.position, c1.position, i / 10f, out var p, out var t);
                    Gizmos.DrawLine(p, p + t * 0.25f);
                }
                Gizmos.color = colorTmp;
            }
            if (a2 && b2 && c2 && d2)
            {
                var colorTmp = Gizmos.color;
                Gizmos.color = Color.yellow.SetA(0.5f);
                Gizmos.DrawLine(a2.position, b2.position);
                Gizmos.DrawLine(b2.position, c2.position);
                Gizmos.DrawLine(c2.position, d2.position);
                Gizmos.color = Color.Lerp(Color.green, Color.white, 0.25f);
                for (int i = 0; i < 100; ++i) {
                    var p1 = BezierUtility.GetPointV3(a2.position, b2.position, c2.position, d2.position, i / 100f);
                    var p2 = BezierUtility.GetPointV3(a2.position, b2.position, c2.position, d2.position, (i + 1) / 100f);
                    Gizmos.DrawLine(p1, p2);
                }
                Gizmos.color = Color.white.SetA(0.25f);
                for (int i = 0; i < 10; ++i) {
                    BezierUtility.GetPointV3(a2.position, b2.position, c2.position, d2.position, i / 10f, out var p, out var t);
                    Gizmos.DrawLine(p, p + t * 0.25f);
                }
                Gizmos.color = colorTmp;
            }
        }
    }
}
