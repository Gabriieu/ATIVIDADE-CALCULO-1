using System.Text;

namespace CalculadoraVolume
{
    public partial class Form1 : Form
    {
        double pi = Math.PI;
        double cilindro1, cilindro2, cilindro3, cone1, cone2, volume;

        public Form1()
        {
            InitializeComponent();
        }

        public double calcularVolumeCilindro(double raio, double altura)
        {
            return pi * Math.Pow(raio, 2) * altura;
        }

        public double calcularVolumeConeTruncado(double raioMaior, double raioMenor, double altura)
        {
            return (pi * altura / 3) * (Math.Pow(raioMaior, 2) + raioMaior * raioMenor + Math.Pow(raioMenor, 2));
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double altura = (double)inputUser.Value;

            if (altura <= 7.8)
            {
                cilindro1 = calcularVolumeCilindro(15.25, altura);
                cone1 = 0;
                cilindro2 = 0;
                cone2 = 0;
                cilindro3 = 0;
            }
            else if (altura <= 13.8)
            {
                double variacaoRaio = (50.2 - 15.25) / 6;
                double alturaCone = altura - 7.8;
                double raioMaior = 15.25 + alturaCone * variacaoRaio;
                cilindro1 = calcularVolumeCilindro(15.25, 7.8);
                cone1 = calcularVolumeConeTruncado(raioMaior, 15.25, alturaCone);
                cilindro2 = 0;
                cone2 = 0;
                cilindro3 = 0;
            }
            else if (altura <= 118.3)
            {
                double alturaCilindro = altura - 13.8;
                cilindro1 = calcularVolumeCilindro(15.25, 7.8);
                cone1 = calcularVolumeConeTruncado(50.2, 15.25, 6);
                cilindro2 = calcularVolumeCilindro(50.2, alturaCilindro);
                cone2 = 0;
                cilindro3 = 0;
            }
            else if (altura <= 123.3)
            {
                double variacaoRaio = (50.2 - 21.25) / 5;
                double alturaCone = altura - 118.3;
                double raioMenor = 50.2 - alturaCone * variacaoRaio;
                cilindro1 = calcularVolumeCilindro(15.25, 7.8);
                cone1 = calcularVolumeConeTruncado(50.2, 15.25, 6);
                cilindro2 = calcularVolumeCilindro(50.2, 104.5);
                cone2 = calcularVolumeConeTruncado(50.2, raioMenor, alturaCone);
                cilindro3 = 0;
            }
            else
            {
                double alturaCilindro = altura - 123.3;
                cilindro1 = calcularVolumeCilindro(15.25, 7.8);
                cone1 = calcularVolumeConeTruncado(50.2, 15.25, 6);
                cilindro2 = calcularVolumeCilindro(50.2, 104.5);
                cone2 = calcularVolumeConeTruncado(50.2, 21.25, 5);
                cilindro3 = calcularVolumeCilindro(21.25, alturaCilindro);
            }

            volume = cilindro1 + cilindro2 + cilindro3 + cone1 + cone2;
            labelCm3.Text = volume.ToString("F1") + " cm³";
            labelL.Text = (volume / 1000).ToString("F3") + " L";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Alunos alunos = new Alunos();
            alunos.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Grafico grafico = new Grafico();
            grafico.ShowDialog();
        }
    }
}
