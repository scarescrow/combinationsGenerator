using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> list = textBox1.Text.Split(',').ToList<string>();
            int i=1;
            foreach (var sequence in list.AllCombinations())
            {
                richTextBox1.Text+=(i.ToString() + ">" + string.Join(" ", sequence) + Environment.NewLine);
                i++;
            }
        }

    }
    public static class a
    {
        public static IEnumerable<IEnumerable<T>> Combinations<T>(this IEnumerable<T> source, int n)
        {
            if (n == 0)
                yield return Enumerable.Empty<T>();


            int count = 1;
            foreach (T item in source)
            {
                foreach (var innerSequence in source.Skip(count).Combinations(n - 1)
)
                {
                    yield return new T[] { item }.Concat(innerSequence);
                }
                count++;
            }
        }
        public static IEnumerable<IEnumerable<T>> AllCombinations<T>(this IList<T> source)
        {
            IEnumerable<IEnumerable<T>> output = Enumerable.Empty<IEnumerable<T>>();
            for (int i = 0; i < source.Count+1; i++)
            {
                output = output.Concat(source.Combinations(i));
            }
            return output;
        }
    }
}
