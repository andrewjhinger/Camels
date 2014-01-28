using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Camels
{
    public partial class Camels : Form
    {
        private Hump _hump = new Hump();

        public Camels()
        {
            InitializeComponent();
        }

        private void addWaterButton_Click(object sender, EventArgs e)
        {
            _hump.addWater(Int32.Parse(waterAmountNumericUpDown.Value.ToString()));
            updateWaterDisplay();
        }

        private void removeWaterButton_Click(object sender, EventArgs e)
        {
            _hump.removeWater(Int32.Parse(waterAmountNumericUpDown.Value.ToString()));
            updateWaterDisplay();
        }

        private void updateWaterDisplay()
        {
            waterAmountLabel.Text = _hump.GallonsOfWater.ToString();
            waterAmountProgressBar.Value = _hump.GallonsOfWater;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Camels_Load(object sender, EventArgs e)
        {
            waterAmountProgressBar.Minimum = 0;
            waterAmountProgressBar.Maximum = _hump.MaximumGallonsOfWater;
        }

        private void testChangeInteger(ref int value)
        {
            value += 10;
        }

        private void Camels_Shown(object sender, EventArgs e)
        {
            int changeInteger = 0;

            testChangeInteger(ref changeInteger);
            MessageBox.Show("changeInteger value: " + changeInteger);
        }
    }

    internal class Hump
    {
        private int _gallonsOfWater;
        private const int _maximumGallonsOfWater = 100;

        internal Hump()
        {
            _gallonsOfWater = 0;
        }

        internal int GallonsOfWater
        {
            get { return _gallonsOfWater; }
        }

        internal int MaximumGallonsOfWater
        {
            get { return _maximumGallonsOfWater; }
        }

        internal void addWater(int gallonsToAdd)
        {
            _gallonsOfWater += gallonsToAdd;
            if (_gallonsOfWater > _maximumGallonsOfWater)
                _gallonsOfWater = _maximumGallonsOfWater;
        }

        internal void removeWater(int gallonsToRemove)
        {
            _gallonsOfWater -= gallonsToRemove;
            if (_gallonsOfWater < 0)
                _gallonsOfWater = 0;
        }
    }
}
