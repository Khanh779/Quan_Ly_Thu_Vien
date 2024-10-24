using System.Drawing;

namespace DinhKhanh_Controls_UI.Helper
{
    public class ColorHelper
    {

        public static Color BlendColor(Color backgroundColor, Color frontColor, double blend)
        {
            var ratio = blend / 255d;
            var invRatio = 1d - ratio;
            var a = (int)((backgroundColor.A * invRatio) + (frontColor.A * ratio));
            var r = (int)((backgroundColor.R * invRatio) + (frontColor.R * ratio));
            var g = (int)((backgroundColor.G * invRatio) + (frontColor.G * ratio));
            var b = (int)((backgroundColor.B * invRatio) + (frontColor.B * ratio));
            return Color.FromArgb(a, r, g, b);
        }

        // Lấy màu mặc định sãn có luôn

        public static Color NormalColor
        {
            get
            {
                return Color.FromArgb(76, 149, 108);
            }
        }

        public static Color HoverColor
        {
            get
            {
                return Color.FromArgb(86, 169, 128);
            }
        }

        public static Color PressedColor
        {
            get
            {
                return Color.FromArgb(66, 139, 98);
            }
        }

        // Text Color
        public static Color TextNormalColor
        {
            get
            {
                return Color.WhiteSmoke;
            }
        }
        public static Color TextHoverColor
        {
            get
            {
                return Color.White;
            }
        }

        public static Color TextPressedColor
        {
            get
            {
                return Color.FromArgb(240, 240, 240);
            }
        }

    }
}
