using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void clickMeButton_Click(object sender, EventArgs e)
        {
            List<string> list = input.Text.Split(',').ToList<string>();
            int i = 1;
            output.Text = "";
            foreach (var sequence in list.AllCombinations())
            {
                if (string.Join(" ", sequence) != "")
                {
                    if (i == 1)
                    {
                        output.Text += (i.ToString() + ")" + " " + string.Join(" ", sequence));
                        i++;
                    }
                    else
                    {
                        output.Text += (Environment.NewLine + i.ToString() + ")" + " " + string.Join(" ", sequence));
                        i++;
                    }
                }
            }
        }

        public void Button2_Click(object sender, EventArgs e)
        {
            input.Text = "";
            output.Text = "";
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
            for (int i = 0; i < source.Count + 1; i++)
            {
                output = output.Concat(source.Combinations(i));
            }
            return output;
        }
    }
}
