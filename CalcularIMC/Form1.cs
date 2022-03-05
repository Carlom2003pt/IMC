using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace CalcularIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
        }

        private void Calcular()
        {
            double imc, altura, peso;
            peso = double.Parse(textBoxPeso.Text);
            altura = double.Parse(textBoxAltura.Text);
            imc = peso / (altura * altura);
            textBox1.Text = imc.ToString();
            if (imc < 18.5)
            {
                label4.Text = "Abaixo do Peso";
                label6.Text = "Under Weight";
                label7.Text = "體重不足";
                label8.Text = "Bajo peso";
                label9.Text = "تحت الوزن";
                label10.Text = "Под весом";

            }

            if ((imc > 18.5) && (imc < 25))
            {
                label4.Text = "Peso Ideal";
                label6.Text = "Ideal Weight";
                label7.Text = "理想體重";
                label8.Text = "Peso ideal";
                label9.Text = "الوزن المثالي";
                label10.Text = "Идеальный вес";
            }



            if ((imc > 25.1) && (imc < 30))
            {
                label4.Text = "Levemente Acima do Peso";
                label6.Text = "Slightly Overweight";
                label7.Text = "有點超重";
                label8.Text = "Un poco de sobrepeso";
                label9.Text = "زيادة الوزن قليلا";
                label10.Text = "Немного избыточный вес";
            }



            if ((imc > 30.1) && (imc < 35))
            {
                label4.Text = "Obesidade Grau I";
                label6.Text = "Obesity Degree I";
                label7.Text = "肥胖I級";
                label8.Text = "Obesidad Grado I";
                label9.Text = "السمنة الصف الأول";
                label10.Text = "Ожирение I степени";
            }



            if ((imc > 35.1) && (imc < 40))
            {
                label4.Text = "Obesidade Grau II(Severa)";
                label6.Text = "Obesity Degree II(Severe)";
                label7.Text = "二級肥胖（嚴重）";
                label8.Text = "Obesidad de grado II (severa)";
                label9.Text = "السمنة من الدرجة الثانية (شديدة)";
                label10.Text = "Степень ожирения II степени (тяжелая)";
            }



            if (imc > 40.1)
            {
                label4.Text = "Obesidade Grau III(Mórbida)";
                label6.Text = "Obesity Degree III(Morbid)";
                label7.Text = "三級肥胖（病態）";
                label8.Text = "Obesidad de grado III (mórbido)";
                label9.Text = "السمنة من الدرجة الثالثة (المرضية)";
                label10.Text = "Степень ожирения III степени (болезненная)";
            }
            label6.Visible = false;

            
        }
        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            Calcular();
            
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxAltura.Text = "";
            textBoxPeso.Text = "";
            label4.Text = "";
            textBox1.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: //English
                    label1.Text = "Weight";
                    label2.Text = "Height";
                    label5.Text = "Result";
                    buttonLimpar.Text = "Clean";
                    buttonCalcular.Text = "Calculate";
                    label4.Visible = false;
                    label6.Visible = true;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    label11.Visible = false;
                    break;
                case 1: //Portuguese
                    label1.Text = "Peso";
                    label2.Text = "Altura";
                    label5.Text = "Resultado";
                    buttonLimpar.Text = "Limpar";
                    buttonCalcular.Text = "Calcular";
                    label4.Visible = true;
                    label6.Visible = false;
                    label7.Visible = false;
                    break;
                case 2: //Chinese
                    label1.Text = "重量";
                    label2.Text = "高度";
                    label5.Text = "結果";
                    buttonLimpar.Text = "清潔";
                    buttonCalcular.Text = "計算";
                    label4.Visible = false;
                    label6.Visible = false;
                    label7.Visible = true;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    label11.Visible = false;
                    break;
                case 3: //Spanish
                    label1.Text = "Peso";
                    label2.Text = "Altura";
                    label5.Text = "Resultado";
                    buttonLimpar.Text = "Limpiar";
                    buttonCalcular.Text = "Calcular";
                    label4.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = true;
                    label9.Visible = false;
                    label10.Visible = false;
                    label11.Visible = false;
                    break;
                case 4: //Arabic
                    label1.Text = "وزن";
                    label2.Text = "ارتفاع";
                    label5.Text = "نتيجة";
                    buttonLimpar.Text = "لينظف";
                    buttonCalcular.Text = "احسب";
                    label4.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = true;
                    label10.Visible = false;
                    label11.Visible = false;
                    break;
                case 5: //Russian
                    label1.Text = "вес";
                    label2.Text = "рост";
                    label5.Text = "результат";
                    buttonLimpar.Text = "чистить";
                    buttonCalcular.Text = "высчитывает";
                    label4.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = true;
                    label11.Visible = false;
                    break;
            }
        }

        private void textBoxAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                Calcular();
        }
    }
}
