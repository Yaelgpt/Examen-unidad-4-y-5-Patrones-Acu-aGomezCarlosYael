using System;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace NotificacionesWinForms.Presentation
{
    public static class PreviewStyler
    {
        public static void Apply(RichTextBox rtb, string text)
        {
            
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("El texto de la notificación está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            rtb.Clear();
            var temaColor = Color.Gray;

            string normAll = Norm(text);
            if (normAll.Contains("[NAVIDAD]")) temaColor = Color.Green;
            else if (normAll.Contains("[HALLOWEEN]")) temaColor = Color.Orange;
            else if (normAll.Contains("[CUMPLEANOS]")) temaColor = Color.CadetBlue;

            bool urgente = normAll.Contains("[URGENTE]");

            foreach (var raw in text.Replace("\r\n", "\n").Split('\n'))
            {
                string line = raw;
                string trimmed = line.Trim();
                string normLine = Norm(trimmed);

                if (urgente && (normLine == "[URGENTE]" || IsBarOf(line, '!')))
                {
                    AppendLine(rtb, line, Color.Red);
                    continue;
                }

                if (IsStarLine(line) || normLine == "[NAVIDAD]" || normLine == "[HALLOWEEN]" || normLine == "[CUMPLEANOS]" ||
                    normLine == "FELIZNAVIDAD" || normLine == "NOCHEDEHALLOWEEN" || normLine == "FELIZCUMPLEANOS")
                {
                    AppendLine(rtb, line, temaColor);
                    continue;
                }

                if (normLine.StartsWith("[TAMANIOX"))
                {
                    AppendLine(rtb, line, Color.CornflowerBlue);
                    continue;
                }

                AppendLine(rtb, line, rtb.ForeColor);
            }
        }


        private static void AppendLine(RichTextBox rtb, string text, Color color)
        {
            int start = rtb.TextLength;
            rtb.AppendText(text + Environment.NewLine);
            rtb.Select(start, text.Length);
            rtb.SelectionColor = color;
            rtb.Select(rtb.TextLength, 0);
            rtb.SelectionColor = rtb.ForeColor;
        }

        private static bool IsStarLine(string s)
        {
            string t = s.Replace(" ", "");
            if (string.IsNullOrWhiteSpace(t)) return false;
            if (t.Length < 5) return false;
            foreach (var ch in t) if (ch != '*') return false;
            return true;
        }

        private static bool IsBarOf(string s, char c)
        {
            string t = s.Replace(" ", "");
            if (t.Length < 5) return false;
            int count = 0;
            foreach (var ch in t) if (ch == c) count++;
            return count >= (int)(t.Length * 0.9);
        }

        private static string Norm(string s)
        {
            string noSpaces = s.Replace(" ", "").ToUpperInvariant();
            string decomposed = noSpaces.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder(decomposed.Length);
            foreach (var ch in decomposed)
            {
                var uc = CharUnicodeInfo.GetUnicodeCategory(ch);
                if (uc != UnicodeCategory.NonSpacingMark) sb.Append(ch);
            }
            return sb.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}
