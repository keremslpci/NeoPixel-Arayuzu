using System;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;
using System.Drawing;
using System.Threading.Tasks;

namespace NeoPixelController
{
    public partial class NeoPixelController : Form
    {
        SerialPort serialPort = new SerialPort();
        private static readonly string CustomColorsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "customColors.txt"); // Dosya yolu
        private const int SerialTimeout = 5000; // Seri port zaman aşımı süresi (ms)
        private int[] _previousCustomColors; // Önceki özel renkleri sakla
        private Timer statusCheckTimer;

        public NeoPixelController()
        {
            InitializeComponent();
            GetAvailablePorts(); // Form açıldığında portları listele
            _previousCustomColors = LoadCustomColorsFromFile(); // Başlangıçta özel renkleri yükle
            statusCheckTimer = new Timer();
            statusCheckTimer.Interval = 1000;  // 1 saniyede bir kontrol et
            statusCheckTimer.Tick += StatusCheckTimer_Tick;  // Timer olayı
            statusCheckTimer.Start();

       
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;// Form çerçevesini kaldır
        }
        private void StatusCheckTimer_Tick(object sender, EventArgs e)
        {
            // Seri port kapalıysa veya bağlantı koptuysa buton rengini kırmızı yap
            if (!serialPort.IsOpen)
            {
                btnConnect.Text = "Connect";
                btnConnect.BackColor = Color.FromArgb(123, 255, 128);
            }
        }
        private void GetAvailablePorts()
        {
            comboBoxPorts.ForeColor = Color.Black;
            comboBoxPorts.BackColor = Color.White;
            this.TransparencyKey = Color.Empty;

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

        private async void btnColor_Click(object sender, EventArgs e)
        {
            if (!CheckSerialConnection()) return;

            using (ColorDialog colorDialog = new ColorDialog())
            {
                // Özel renkleri dosyadan yükle
                colorDialog.CustomColors = _previousCustomColors;

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    // Seçilen rengi al
                    Color color = colorDialog.Color;

                    // Renk bilgisini seri porta gönder
                    string command = $"A {color.R} {color.G} {color.B}\n";
                    await SendSerialCommand(command);
                    await Task.Delay(70); // 70 ms bekle
                    await SendSerialCommand(command);

                    // Özel renkler değişmişse kaydet
                    if (!AreColorsEqual(_previousCustomColors, colorDialog.CustomColors))
                    {
                        SaveCustomColorsToFile(colorDialog.CustomColors);
                        _previousCustomColors = colorDialog.CustomColors; // Önceki renkleri güncelle
                    }
                }
            }
        }

        private int[] LoadCustomColorsFromFile()
        {
            try
            {
                if (File.Exists(CustomColorsFilePath))
                {
                    string[] lines = File.ReadAllLines(CustomColorsFilePath);
                    return Array.ConvertAll(lines, int.Parse);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Renkler yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return new int[0]; // Dosya yoksa veya hata oluşursa boş dizi döndür
        }

        private void SaveCustomColorsToFile(int[] customColors)
        {
            try
            {
                string[] lines = Array.ConvertAll(customColors, x => x.ToString());
                File.WriteAllLines(CustomColorsFilePath, lines);
                MessageBox.Show("Renkler başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Renkler kaydedilirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AreColorsEqual(int[] colors1, int[] colors2)
        {
            if (colors1 == null || colors2 == null || colors1.Length != colors2.Length)
                return false;

            for (int i = 0; i < colors1.Length; i++)
            {
                if (colors1[i] != colors2[i])
                    return false;
            }
            return true;
        }

        private async void btnRainbow_Click(object sender, EventArgs e)
        {
            if (!CheckSerialConnection()) return;
            await SendSerialCommand("B\n");
        }

        private async void btnfire_Click(object sender, EventArgs e)
        {
            if (!CheckSerialConnection()) return;
            await SendSerialCommand("C\n");
        }

        private async void btnFadeOut_Click(object sender, EventArgs e)
        {
            if (!CheckSerialConnection()) return;
            await SendSerialCommand("D\n");
        }

        private async void btnTheaterChase_Click(object sender, EventArgs e)
        {
            if (!CheckSerialConnection()) return;
            await SendSerialCommand("E\n");
        }

        private async void btnStrobe_Click(object sender, EventArgs e)
        {
            if (!CheckSerialConnection()) return;
            await SendSerialCommand("F\n");
        }

        private async void btnCylon_Click(object sender, EventArgs e)
        {
            if (!CheckSerialConnection()) return;
            await SendSerialCommand("G\n");
        }

        private async void btnRandomTwinkle_Click(object sender, EventArgs e)
        {
            if (!CheckSerialConnection()) return;
            await SendSerialCommand("H\n");
        }

        private async void btnSparkle_Click(object sender, EventArgs e)
        {
            if (!CheckSerialConnection()) return;
            await SendSerialCommand("I\n");
        }

        private async void btnRunningLights_Click(object sender, EventArgs e)
        {
            if (!CheckSerialConnection()) return;
            await SendSerialCommand("J\n");
        }

        private async void btnMeteorRain_Click(object sender, EventArgs e)
        {
            if (!CheckSerialConnection()) return;
            await SendSerialCommand("K\n");
        }

        private async void kapat_Click(object sender, EventArgs e)
        {
            if (!CheckSerialConnection()) return;
            await SendSerialCommand("L\n");
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close(); // Önce kapat
                btnConnect.BackColor = Color.FromArgb(123, 255, 128);
                btnConnect.Text = "Connect";
                MessageBox.Show($"Bağlantı Kesildi: {serialPort.PortName}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    serialPort.PortName = comboBoxPorts.SelectedItem.ToString(); // Seçilen portu al
                    serialPort.BaudRate = 115200; // Baud rate ayarla
                    serialPort.Open(); // Portu aç

                    btnConnect.Text = "Disconnect";
                    btnConnect.BackColor = Color.Red;

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

        private void NeoPixelController_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        private bool CheckSerialConnection()
        {
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("Seri port bağlantısı açık değil!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private async Task SendSerialCommand(string command)
        {
            try
            {
                serialPort.WriteTimeout = SerialTimeout; // Zaman aşımı süresini ayarla
                await Task.Run(() => serialPort.Write(command)); // Seri port yazma işlemini arka plan iş parçacığına taşı
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Seri port zaman aşımı! Bağlantı kesildi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                serialPort.Close();
                btnConnect.Text = "Connect";
                btnConnect.BackColor = Color.FromArgb(123, 255, 128);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seri port hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                serialPort.Close();
                btnConnect.Text = "Connect";
                btnConnect.BackColor = Color.FromArgb(123, 255, 128);
            }
        }

        private async void btn_SequentialColor_Click(object sender, EventArgs e)
        {
            if (!CheckSerialConnection()) return;
            await SendSerialCommand("M\n");
        }

        private async void btnPoliceLights_Click(object sender, EventArgs e)
        {
            if (!CheckSerialConnection()) return;
            await SendSerialCommand("N\n");
        }

        private async void btn_Colorful_Click(object sender, EventArgs e)
        {
            if (!CheckSerialConnection()) return;
            await SendSerialCommand("O\n");
        }
    }
}