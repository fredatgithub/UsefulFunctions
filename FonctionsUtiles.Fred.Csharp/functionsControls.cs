/*
The MIT License(MIT)
Copyright(c) 2015 Freddy Juhel
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using System.Windows.Forms;

namespace FonctionsUtiles.Fred.Csharp
{
  public class FunctionsControls
  {
    public TextBoxBase WhatTextBoxHasFocus()
    {
      TextBoxBase result = null;
      //foreach (var control in Control.ControlCollection.Controls.OfType<TextBoxBase>())
      //{
      //  if (control.Focused)
      //  {
      //    result = control;
      //    break;
      //  }
      //}

      return result;
    }

    public static void AcceptOnlyNumbers(Control textBox)
    {
      int value;
      if (!int.TryParse(textBox.Text, out value))
      {
        textBox.Text = string.Empty;
      }
    }

    public static bool IsInlistView(ListView listView, ListViewItem lviItem, int columnNumber = 1)
    {
      // return listView.Items.Cast<ListViewItem>().All(item => item.SubItems[columnNumber].Text != lviItem.SubItems[columnNumber].Text);
      bool result = false;
      foreach (ListViewItem item in listView.Items)
      {
        if (item.SubItems[columnNumber].Text == lviItem.SubItems[columnNumber].Text)
        {
          result = true;
          break;
        }
      }

      return result;
    }
  }
}