using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace DecimalTextBox
{
    public class DecimalTextbox:TextBox
    {
        public DecimalTextbox()
        {
            base.TextAlign = HorizontalAlignment.Center;
        }
        
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '.' || e.KeyChar  == '\b')
            {
                
                e.Handled = false;
                if(base.Text.Contains(".") && e.KeyChar == '.' )
                    e.Handled = true;

            }
            else
            {
                e.Handled = true;
            }
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            if (base.Text == "0")
                base.Text = "";
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            if (base.Text == "")
                base.Text = "0";
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            base.Text = "0";
            
        }

        

    }
}
