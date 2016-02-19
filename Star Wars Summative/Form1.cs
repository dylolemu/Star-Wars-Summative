using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Star_Wars_Summative
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;

            Graphics formGraphics = this.CreateGraphics();
            SolidBrush drawBrush1 = new SolidBrush(Color.Black);
            formGraphics.FillRectangle(drawBrush1, 0, 0, 500, 500);
            Font drawFont = new Font("Impact", 24, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.White);
            SolidBrush drawBrush2 = new SolidBrush(Color.Red);
            Font drawFont2 = new Font("Impact", 14 );
            Font drawFont1 = new Font("Impact", 15);

            //text begins to scroll up
            SoundPlayer player3 = new SoundPlayer(Properties.Resources.Theme);
            player3.Play();
            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 400);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 440);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 660);
            Thread.Sleep(100);
            Refresh();
        

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 395);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 435);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 655);
            Thread.Sleep(100);
            Refresh();


            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 390);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 430);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 650);
            Thread.Sleep(100);
            Refresh();
            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 385);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 425);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 645);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 380);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 420);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 640);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 375);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 415);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 635);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 370);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 410);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 630);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 365);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 405);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 625);
            Thread.Sleep(100);
            Refresh();


            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 360);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 400);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 620);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 355);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 395);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 615);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 350);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 390);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 610);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 345);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 385);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 605);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 340);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 380);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 600);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 335);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 375);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 595);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 330);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 370);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 590);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 325);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 365);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 585);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 320);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 360);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 580);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 315);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 355);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 575);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 310);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 350);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 570);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 305);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 345);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 565);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 300);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 340);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 560);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 295);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 335);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 555);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 290);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 330);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 550);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 285);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 325);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 545);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 280);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 320);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 540);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 275);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 315);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 535);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 270);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 310);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 530);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 265);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 305);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 525);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 260);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 300);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 520);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 255);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 295);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 515);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 250);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 290);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 510);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 245);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 285);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 505);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 240);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 280);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 500);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 235);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 275);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 495);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 230);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 270);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 490);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 225);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 265);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 485);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 220);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 260);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 480);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 215);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 255);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 475);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 210);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 250);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 470);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 205);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 245);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 465);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 200);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 240);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 460);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 195);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 235);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 455);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 190);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 230);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 450);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 185);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 225);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 445);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 180);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 220);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 440);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 175);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 215);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 435);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 170);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 210);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 430);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 165);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 205);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 425);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 160);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 200);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 420);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 155);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 195);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 415);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 150);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 190);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 410);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 145);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 185);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 405);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 140);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 180);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 400);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 135);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 175);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 395);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 130);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 170);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 390);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 125);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 165);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 385);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 120);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 160);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 380);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 115);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 155);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 375);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 110);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 150);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 370);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 105);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 145);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 365);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 100);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 140);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 360);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 95);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 135);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 355);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 90);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 130);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 350);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 85);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 125);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 345);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 80);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 120);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 340);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 75);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 115);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 335);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 70);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 110);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 330);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 65);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 105);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 325);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 60);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...", 
                drawFont1, drawBrush, 40, 100);
            formGraphics.DrawString("Many Bothans died to bring us this information.", 
                drawFont2, drawBrush, 40, 320);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 55);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 95);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 315);

            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 50);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 90);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 310);

            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 45);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 85);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 305);

            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 40);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 80);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 300);

            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 35);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 75);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 295);

            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 30);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 70);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 290);

            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 25);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 65);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 285);

            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 20);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 60);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 280);

            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 15);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 55);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 275);

            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 10);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 50);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 270);

            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 5);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 45);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 265);

            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, 0);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 40);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 260);

            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, -5);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 35);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 255);

            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, -10);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 30);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 250);

            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, -15);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 25);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 245);

            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, -20);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 20);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 240);

            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, -25);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 15);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 235);


            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("DEATH STAR ATTACK PLAN", drawFont, drawBrush2, 40, -30);
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 10);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 230);


            Thread.Sleep(100);
            Refresh();
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 5);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 225);


            Thread.Sleep(100);
            Refresh();
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, 0);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 220);

            Thread.Sleep(100);
            Refresh();
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, -5);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 215);

            Thread.Sleep(100);
            Refresh();
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, -10);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 210);


            Thread.Sleep(100);
            Refresh();
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, -15);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 205);


            Thread.Sleep(100);
            Refresh();
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, -20);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 200);

            Thread.Sleep(100);
            Refresh();
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, -25);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 195);

            Thread.Sleep(100);
            Refresh();
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, -30);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 190);

            Thread.Sleep(100);
            Refresh();
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, -35);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 185);


            Thread.Sleep(100);
            Refresh();
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, -40);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 180);


            Thread.Sleep(100);
            Refresh();
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, -45);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 175);

            Thread.Sleep(100);
            Refresh();
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, -50);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 170);

            Thread.Sleep(100);
            Refresh();
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, -55);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 165);

            Thread.Sleep(100);
            Refresh();
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, -60);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 160);
            Thread.Sleep (100);
            Refresh();

            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, -65);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 155);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, -70);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 150);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                drawFont1, drawBrush, 40, -75);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 145);
            Thread.Sleep(100);
            Refresh();
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                            drawFont1, drawBrush, 40, -80);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 140);
            Thread.Sleep(100);
            Refresh();
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                            drawFont1, drawBrush, 40, -85);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 135);
            Thread.Sleep(100);
            Refresh();
            formGraphics.DrawString("The Empire does not consider small snub fighter\n a threat against the Death Star. We will send \n X-wings down the trench run towards a weak spot \n we have discovered. A missile must be fired in \n through the small opening were it will follow a \n path reaching the control base resulting in the \n explosion of the death star...",
                            drawFont1, drawBrush, 40, -90);
            formGraphics.DrawString("Many Bothans died to bring us this information.",
                drawFont2, drawBrush, 40, 130);

            Thread.Sleep(400);
            Refresh();

            formGraphics.FillRectangle(drawBrush1, 0, 0, 500, 500);
            Pen drawPen = new Pen(Color.LimeGreen, 5);
            Pen drawPen2 = new Pen(Color.Red, 5);
            Pen drawPen3 = new Pen(Color.LimeGreen, 8);
            SolidBrush drawBrush3 = new SolidBrush(Color.Red);

            //Mission begins, X-wing begins to fly down

            SoundPlayer player2 = new SoundPlayer(Properties.Resources.airland);
            player2.Play();
            formGraphics.DrawLine(drawPen, 125, 340, 365, 340);
            formGraphics.DrawLine(drawPen, 125, 340, 125, 245);
            formGraphics.DrawLine(drawPen, 365, 248, 365, 343);
            formGraphics.DrawLine(drawPen, 238, 340, 238, 500);
            formGraphics.DrawLine(drawPen, 252, 340, 252, 500);
            formGraphics.DrawEllipse(drawPen, -60, 220, 600, 600);
            formGraphics.DrawPie(drawPen, 370, 170, 60, 60, -50, 45);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawLine(drawPen, 125, 340, 365, 340);
            formGraphics.DrawLine(drawPen, 125, 340, 125, 245);
            formGraphics.DrawLine(drawPen, 365, 248, 365, 343);
            formGraphics.DrawLine(drawPen, 238, 340, 238, 500);
            formGraphics.DrawLine(drawPen, 252, 340, 252, 500);
            formGraphics.DrawEllipse(drawPen, -60, 220, 600, 600);
            formGraphics.DrawPie(drawPen, 340, 180, 60, 60, -85, 45);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawLine(drawPen, 125, 340, 365, 340);
            formGraphics.DrawLine(drawPen, 125, 340, 125, 245);
            formGraphics.DrawLine(drawPen, 365, 248, 365, 343);
            formGraphics.DrawLine(drawPen, 238, 340, 238, 500);
            formGraphics.DrawLine(drawPen, 252, 340, 252, 500);
            formGraphics.DrawEllipse(drawPen, -60, 220, 600, 600);
            formGraphics.DrawPie(drawPen, 323, 210, 60, 60, -100, 45);

            

            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawLine(drawPen, 125, 340, 365, 340);
            formGraphics.DrawLine(drawPen, 125, 340, 125, 245);
            formGraphics.DrawLine(drawPen, 365, 248, 365, 343);
            formGraphics.DrawLine(drawPen, 238, 340, 238, 500);
            formGraphics.DrawLine(drawPen, 252, 340, 252, 500);
            formGraphics.DrawEllipse(drawPen, -60, 220, 600, 600);
            formGraphics.DrawPie(drawPen, 320, 220, 60, 60, -100, 45);

            Thread.Sleep(100);
            Refresh();
            formGraphics.DrawLine(drawPen, 125, 340, 365, 340);
            formGraphics.DrawLine(drawPen, 125, 340, 125, 245);
            formGraphics.DrawLine(drawPen, 365, 248, 365, 343);
            formGraphics.DrawLine(drawPen, 238, 340, 238, 500);
            formGraphics.DrawLine(drawPen, 252, 340, 252, 500);
            formGraphics.DrawEllipse(drawPen, -60, 220, 600, 600);
            formGraphics.DrawPie(drawPen, 318, 255, 60, 60, -85, 45);

            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawLine(drawPen, 125, 340, 365, 340);
            formGraphics.DrawLine(drawPen, 125, 340, 125, 245);
            formGraphics.DrawLine(drawPen, 365, 248, 365, 343);
            formGraphics.DrawLine(drawPen, 238, 340, 238, 500);
            formGraphics.DrawLine(drawPen, 252, 340, 252, 500);
            formGraphics.DrawEllipse(drawPen, -60, 220, 600, 600);
            formGraphics.DrawPie(drawPen, 300, 275, 60, 60, -45, 45);

            Thread.Sleep(100);
            Refresh();
           
            formGraphics.DrawLine(drawPen, 125, 340, 365, 340);
            formGraphics.DrawLine(drawPen, 125, 340, 125, 245);
            formGraphics.DrawLine(drawPen, 365, 248, 365, 343);
            formGraphics.DrawLine(drawPen, 238, 340, 238, 500);
            formGraphics.DrawLine(drawPen, 252, 340, 252, 500);
            formGraphics.DrawEllipse(drawPen, -60, 220, 600, 600);
            formGraphics.DrawPie(drawPen, 280, 280, 60, 60, -25, 45);

            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawEllipse(drawPen, -60, 220, 600, 600);
            formGraphics.DrawLine(drawPen, 125, 340, 365, 340);
            formGraphics.DrawLine(drawPen, 125, 340, 125, 245);
            formGraphics.DrawLine(drawPen, 365, 248, 365, 343);
            formGraphics.DrawLine(drawPen, 238, 340, 238, 500);
            formGraphics.DrawLine(drawPen, 252, 340, 252, 500);

            formGraphics.DrawPie(drawPen, 260, 280, 60, 60, -25, 45);

            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawEllipse(drawPen, -60, 220, 600, 600);
            formGraphics.DrawLine(drawPen, 125, 340, 365, 340);
            formGraphics.DrawLine(drawPen, 125, 340, 125, 245);
            formGraphics.DrawLine(drawPen, 365, 248, 365, 343);
            formGraphics.DrawLine(drawPen, 238, 340, 238, 500);
            formGraphics.DrawLine(drawPen, 252, 340, 252, 500);

            formGraphics.DrawPie(drawPen, 240, 280, 60, 60, -25, 45);

            Thread.Sleep(100);
            Refresh();
            
            //Bullet is fired 
            SoundPlayer player = new SoundPlayer(Properties.Resources.Gun);
            player.Play();
            formGraphics.DrawEllipse(drawPen, -60, 220, 600, 600);
            formGraphics.DrawLine(drawPen, 125, 340, 365, 340);
            formGraphics.DrawLine(drawPen, 125, 340, 125, 245);
            formGraphics.DrawLine(drawPen, 365, 248, 365, 343);
            formGraphics.DrawLine(drawPen, 238, 340, 238, 500);
            formGraphics.DrawLine(drawPen, 252, 340, 252, 500);

            formGraphics.DrawPie(drawPen, 220, 280, 60, 60, -25, 45);
            formGraphics.DrawEllipse(drawPen2, 259, 316, 10, 10);

            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawEllipse(drawPen, -60, 220, 600, 600);
            formGraphics.DrawLine(drawPen, 125, 340, 365, 340);
            formGraphics.DrawLine(drawPen, 125, 340, 125, 245);
            formGraphics.DrawLine(drawPen, 365, 248, 365, 343);
            formGraphics.DrawLine(drawPen, 238, 340, 238, 500);
            formGraphics.DrawLine(drawPen, 252, 340, 252, 500);

            formGraphics.DrawPie(drawPen, 180, 280, 60, 60, -25, 45);

            formGraphics.DrawEllipse(drawPen2, 242, 330, 10, 10);

            //NEW
            
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawEllipse(drawPen, -35, 200, 550, 550);
            formGraphics.DrawLine(drawPen, 135, 310, 355, 310);
            formGraphics.DrawLine(drawPen, 135, 310, 135, 225);
            formGraphics.DrawLine(drawPen, 355, 228, 355, 310);
            formGraphics.DrawLine(drawPen, 238, 310, 238, 500);
            formGraphics.DrawLine(drawPen, 252, 310, 252, 500);

            formGraphics.DrawPie(drawPen, 174, 227, 50,50, -6, 45);
            formGraphics.DrawEllipse(drawPen2, 242, 330, 7, 7);

            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawEllipse(drawPen, -10, 180, 500, 500);
            formGraphics.DrawLine(drawPen, 145, 280, 345, 280);
            formGraphics.DrawLine(drawPen, 145, 280, 145, 208);
            formGraphics.DrawLine(drawPen, 345, 211, 345, 280);
            formGraphics.DrawLine(drawPen, 238, 280, 238, 500);
            formGraphics.DrawLine(drawPen, 252, 280, 252, 500);

            formGraphics.DrawPie(drawPen, 170, 218, 40, 40, 0, 45);
            formGraphics.DrawEllipse(drawPen2, 242, 330, 7, 7);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawEllipse(drawPen, 15, 180, 450, 450);

            formGraphics.DrawLine(drawPen, 165, 250, 325, 250);
            formGraphics.DrawLine(drawPen, 165, 250, 165, 190);
            formGraphics.DrawLine(drawPen, 325, 195, 325, 250);
            formGraphics.DrawLine(drawPen, 238, 250, 238, 500);
            formGraphics.DrawLine(drawPen, 252, 250, 252, 500);
            formGraphics.DrawEllipse(drawPen2, 242, 330, 7, 7);

            formGraphics.DrawPie(drawPen, 167, 175, 40, 40, 6, 45);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawEllipse(drawPen, 40, 140, 400, 400);

            formGraphics.DrawLine(drawPen, 185, 200, 305, 200);
            formGraphics.DrawLine(drawPen, 185, 202, 185, 150);
            formGraphics.DrawLine(drawPen, 305, 155, 305, 202);
            formGraphics.DrawLine(drawPen, 238, 200, 238, 320);
            formGraphics.DrawLine(drawPen, 252, 200, 252, 320);

            formGraphics.DrawPie(drawPen, 169, 120, 30, 30, 10, 45);
            formGraphics.DrawEllipse(drawPen, 228, 317, 33, 33);
            formGraphics.DrawEllipse(drawPen2, 242, 310, 7, 7);

            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawEllipse(drawPen, 65, 120, 350, 350);

            formGraphics.DrawLine(drawPen, 195, 175, 295, 175);
            formGraphics.DrawLine(drawPen, 195, 178, 195, 130);
            formGraphics.DrawLine(drawPen, 295, 135, 295, 178);
            formGraphics.DrawLine(drawPen, 238, 175, 238, 320);
            formGraphics.DrawLine(drawPen, 252, 175, 252, 320);

            formGraphics.DrawEllipse(drawPen, 229, 319, 35, 35);
            formGraphics.DrawEllipse(drawPen2, 243, 323, 7, 7);

            formGraphics.DrawPie(drawPen, 169, 80, 30, 30, 13, 45);
            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawEllipse(drawPen, 90, 100, 300, 300);

            formGraphics.DrawLine(drawPen, 205, 145, 285, 145);
            formGraphics.DrawLine(drawPen, 205, 148, 205, 106);
            formGraphics.DrawLine(drawPen, 285, 110, 285, 148);
            formGraphics.DrawLine(drawPen, 238, 145, 238, 240);
            formGraphics.DrawLine(drawPen, 252, 145, 252, 240);

            formGraphics.DrawEllipse(drawPen2, 242, 248, 5, 5);

            formGraphics.DrawEllipse(drawPen, 232, 239, 25, 25);
            formGraphics.DrawPie(drawPen, 169, 50, 20, 20, 10, 45);

            Thread.Sleep(100);
            Refresh();

            formGraphics.DrawEllipse(drawPen, 90, 100, 300, 300);

            formGraphics.DrawLine(drawPen, 205, 145, 285, 145);
            formGraphics.DrawLine(drawPen, 205, 148, 205, 106);
            formGraphics.DrawLine(drawPen, 285, 110, 285, 148);
            formGraphics.DrawLine(drawPen, 238, 145, 238, 240);
            formGraphics.DrawLine(drawPen, 252, 145, 252, 240);
            formGraphics.DrawEllipse(drawPen, 232, 239, 25, 25);
            formGraphics.DrawPie(drawPen, 155, 20, 20, 20, 10, 45);

            formGraphics.DrawEllipse(drawPen2, 237, 244, 15, 15);

            Thread.Sleep(100);
            Refresh();
           
            //Explosion begins
            SoundPlayer player7 = new SoundPlayer(Properties.Resources.Bomb);
            player7.Play();

            formGraphics.FillPie(drawBrush3, 160, 154, 200, 200, 0, 15);
            formGraphics.FillPie(drawBrush3, 145, 159, 200, 200, 60, 15);
            formGraphics.FillPie(drawBrush3, 140, 159, 200, 200, 120, 15);
            formGraphics.FillPie(drawBrush3, 135, 150, 200, 200, 180, 15);
            formGraphics.FillPie(drawBrush3, 140, 146, 200, 200, 240, 15);
            formGraphics.FillPie(drawBrush3, 152, 145, 200, 200, 300, 15);

            formGraphics.DrawEllipse(drawPen, 90, 100, 300, 300);

            formGraphics.DrawLine(drawPen, 205, 145, 285, 145);
            formGraphics.DrawLine(drawPen, 205, 148, 205, 106);
            formGraphics.DrawLine(drawPen, 285, 110, 285, 148);
            formGraphics.DrawLine(drawPen, 238, 145, 238, 240);
            formGraphics.DrawLine(drawPen, 252, 145, 252, 240);
            formGraphics.DrawEllipse(drawPen, 232, 239, 25, 25);
            formGraphics.DrawPie(drawPen, 140, 5, 20, 20, 10, 45);
            formGraphics.DrawEllipse(drawPen2, 237, 244, 15, 15);

            Thread.Sleep(300);
            Refresh();


            formGraphics.DrawEllipse(drawPen, 90, 100, 300, 300);

            formGraphics.DrawLine(drawPen, 205, 145, 285, 145);
            formGraphics.DrawLine(drawPen, 205, 148, 205, 106);
            formGraphics.DrawLine(drawPen, 285, 110, 285, 148);
            formGraphics.DrawLine(drawPen, 238, 145, 238, 240);
            formGraphics.DrawLine(drawPen, 252, 145, 252, 240);
            formGraphics.DrawEllipse(drawPen, 232, 239, 25, 25);
            formGraphics.DrawPie(drawPen, 130, -7, 20, 20, 10, 45);
            formGraphics.DrawEllipse(drawPen2, 237, 244, 15, 15);

            Thread.Sleep(200);
            Refresh();
            
            player7.Play();

            formGraphics.FillPie(drawBrush3, 160, 154, 200, 200, 0, 15);
            formGraphics.FillPie(drawBrush3, 145, 159, 200, 200, 60, 15);
            formGraphics.FillPie(drawBrush3, 140, 159, 200, 200, 120, 15);
            formGraphics.FillPie(drawBrush3, 135, 150, 200, 200, 180, 15);
            formGraphics.FillPie(drawBrush3, 140, 146, 200, 200, 240, 15);
            formGraphics.FillPie(drawBrush3, 152, 145, 200, 200, 300, 15);

            formGraphics.DrawEllipse(drawPen, 90, 100, 300, 300);

            formGraphics.DrawLine(drawPen, 205, 145, 285, 145);
            formGraphics.DrawLine(drawPen, 205, 148, 205, 106);
            formGraphics.DrawLine(drawPen, 285, 110, 285, 148);
            formGraphics.DrawLine(drawPen, 238, 145, 238, 240);
            formGraphics.DrawLine(drawPen, 252, 145, 252, 240);
            formGraphics.DrawEllipse(drawPen, 232, 239, 25, 25);
            formGraphics.DrawEllipse(drawPen2, 237, 244, 15, 15);
            
            Thread.Sleep(300);
            Refresh();

        
            formGraphics.DrawEllipse(drawPen, 90, 100, 300, 300);

            formGraphics.DrawLine(drawPen, 205, 145, 285, 145);
            formGraphics.DrawLine(drawPen, 205, 148, 205, 106);
            formGraphics.DrawLine(drawPen, 285, 110, 285, 148);
            formGraphics.DrawLine(drawPen, 238, 145, 238, 240);
            formGraphics.DrawLine(drawPen, 252, 145, 252, 240);
            formGraphics.DrawEllipse(drawPen, 232, 239, 25, 25);
            formGraphics.DrawEllipse(drawPen2, 237, 244, 15, 15);
            
            Thread.Sleep(200);
            Refresh();
            
            player7.Play();

            formGraphics.FillPie(drawBrush3, 160, 154, 200, 200, 0, 15);
            formGraphics.FillPie(drawBrush3, 145, 159, 200, 200, 60, 15);
            formGraphics.FillPie(drawBrush3, 140, 159, 200, 200, 120, 15);
            formGraphics.FillPie(drawBrush3, 135, 150, 200, 200, 180, 15);
            formGraphics.FillPie(drawBrush3, 140, 146, 200, 200, 240, 15);
            formGraphics.FillPie(drawBrush3, 152, 145, 200, 200, 300, 15);

            formGraphics.DrawEllipse(drawPen, 90, 100, 300, 300);

            formGraphics.DrawLine(drawPen, 205, 145, 285, 145);
            formGraphics.DrawLine(drawPen, 205, 148, 205, 106);
            formGraphics.DrawLine(drawPen, 285, 110, 285, 148);
            formGraphics.DrawLine(drawPen, 238, 145, 238, 240);
            formGraphics.DrawLine(drawPen, 252, 145, 252, 240);
            formGraphics.DrawEllipse(drawPen, 232, 239, 25, 25);
            formGraphics.DrawEllipse(drawPen2, 237, 244, 15, 15);

            Thread.Sleep(300);
            Refresh();


            formGraphics.DrawEllipse(drawPen, 90, 100, 300, 300);

            formGraphics.DrawLine(drawPen, 205, 145, 285, 145);
            formGraphics.DrawLine(drawPen, 205, 148, 205, 106);
            formGraphics.DrawLine(drawPen, 285, 110, 285, 148);
            formGraphics.DrawLine(drawPen, 238, 145, 238, 240);
            formGraphics.DrawLine(drawPen, 252, 145, 252, 240);
            formGraphics.DrawEllipse(drawPen, 232, 239, 25, 25);
            formGraphics.DrawEllipse(drawPen2, 237, 244, 15, 15);

            Thread.Sleep(200);
            Refresh();

            player7.Play();
            formGraphics.FillPie(drawBrush3, 160, 154, 200, 200, 0, 15);
            formGraphics.FillPie(drawBrush3, 145, 159, 200, 200, 60, 15);
            formGraphics.FillPie(drawBrush3, 140, 159, 200, 200, 120, 15);
            formGraphics.FillPie(drawBrush3, 135, 150, 200, 200, 180, 15);
            formGraphics.FillPie(drawBrush3, 140, 146, 200, 200, 240, 15);
            formGraphics.FillPie(drawBrush3, 152, 145, 200, 200, 300, 15);

            formGraphics.DrawEllipse(drawPen, 90, 100, 300, 300);

            formGraphics.DrawLine(drawPen, 205, 145, 285, 145);
            formGraphics.DrawLine(drawPen, 205, 148, 205, 106);
            formGraphics.DrawLine(drawPen, 285, 110, 285, 148);
            formGraphics.DrawLine(drawPen, 238, 145, 238, 240);
            formGraphics.DrawLine(drawPen, 252, 145, 252, 240);
            formGraphics.DrawEllipse(drawPen, 232, 239, 25, 25);
            formGraphics.DrawEllipse(drawPen2, 237, 244, 15, 15);

            Thread.Sleep(300);
            Refresh();

            formGraphics.DrawEllipse(drawPen, 90, 100, 300, 300);

            formGraphics.DrawLine(drawPen, 205, 145, 285, 145);
            formGraphics.DrawLine(drawPen, 205, 148, 205, 106);
            formGraphics.DrawLine(drawPen, 285, 110, 285, 148);
            formGraphics.DrawLine(drawPen, 238, 145, 238, 240);
            formGraphics.DrawLine(drawPen, 252, 145, 252, 240);
            formGraphics.DrawEllipse(drawPen, 232, 239, 25, 25);
            formGraphics.DrawEllipse(drawPen2, 237, 244, 15, 15);

            Thread.Sleep(200);
            Refresh();

            //Medium Explosion Occurs
            player7.Play();

            formGraphics.DrawEllipse(drawPen, 90, 100, 300, 300);
            formGraphics.FillEllipse(drawBrush3, 145, 150, 200, 200);
            formGraphics.DrawLine(drawPen, 205, 145, 285, 145);
            formGraphics.DrawLine(drawPen, 205, 148, 205, 106);
            formGraphics.DrawLine(drawPen, 285, 110, 285, 148);
            formGraphics.DrawLine(drawPen, 238, 145, 238, 240);
            formGraphics.DrawLine(drawPen, 252, 145, 252, 240);
            formGraphics.DrawEllipse(drawPen, 232, 239, 25, 25);
            formGraphics.DrawEllipse(drawPen2, 237, 244, 15, 15);


            Thread.Sleep(600);
            Refresh();

            //Big Explision Occurs
            SoundPlayer player6 = new SoundPlayer(Properties.Resources.Big);
            player6.Play();

            formGraphics.DrawEllipse(drawPen, 90, 100, 300, 300);
           
            formGraphics.DrawLine(drawPen, 205, 145, 285, 145);
            formGraphics.DrawLine(drawPen, 205, 148, 205, 106);
            formGraphics.DrawLine(drawPen, 285, 110, 285, 148);
            formGraphics.DrawLine(drawPen, 238, 145, 238, 240);
            formGraphics.DrawLine(drawPen, 252, 145, 252, 240);
            formGraphics.DrawEllipse(drawPen, 232, 239, 25, 25);
            formGraphics.DrawEllipse(drawPen2, 237, 244, 15, 15);
            formGraphics.FillEllipse(drawBrush3, 90, 100, 300, 300);
        }
    }
    }

