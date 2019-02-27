using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Numerics;

namespace FractalApp
{
    public partial class Form1 : Form
    {

        private const int NO_COLOURING = 0, ITERATIONS = 1, MODULUS = 2, BINARY_DECOMPOSITION = 3, ORBIT_TRAP = 4;

        private const int JULIA_SET = 0, NEWTON_METHOD_FRACTAL = 1;

        private static int colouringMethod = NO_COLOURING;
        private static int chooseFractalMethod = -1;
        private static double maxModulus = 2.0d;

        private Bitmap mandelbrotSetBitmap = new Bitmap(800, 600); //The size of the bitmap is set initially to 800x600.



        private static int RandomColor()
        {
            Random rand = new Random();
            return rand.Next(255);
        }
        public Form1()
        {
            InitializeComponent();

            //Add items to the object 'colouringMethodComboBox.'
            colouringMethodComboBox.Text = "None";
            colouringMethodComboBox.Items.Add("None");
            colouringMethodComboBox.Items.Add("Iterations Method");
            colouringMethodComboBox.Items.Add("Modulus Method");
            colouringMethodComboBox.Items.Add("Binary Decomposition");
            colouringMethodComboBox.Items.Add("Orbit Trap");

            chooseFractalComboBox.Items.Add("Julia Set");
            chooseFractalComboBox.Items.Add("Newton Fractal");


        }


        private void SampleJs_Click(object sender, EventArgs e)
        {
            RealUpDown.Value = (decimal)-0.7;
            ImaginaryUpDown.Value = (decimal)0.2701;
            Graphics mandelbrotSetImage = Graphics.FromImage(mandelbrotSetBitmap);


            mandelbrotSetImage.Clear(mandelbrotSetPictureBox.BackColor);
            mandelbrotSetPictureBox.Refresh();

            Julia_Set_Generate();

            //Display the Mandelbrot set by firing the 'Paint' event on 'mandelbrotSetPictureBox.'
            mandelbrotSetPictureBox.Refresh();
        }
        private void Generate_Newton_Click(object sender, EventArgs e)
        {
            coefficient.Value = 1;
            fxDegree.Value =3;
            AddorSubtract.Value = -1;

            Graphics mandelbrotSetImage = Graphics.FromImage(mandelbrotSetBitmap);


            mandelbrotSetImage.Clear(mandelbrotSetPictureBox.BackColor);
            mandelbrotSetPictureBox.Refresh();

            Newton_Fractal_Generate();

            //Display the Mandelbrot set by firing the 'Paint' event on 'mandelbrotSetPictureBox.'
            mandelbrotSetPictureBox.Refresh();
        }

        private void displayMandelbrotSetButton_Click(object sender, EventArgs e)
        {

            Graphics mandelbrotSetImage = Graphics.FromImage(mandelbrotSetBitmap);



            mandelbrotSetImage.Clear(mandelbrotSetPictureBox.BackColor);
            mandelbrotSetPictureBox.Refresh();

            chooseFractalMethod = chooseFractalComboBox.SelectedIndex;

            if (chooseFractalMethod == 0)
            {
                Julia_Set_Generate();
            }
            else if (chooseFractalMethod == 1)
            {
                Newton_Fractal_Generate();
            }
            //Display the Mandelbrot set by firing the 'Paint' event on 'mandelbrotSetPictureBox.'
            mandelbrotSetPictureBox.Refresh();
        }


        private void mandelbrotSetPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(mandelbrotSetBitmap, 0, 0);
        }



        private void colouringMethodComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            colouringMethod = colouringMethodComboBox.SelectedIndex;
        }


        /*
         * OTHER METHODS FOR INTERNAL USE ONLY
         */

        private static Color pixelColour(int colourMethod, int repetitions, Complex c, double distance)
        {
            double modulus = Complex.Abs(c);



            if (colourMethod == ITERATIONS)
            {
                if (modulus >= 2.0d)
                {
                    int red = (int)(2.55f * repetitions);
                    int green = red;
                    int blue = (int)(255 - 2.55f * repetitions);
                    return Color.FromArgb(red, green, blue);
                }
                else
                    return Color.Black;
            }
            else if (colourMethod == MODULUS)
            {
                if (modulus >= 2.0d)
                {
                    int red = (int)Math.Round(-23.3d * modulus + 277.0d);
                    int green = (int)Math.Round(10.0d * Math.Pow(modulus, 2) - 136.0d * modulus + 465.0d);
                    int blue = (int)Math.Round(25.3d * modulus - 50.0d);
                    return Color.FromArgb(red, green, blue);
                }
                else
                    return Color.Black;

            }
            else if (colourMethod == BINARY_DECOMPOSITION)
            {
                if (repetitions == 100)
                {
                    return Color.Red;
                }
                else
                {
                    if (c.Imaginary < 0)
                        return Color.Blue;
                    else
                        return Color.White;
                }
            }
            else if (colourMethod == ORBIT_TRAP)
            {
                if (distance < 0.05)
                {
                    return Color.Yellow;
                }
                else if (distance > 0.05 && distance < 0.1)
                {
                    return Color.Cyan;
                }
                else if (distance > 0.1 && distance < 0.5)
                {
                    return Color.Fuchsia;
                }
                else if(distance >0.5 && distance < 0.8)
                {
                    return Color.LightSalmon;
                }
                else
                {
                    return Color.Blue;
                }
            }

            else
                return Color.White;
        }


        //Recursive Algorithm for Generation of Julia Set
        private Complex JuliaSetRecursive(Complex z, int iterations, Complex c)
        {
            if (Complex.Abs(z) < 2 && iterations < 100)
            {
                Complex Power = (Complex)ExponentUpDown.Value;
                z = Complex.Add(Complex.Pow(z, Power), c);//z=z^2+c
                return JuliaSetRecursive(z, iterations + 1, c);
            }
            else
            {
                return z;
            }
        }



        private Complex Newton_Fractal_Recursive(Complex z, int iterations)
        {
            Complex functionRatio = new Complex(0, 0);
            double Coefficient = (double)coefficient.Value;
            double Degree = (double)fxDegree.Value;
            double add_subtract = (double)AddorSubtract.Value;
            if (Complex.Abs(z)>0.3d && iterations < 100)
            {
                Complex fx = Complex.Add(Complex.Multiply(Coefficient, (Complex.Pow(z, Degree))), add_subtract);
                Complex dfx = Complex.Multiply(Degree, Complex.Pow(z, Degree - 1));
                Complex.Divide(z, 2);
                functionRatio = Complex.Divide(fx, dfx);
                z = Complex.Subtract(z, functionRatio);
                return Newton_Fractal_Recursive(z, iterations + 1);
            }
            else
            {
                return z;
            }

        }


        //Algorithm used for the Orbit Colouring method in which an arbitrary point is chosen
        private double distanceForOrbit(Complex z)
        {
            double distance = 10e5;
            Complex zMinusPoint = z;
            zMinusPoint = Complex.Subtract(z, 0);

            double zMinusPointModulus = zMinusPoint.Magnitude;
            if (zMinusPointModulus < distance)
                distance = zMinusPointModulus;
            return distance;
        }




        private void Julia_Set_Generate()
        {

            Random randomGen = new Random();
            KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            KnownColor randomColorName = names[randomGen.Next(names.Length)];
            KnownColor randomColorName1 = names[randomGen.Next(names.Length)];

            //For efficiency reasons, copy the 'Width' and 'Height' properties to variables.
            //This is called "caching" the values of properties.
            int width = mandelbrotSetBitmap.Width;
            int height = mandelbrotSetBitmap.Height;

            double RealValue = (double)RealUpDown.Value;
            double imaginaryValue = (double)ImaginaryUpDown.Value;

            //Initiate intial C value to run Julia set
            Complex c = new Complex(RealValue, imaginaryValue);
            Complex z = new Complex(0, 0);
            //Traverse the bitmap one pixel at a time, column by column. Screen co-ordinates are (x,y).
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    //The real and imaginary parts of the 'c' are determined by the linear transformations that map
                    //the region of the Cartesian plane in which 0<=x<800, 0<=y<600 to the region of the Complex plane
                    //in which -2.5<=Re(z)<1.5 and -1.5<=Im(z)<1.5
                    int iterations = 0;
                    z = new Complex(4.0d / width * x - 2.5d, -3.0d / height * y + 1.5d);
                    z = JuliaSetRecursive(z, iterations, c);

                    if (colouringMethod == 0)
                    {
                        double mod = Complex.Abs(z);
                        if (mod < 2.0d)
                        {
                            Color randomColor = Color.FromKnownColor(randomColorName);
                            mandelbrotSetBitmap.SetPixel(x, y, randomColor);
                        }
                        else
                        {
                            Color randomColor1 = Color.FromKnownColor(randomColorName1);
                            mandelbrotSetBitmap.SetPixel(x, y, randomColor1);
                        }
                    }
                    else
                    {
                        mandelbrotSetBitmap.SetPixel(x, y, pixelColour(colouringMethod, iterations - 1, z, distanceForOrbit(z)));
                    }

                }//end inner for
            }//end outer for
        }

        private void Newton_Fractal_Generate()
        {

            //Instantiations of the 'Complex' class. Create two complex objects, 'c' and 'z.'
            //For both 'Complex' objects, the real and imaginary parts are initially set to 0.
            Complex z = new Complex(0, 0);

            Random randomGen = new Random();
            KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            KnownColor randomColorName = names[randomGen.Next(names.Length)];
            KnownColor randomColorName1 = names[randomGen.Next(names.Length)];


            //For efficiency reasons, copy the 'Width' and 'Height' properties to variables.
            //This is called "caching" the values of properties.
            int width = mandelbrotSetBitmap.Width;
            int height = mandelbrotSetBitmap.Height;


            //Traverse the bitmap one pixel at a time, column by column. Screen co-ordinates are (x,y).
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    //The real and imaginary parts of the 'z' are determined by the linear transformations that map
                    //the region of the Cartesian plane in which 0<=x<800, 0<=y<600 to the region of the Complex plane
                    //in which -2.5<=Re(z)<1.5 and -1.5<=Im(z)<1.5
                    z = new Complex(4.0d / width * x - 2.5d, -3.0d / height * y + 1.5d);
                    int iterations = 0;
                    z = Newton_Fractal_Recursive(z, iterations);

                    if (colouringMethod == 0)
                    {
                        double mod = Complex.Abs(z);
                        if (mod < 0.4d)
                        {
                            Color randomColor = Color.FromKnownColor(randomColorName);
                            mandelbrotSetBitmap.SetPixel(x, y, randomColor);
                        }
                        else
                        {
                            Color randomColor1 = Color.FromKnownColor(randomColorName1);
                            mandelbrotSetBitmap.SetPixel(x, y, randomColor1);
                        }
                    }
                    else
                    {
                        mandelbrotSetBitmap.SetPixel(x, y, pixelColour(colouringMethod, iterations - 1, z, distanceForOrbit(z)));
                    }

                }//end inner for
            }//end outer for
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
