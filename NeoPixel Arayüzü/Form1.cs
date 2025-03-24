using System;
using System.IO.Ports;
using System.Windows.Forms;
using System.Drawing;

namespace NeoPixelController
{
    public partial class NeoPixelController : Form
    {
        SerialPort serialPort = new SerialPort();

        public NeoPixelController()
        {
            InitializeComponent();
            GetAvailablePorts(); // Form açıldığında portları listele

        }
        private void GetAvailablePorts()
        {
            comboBoxPorts.Items.Clear(); // Önce temizle
            string[] ports = SerialPort.GetPortNames(); // Mevcut COM portlarını al

            if (ports.Length > 0)
            {
                comboBoxPorts.Items.AddRange(ports);
                comboBoxPorts.SelectedIndex = 0; // Varsayılan olarak ilk portu seç
            }
            else
            {
                MessageBox.Show("Hiçbir COM portu bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color color = colorDialog.Color;
                    string command = $"RGB {color.R} {color.G} {color.B}\n";
                    serialPort.Write(command);
                }
            }
        }

        private void btnRainbow_Click(object sender, EventArgs e)
        {
            serialPort.Write("RAINBOW\n");
        }

        private void btnBlink_Click(object sender, EventArgs e)
        {
            serialPort.Write("BLINK\n");
        }

        private void NeoPixelController_Load(object sender, EventArgs e)
        {

        }
        private void btnFadeOut_Click(object sender, EventArgs e)
        {
            serialPort.Write("FADEOUT\n");
        }

        private void btnTheaterChase_Click(object sender, EventArgs e)
        {
            serialPort.Write("THEATERCHASE\n");
        }

        private void btnStrobe_Click(object sender, EventArgs e)
        {
            serialPort.Write("STROBE\n");
        }

        private void btnCylon_Click(object sender, EventArgs e)
        {
            serialPort.Write("CYLON\n");
        }

        private void btnRandomTwinkle_Click(object sender, EventArgs e)
        {
            serialPort.Write("RANDOMTWINKLE\n");
        }

        private void btnSparkle_Click(object sender, EventArgs e)
        {
            serialPort.Write("SPARKLE\n");
        }

        private void btnRunningLights_Click(object sender, EventArgs e)
        {
            serialPort.Write("RUNNINGLIGHTS\n");
        }

        private void btnMeteorRain_Click(object sender, EventArgs e)
        {
            serialPort.Write("METEORRAIN\n");
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            serialPort.Write("KAPAT\n");
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close(); // Önce kapat
                btnConnect.Text = "Bağlan";
            }
            else
            {
                try
                {
                    serialPort.PortName = comboBoxPorts.SelectedItem.ToString(); // Seçilen portu al
                    serialPort.BaudRate = 115200; // Baud rate ayarla
                    serialPort.Open(); // Portu aç

                    btnConnect.Text = "Bağlantıyı Kes";
                    MessageBox.Show($"Bağlandı: {serialPort.PortName}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bağlantı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefreshPorts_Click(object sender, EventArgs e)
        {
            GetAvailablePorts();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

     
    }
}
