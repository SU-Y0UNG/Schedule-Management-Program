using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Maver.Common
{
    public static class BorderHelper
    {

        public enum EventShape
        {
            Single,
            Start,
            Middle,
            End
        }
        public static void SetRoundRegion(Control ctrl, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, ctrl.Width, ctrl.Height);

            int d = radius * 2;

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            ctrl.Region = new Region(path);
        }


        // 점선 테두리 함수 만들기
        public static void ApplyDotBorder(Control ctrl)
        {
            ctrl.Paint += Ctrl_Paint;
        }


        public static void Ctrl_Paint(object sender, PaintEventArgs e)
        {
            Control ctrl = sender as Control;
            Color borderColor = Color.Silver;
            Color dotColor = Color.DarkGray;

            if (ctrl.Tag is Tuple<Color, Color> colors)
            {
                borderColor = colors.Item1;
                dotColor = colors.Item2;
            }
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            // 바깥 둥근 테두리
            using (Pen border = new Pen(borderColor, 2))
            {
                GraphicsPath path = GetRoundRect(new Rectangle(1, 1, ctrl.Width - 3, ctrl.Height - 3), 18);
                e.Graphics.DrawPath(border, path);
            }

            // 안쪽 둥근 점선
            using (Pen pen = new Pen(dotColor, 1))
            {
                pen.DashStyle = DashStyle.Custom;
                pen.DashPattern = new float[] { 1, 2 };

                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;

                GraphicsPath path = GetRoundRect(
                    new Rectangle(5, 5, ctrl.Width - 11, ctrl.Height - 11), 13);

                e.Graphics.DrawPath(pen, path);
            }
        }

        public static GraphicsPath GetRoundRect(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int d = radius * 2;

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);

            path.CloseFigure();

            return path;
        }

        public static void EventLabel_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = sender as Label;

            if (lbl.Tag == null) return;

            string tag = lbl.Tag.ToString();

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, lbl.Width - 1, lbl.Height - 1);

            using (Pen pen = new Pen(Color.Gray, 1))
            {
                pen.DashStyle = DashStyle.Dot;

                if (!tag.Contains("연속"))
                {
                    // 단일 일정
                    GraphicsPath path = GetRoundRect(rect, 8);
                    e.Graphics.DrawPath(pen, path);
                }
                else if (tag.Contains("Start"))
                {
                    GraphicsPath start = new GraphicsPath();

                    start.AddArc(rect.X, rect.Y, 16, 16, 180, 90);
                    start.AddLine(rect.X + 8, rect.Y, rect.Right, rect.Y);
                    start.AddLine(rect.Right, rect.Y, rect.Right, rect.Bottom);
                    start.AddLine(rect.Right, rect.Bottom, rect.X + 8, rect.Bottom);
                    start.AddArc(rect.X, rect.Bottom - 16, 16, 16, 90, 90);

                    e.Graphics.DrawPath(pen, start);
                }
                else if (tag.Contains("Middle"))
                {
                    e.Graphics.DrawLine(pen, rect.Left, rect.Top, rect.Right, rect.Top);
                    e.Graphics.DrawLine(pen, rect.Left, rect.Bottom, rect.Right, rect.Bottom);
                }
                else if (tag.Contains("End"))
                {
                    GraphicsPath end = new GraphicsPath();

                    end.AddLine(rect.Left, rect.Top, rect.Right - 8, rect.Top);
                    end.AddArc(rect.Right - 16, rect.Y, 16, 16, 270, 90);
                    end.AddArc(rect.Right - 16, rect.Bottom - 16, 16, 16, 0, 90);
                    end.AddLine(rect.Right - 8, rect.Bottom, rect.Left, rect.Bottom);

                    e.Graphics.DrawPath(pen, end);
                }
            }
        
        }

    }
}
