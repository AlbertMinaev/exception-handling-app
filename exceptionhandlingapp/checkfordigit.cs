using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exceptionhandlingapp;
using System.Windows.Forms;

namespace exceptionhandlingapp
{
    class checkfordigit
    {
        
            
            private void tbz_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                try
                {
                    if (!char.IsDigit(e.KeyChar) == false)
                    {
                        throw new Exception("Строка должна содержать только целые числа!");

                    }
                }

                catch (Exception c)
                {
                    MessageBox.Show("Ошибка: " + c.Message);
                }
            }

        }
        
            
            }

    }

            
            



        
    

    


