using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//OBS:
//      Nao detecta colisao da aranha com o rastro
//      Nao muda velocidade da aranha(a rotina esta dentro de verifyWEB)
//      *** serao implementados na prox versao

namespace Spider
{
    public partial class Form1 : Form
    {
        //qnto < o valor do timer, mais rapida ela anda
        //qnto < o valor do incremento, + preciso é o movimento da aranha
        private int xInc, yInc,score,moves, time/*verifyWeb(), gameOver() e resetGame()*/,defaultTime=12;
        private Keys spiderDir;
        PictureBox[] spiderTrace;

        public Form1()
        {
            InitializeComponent();
            Controls.SetChildIndex(spider, 5);//so para a aranha(spider) ficar acima dos objetos de teia(web)
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            resetGame();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space || e.KeyData == Keys.Up || e.KeyData == Keys.Left || e.KeyData == Keys.Right || e.KeyData == Keys.Down)
            {
                spiderDir = e.KeyData;
                timer1.Enabled = true;
                lbTimerStatus.Text = timer1.Enabled.ToString();
            }
            lbLastKeyPressed.Text = e.KeyData.ToString();

        }

        private void resetGame()
        {
            xInc = 24;
            yInc = 24;
            score = 0;
            moves = 0;
            time = defaultTime;//10 segundos para pegar cada teia
            timer1.Interval = 250;//"17"


            spider.Location = new Point(276, 492);
            lbPlacar.Text = score.ToString();
            lbMoves.Text = moves.ToString();
            lbTime.Text = time.ToString();

            if (spiderTrace != null)
                destroySpiderTrace();// para limpar o rastro do jogo anterior...
            spiderTrace = new PictureBox[0];

            newWeb();//gera nova teia
            web.Visible = true;//torna ela visivel

            spider.Image = global::Spider.Properties.Resources.spiderU;
            spider.Enabled = true;
            spiderDir = Keys.Up;//up
            btIniciar.Enabled = false;
            this.Focus();
            timer1.Enabled = true;//aranha comeca se movimentar
            timerCountdown.Enabled = true;//ativa contagem regressiva para pegar a teia

            //###Debug Info
            lbTimerStatus.Text = timer1.Enabled.ToString();
            lbTimerIncrement.Text = timer1.Interval.ToString();
            lbSpiderIncrement.Text = xInc.ToString();
            lbSpiderLocation.Text = spider.Location.ToString();
            lbWebLocation.Text = web.Location.ToString();
            lbSpiderDirection.Text = spiderDir.ToString();
            lbSpiderTraceLenght.Text = "0";
            //###End
        }
        private void destroySpiderTrace()
        {
            for (int i = 0; i < spiderTrace.Length; i++)
            {
                Controls.Remove(spiderTrace[i]);
            }
        }
        private void gameOver()
        {
            timerCountdown.Enabled = false;//para contagem regressiva para pegar teias
            timer1.Enabled = false;//para movimentos da aranha
            lbTimerStatus.Text = timer1.Enabled.ToString();

            spider.Enabled = false;
            web.Visible = false;
            btIniciar.Enabled = true;
            if (MessageBox.Show("Retry ?", "Game Over !", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) == DialogResult.Retry)
                btIniciar.PerformClick();
        }


        private void testArenaLimitUp()
        {
            if (spider.Location.Y <= arena.Location.Y)
            {
                gameOver();
            }
            else
            {
                spider.Image = global::Spider.Properties.Resources.spiderU;
                moveOK();
                spider.Location = new Point(spider.Location.X, spider.Location.Y - yInc);
                lbSpiderLocation.Text = spider.Location.ToString();
                verifyWeb(spider.Location.X, spider.Location.Y);
            }
        }
        private void testArenaLimitDown()
        {
            if (spider.Location.Y + 24 >= arena.Location.Y + arena.Size.Height)
            {
                gameOver();
            }
            else
            {
                spider.Image = global::Spider.Properties.Resources.spiderD;
                moveOK();
                spider.Location = new Point(spider.Location.X, spider.Location.Y + yInc);
                lbSpiderLocation.Text = spider.Location.ToString();
                verifyWeb(spider.Location.X, spider.Location.Y);
            }
        }
        private void testArenaLimitLeft()
        {
            if (spider.Location.X <= arena.Location.X)
            {
                gameOver();
            }
            else
            {
                spider.Image = global::Spider.Properties.Resources.spiderL;
                moveOK();
                spider.Location = new Point(spider.Location.X - xInc, spider.Location.Y);
                lbSpiderLocation.Text = spider.Location.ToString();
                verifyWeb(spider.Location.X, spider.Location.Y);
            }
        }
        private void testArenaLimitRight()
        {
            if (spider.Location.X + 24 >= arena.Location.X + arena.Size.Width)
            {
                gameOver();
            }
            else
            {
                spider.Image = global::Spider.Properties.Resources.spiderR;
                moveOK();
                spider.Location = new Point(spider.Location.X + xInc, spider.Location.Y);
                lbSpiderLocation.Text = spider.Location.ToString();
                verifyWeb(spider.Location.X, spider.Location.Y);
            }
        }

        private void moveOK()
        {
            moves++;
            lbMoves.Text = moves.ToString();
            moveTrace(spider.Location);
        }
        private void moveTrace(Point pCurrent)
        {
            for (int i = spiderTrace.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                    spiderTrace[i].Location = pCurrent;
                else
                    spiderTrace[i].Location = spiderTrace[i - 1].Location;
            }
        }

        private void verifyWeb(int x, int y)//os argumentos sao a posicao da aranha.... verificar a possibilidade de remover esses argumentos.. utilizar classe Point() para coordenada
        {   //verifica se ao menos 1 dos 4 cantos da aranha tocaram na teia
            if ((y >= web.Location.Y && y <= web.Location.Y + web.Size.Height && x >= web.Location.X && x <= web.Location.X + web.Size.Width) ||                                          // c1  ---  c2
                (y >= web.Location.Y && y <= web.Location.Y + web.Size.Height && x + spider.Size.Width >= web.Location.X && x + spider.Size.Width <= web.Location.X + web.Size.Width) ||  //    |   |
                (y + spider.Size.Height >= web.Location.Y && y + spider.Size.Height <= web.Location.Y + web.Size.Height && x >= web.Location.X && x <= web.Location.X + web.Size.Width) ||// c3  ---  c4
                (y + spider.Size.Height >= web.Location.Y && y + spider.Size.Height <= web.Location.Y + web.Size.Height && x + spider.Size.Width >= web.Location.X && x + spider.Size.Width <= web.Location.X + web.Size.Width)
                )
            {
                score++;
                lbPlacar.Text = score.ToString();

                //aumenta a velocidade
                if (timer1.Interval > 1)
                {
                    //timer1.Interval -= 1;
                    lbTimerIncrement.Text = timer1.Interval.ToString(); //remover.... somente para degub
                }
                else if (xInc <= 10)
                {
                    //xInc += 1;
                    //yInc += 1;
                    lbSpiderIncrement.Text = xInc.ToString();//remover.... somente para degub
                }

                //adiciona um trace
                newSpiderTrace(new Point(x, y));//x,y localizacao atual da aranha
                //gera nova teia
                newWeb();
                //reseta time
                time = defaultTime;
            }
        }
        private void newSpiderTrace(Point pLast)
        {
            Array.Resize<PictureBox>(ref spiderTrace, spiderTrace.Length + 1);
            lbSpiderTraceLenght.Text = spiderTrace.Length.ToString();
            spiderTrace[spiderTrace.Length - 1] = new PictureBox();
            spiderTrace[spiderTrace.Length - 1].Image = global::Spider.Properties.Resources.web;
            spiderTrace[spiderTrace.Length - 1].Size = new Size(24, 24);
            //insere um novo rastro na posicao da aranha.....
            spiderTrace[spiderTrace.Length - 1].Location = pLast;
            Controls.Add(spiderTrace[spiderTrace.Length - 1]);
            Controls.SetChildIndex(spiderTrace[spiderTrace.Length - 1], 9);//9 no index para ficar acima da arena e abaixo da aranha
        }
        private void newWeb()
        {
            Random ran;
            Point p = new Point();
            ran = new Random();
            //nao gera multiplo de 24 entao, fica desalinhado com a aranha
            p.X = ran.Next(arena.Location.X, arena.Location.X + arena.Size.Width - web.Size.Width);
            p.Y = ran.Next(arena.Location.Y, arena.Location.Y + arena.Size.Height - web.Size.Height);

            web.Location = p;
            lbWebLocation.Text = web.Location.ToString();
        }

        private void timerCountdown_Tick(object sender, EventArgs e)
        {
            time--;
            lbTime.Text = time.ToString();
            if (time == 0)
                gameOver();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (spiderDir)
            {
                case Keys.Up://up
                    timerCountdown.Enabled = true;
                    lbSpiderDirection.Text = spiderDir.ToString();
                    testArenaLimitUp();
                    break;
                case Keys.Down://down
                    timerCountdown.Enabled = true;
                    lbSpiderDirection.Text = spiderDir.ToString();
                    testArenaLimitDown();
                    break;
                case Keys.Left://left
                    timerCountdown.Enabled = true;
                    lbSpiderDirection.Text = spiderDir.ToString();
                    testArenaLimitLeft();
                    break;
                case Keys.Right://right
                    timerCountdown.Enabled = true;
                    lbSpiderDirection.Text = spiderDir.ToString();
                    testArenaLimitRight();
                    break;
                case Keys.Space:
                    timerCountdown.Enabled = false;//para contagem regressiva pq o game ta pausado
                    timer1.Enabled = false;
                    lbTimerStatus.Text = timer1.Enabled.ToString();
                    MessageBox.Show("Game Paused! Press Arrow keys to Resume!", "PAUSE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    break;
            }

        }

      

    }
}