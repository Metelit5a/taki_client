using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakiClient
{
    public partial class Form1 : Form
    {
        public List<TransparentControl> cardsControls;
        public int xCardMove, yCardMove;
        Hand hand;

        public Form1()
        {

            InitializeComponent();
            this.Load += Form1_Load;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Point x = JoinGamePanel.Location;
            JoinGamePanel.Parent = GamePanel;
            JoinGamePanel.Location = CreateGamePanel.Location;
            xCardMove = 470;
            yCardMove = 120;

          //  DisablePanels();

             Card[] cards = {
                new Card("number_card", "red", "4"),
                new Card("number_card", "blue", "3"),
                new Card("number_card", "yellow", "8"),
                new Card("number_card", "blue", "taki"),
                new Card("change_direction", "red", ""),
                new Card("stop", "green", ""),
                new Card("super_taki", "", ""),
                new Card("number_card", "red", "4"),
            };
            hand = new Hand(cards);
            hand.F = this;
            cardsControls = hand.GetCardsPics();
            
            foreach (var control in cardsControls)
            {   
                this.Controls.Add(control); 
            }
        }

       
        private void RotateImage(TransparentControl pb, Image img, float angle)
        {
            if (img == null || pb.Image == null)
                return;

            Image oldImage = pb.Image;
            pb.Image = Utilities.RotateImage(img, angle);
            if (oldImage != null)
            {
                oldImage.Dispose();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GamePanel.Visible = true;
            CreateGamePanel.Visible = true;
            JoinGamePanel.Visible = false;
        }
        public void EnableCardsTimer()
        {
            CardsTimer.Enabled = true;
        }
        private void CardsTimer_Tick(object sender, EventArgs e)
        {

    //         IEnumerable<Control> control = this.Controls.Find("super_taki", false);
    //      TransparentControl pic = (TransparentControl)control.First();
            hand.currentPut.Location = new Point(hand.currentPut.Location.X, hand.currentPut.Location.Y - 10);
            if (hand.currentPut.Location.X == xCardMove && hand.currentPut.Location.Y == yCardMove)
                CardsTimer.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GamePanel.Visible = false;
            CreateGamePanel.Visible = false;
            JoinGamePanel.Visible = false;

            //hand.RemoveCard("number_cardred4");
            //StartGame(code);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hand.RemoveCard("super_taki");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //CreateGame(LobbyName.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // JoingGame(JoinGameText.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GamePanel.Visible = true;
            CreateGamePanel.Visible = false;
            JoinGamePanel.Visible = true;

        }
    }

    public class Hand
    {
        private int baseY = 400;
        private int baseX = 420;
        private int startMoveX = 470;
        private int startMoveY = 410;
        private List<TransparentControl> cardsPics;
        private Card[] cardsArr;
        public Form1 F;
        public TransparentControl currentPut;

        public Hand(Card[] cards)
        {
            this.cardsArr = cards;
            this.cardsPics = Render(cardsArr);
          //  this.cards = cards;
        }

        public List<TransparentControl> GetCardsPics()
        {
            if (cardsPics != null)
                return cardsPics;
            else return new List<TransparentControl>();
        }
        public List<TransparentControl> Render(Card[] cards)
        {
            List<TransparentControl> returnList = new List<TransparentControl>();

            for (int i = 0; i < cards.Length; i++)
            {
                TransparentControl pict = new TransparentControl();
                pict.Size = new Size(300, 300);
               
                if (i >= cards.Length / 2 && cards.Length % 2 == 0)
                {
                    pict.Location = new Point(baseX + (i - cards.Length / 2) * 40, baseY + Math.Abs((i + 1 - cards.Length / 2) * 10));
                    string imageLoc = @"C:\Users\dorav\Desktop\Taki\" + cards[i].getPath();
                    pict.Image = Bitmap.FromFile(imageLoc);
                    RotateImage(pict, pict.Image, (i + 1 - cards.Length / 2) * 10);
                }
                else
                {
                    pict.Location = new Point(baseX + (i - cards.Length / 2) * 40, baseY + Math.Abs((i - cards.Length / 2) * 10));
                    string imageLoc = @"C:\Users\dorav\Desktop\Taki\" + cards[i].getPath();
                    pict.Image = Bitmap.FromFile(imageLoc);
                    RotateImage(pict, pict.Image, (i - cards.Length / 2) * 10);
                }
                
             //   pict.Image = Properties.Resources.yellow_3;
                pict.BringToFront();
                pict.Name = cards[i].GetName();

                returnList.Add(pict);

            }
 

            return returnList;
        }
        public void RemoveCard(string cardName)
        {
            Card[] newArr = new Card[cardsArr.Length - 1];
            bool found = false;
            for (int i = 0; i < cardsArr.Length; i++) // removing the card from cardsArr
            {
                if(cardsArr[i].GetName() == cardName && !found)
                {
                    found = true;
                    continue;
                }
                if(found)
                    newArr[i-1] = cardsArr[i];
                else
                    newArr[i] = cardsArr[i];
            }
            cardsArr = newArr;
            if (found)
            {  
                foreach (var control in cardsPics) // Deleting the cards in the hand
                {
                   control.Dispose();
                }
            
                this.cardsPics = new List<TransparentControl>();
                this.cardsPics = Render(cardsArr); // creating the cards in the hand
                foreach (var control in cardsPics) // adding them to Controls
                {
                    F.Controls.Add(control);
                }

                currentPut = new TransparentControl();
                currentPut.Size = new Size(300, 300);
                currentPut.Location = new Point(startMoveX,startMoveY);
                string imageLoc = @"C:\Users\dorav\Desktop\Taki\" + cardName+".png";
                currentPut.Image = Bitmap.FromFile(imageLoc);
                F.Controls.Add(currentPut);
                F.EnableCardsTimer();
            }
            else
            {
                MessageBox.Show("Couldn't find " + cardName + "In my hand");
            }
        }

        private void RotateImage(TransparentControl pb, Image img, float angle)
        {
            if (img == null || pb.Image == null)
                return;

            Image oldImage = pb.Image;
            pb.Image = Utilities.RotateImage(img, angle);
            if (oldImage != null)
            {
                oldImage.Dispose();
            }

        }
    }


    public class Card
    {
        private string type;
        private string color;
        private string value;
        private string path;
        private string name;
  //      public System.Windows.Forms.PictureBox picture;

        public Card(string type, string color, string value)
        {
            this.type = type;
            this.color = color;
            this.value = value;
            //  string basePath = "C:\\Users\\dorav\\Desktop\\Taki\\";
            string basePath = "";
            if (type == "super_taki")
            {
                this.path = basePath + type + ".png";
            }
            else if(type == "change_direction" || type == "taki" || type == "stop" || type == "plus" || type == "plus_2")
            {
                this.path = basePath + color + " " + type + ".png";
                
            }
            else
            {
                this.path = basePath + color +" " +value + ".png"; // for example c:/.../red 2.png
            }
            this.name = type + color + value;
        }

        public string getPath()
        {
            return this.path;
        }
        public string GetName()
        {
            return this.name;
        }
    }


    public class TransparentControl : Control
    {
        private readonly Timer refresher;
        private Image _image;

        public TransparentControl()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
            refresher = new Timer();
            refresher.Tick += TimerOnTick;
            refresher.Interval = 50;
            refresher.Enabled = true;
            refresher.Start();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x20;
                return cp;
            }
        }

        protected override void OnMove(EventArgs e)
        {
            RecreateHandle();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            if (_image != null)
            {
                e.Graphics.DrawImage(_image, (Width / 2) - (_image.Width / 2), (Height / 2) - (_image.Height / 2));
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //Do not paint background
        }

        //Hack
        public void Redraw()
        {
            RecreateHandle();
        }

        private void TimerOnTick(object source, EventArgs e)
        {
            RecreateHandle();
            refresher.Stop();
        }

        public Image Image
        {
            get
            {
                return _image;
            }
            set
            {
                _image = value;
                RecreateHandle();
            }
        }
    }


}
