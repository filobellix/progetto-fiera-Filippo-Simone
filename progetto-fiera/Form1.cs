namespace progetto_fiera
{
    public partial class Form1 : Form
    {
        Bitmap immagineOriginale;
        Bitmap immagineResize;
        int sat = 127;
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void buttonBaW_Click(object sender, EventArgs e)
        {
            Bitmap conv = new Bitmap(immagineResize, immagineResize.Width, immagineResize.Height);

            for (int x = 0; x < conv.Width; x++)
            {
                for (int y = 0; y < conv.Height; y++)
                {
                    Color c = immagineResize.GetPixel(x, y);
                    int media = (int)((c.R + c.G + c.B) / 3);
                    conv.SetPixel(x, y, Color.FromArgb(media, media, media));
                }
            }
            pictureBox1.Image = conv;
        }

        private void trackBarSaturazione_Scroll(object sender, EventArgs e)
        {
            sat = trackBarSaturazione.Value;
            labelSaturazione.Text = sat.ToString();
            Bitmap conv = new Bitmap(immagineResize, immagineResize.Width, immagineResize.Height);

            for (int x = 0; x < conv.Width; x++)
            {
                for (int y = 0; y < conv.Height; y++)
                {
                    Color c = immagineResize.GetPixel(x, y);
                    int media = (int)((c.R + c.G + c.B) / 3);
                    if (media > sat) media = 255;
                    else media = 0;
                    conv.SetPixel(x, y, Color.FromArgb(media, media, media));
                }
            }
            pictureBox1.Image = conv;
        }

        private void buttonApri_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {

                immagineOriginale = new Bitmap(open.FileName);


                float fatform = (float)immagineOriginale.Width / (float)pictureBox1.Width;

                immagineResize = new Bitmap(immagineOriginale,
                    new Size(
                        (int)(immagineOriginale.Width / fatform),
                        (int)(immagineOriginale.Height / fatform)
                        )
                    );
                pictureBox1.Image = immagineResize;
            }
        }
    }
}