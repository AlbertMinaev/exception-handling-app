using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exceptionhandlingapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }



        private void btn_check_Click(object sender, EventArgs e)
        {
            if (rbdigit.Checked)
            {
                tbzdigit.Visible = true;
                tbzchar.Visible = false;
                tbzdate.Visible = false;
                tbzword.Visible = false;
            }

            else
            {
                MessageBox.Show("Выбранный тип данных применен, введите значение в текстовое поле");
            }


            if (rbdate.Checked)
            {
                tbzdigit.Visible = false;
                tbzchar.Visible = false;
                tbzdate.Visible = true;
                tbzword.Visible = false;
            }

            else
            {
                
            }

            if (rbchar.Checked)
            {
                tbzdigit.Visible = false;
                tbzchar.Visible = true;
                tbzdate.Visible = false;
                tbzword.Visible = false;
            }

            else
            {
               
            }
            if (rbword.Checked)
            {
                tbzdigit.Visible = false;
                tbzchar.Visible = false;
                tbzdate.Visible = false;
                tbzword.Visible = true;
            }

            else
            {
               
            }
        }

        
        private void tbz_KeyPress(object sender, KeyPressEventArgs digit)

        {
            try
            {
                if (!char.IsDigit(digit.KeyChar) && digit.KeyChar != 8 == true)
                {
                    throw new Exception("Строка должна содержать только целые числа!");

                }
            }

            catch (Exception c)
            {
                MessageBox.Show("Ошибка: " + c.Message);
            }
        }



        private void tbzdate_KeyPress(object sender, KeyPressEventArgs date)

        {                      
                try
            {
                if (!char.IsDigit(date.KeyChar) && date.KeyChar != 8 && date.KeyChar != 46 && date.KeyChar != 32 &&(tbzdate.Text.Length <=10)  == true) 
                {
                    throw new Exception("Строка должна содержать только целые числа и знак разделения (точка), дата вводится в формате дд.мм.гггг!");

                }
            }

            catch (Exception c)
            {
                MessageBox.Show("Ошибка: " + c.Message);
            }
        }

        private void tbzchar_KeyPress(object sender, KeyPressEventArgs chr)
        {
            try
            {
                if (!char.IsSymbol (chr.KeyChar) && chr.KeyChar != 8 == true)
                {
                    throw new Exception("Строка должна содержать только символы Юникода!");

                }
            }

            catch (Exception c)
            {
                MessageBox.Show("Ошибка: " + c.Message);
            }
        }

        private void tbzword_KeyPress(object sender, KeyPressEventArgs word)
        {
            try
            {
                if (!char.IsLetter(word.KeyChar) && word.KeyChar != 8 == true)
                {
                    throw new Exception("Строка должна содержать только буквы Юникода!");

                }
            }

            catch (Exception c)
            {
                MessageBox.Show("Ошибка: " + c.Message);
            }
        }
        private void btn_check_MouseHover(object sender, EventArgs e)
        {
            ttpforbtn.SetToolTip(btn_check, "После нажатия на кнопку будет произведена проверка введенного значения в поле ниже. В случае, если введенное значение не соответсвует  выбранному типу данных появится сообщение об этом.");
        }
    }
}

    
    



       

        
  


   

       

