namespace Calculadora
{
    public partial class Form1 : Form
    {
        double Numero1 = 0, Numero2 = 0;
        char Operador;

        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void agregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            if (txtResultado.Text == "0")
                txtResultado.Text = "";

            txtResultado.Text += boton.Text;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            Numero2 = Convert.ToDouble(txtResultado.Text);

            if(Operador == '+')
            {
                txtResultado.Text = (Numero1 + Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (Operador == '-')
            {
                txtResultado.Text = (Numero1 - Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (Operador == 'X')
            {
                txtResultado.Text = (Numero1 * Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (Operador == '�')
            {
                txtResultado.Text = (Numero1 / Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);
            }
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(txtResultado.Text.Length > 1)
            {
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
            }
            else
            {
                txtResultado.Text = "0";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            Numero1 = 0;
            Numero2 = 0;
            Operador = '\0';
            txtResultado.Text = "0";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains("."))
            {
                txtResultado.Text += ".";
            }
        }

        private void clickOperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            Numero1 = Convert.ToDouble(txtResultado.Text);
            Operador = Convert.ToChar(boton.Tag);


            if (Operador == '�')
            {
                Numero1 = Math.Pow(Numero1, 2);
                txtResultado.Text = Numero1.ToString();
            }
            else
            {
                txtResultado.Text = "0";
            }

            

            
        }


    }
}