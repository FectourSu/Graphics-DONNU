﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.GraphicExtantion.UserControls
{
    class UserControls
    {
        //one page
        public DrawShapesControl DrawShape { get; set; }
        public DrawCoordinateControl DrawCordinate { get; set; }
        public DrawTextControl DrawText { get; set; }
        public DrawGraphicsTemperatures DrawGraphics { get; set; }
        public DrawStatistics DrawStatistic { get; set; }
        public DrawStaticImage DrawImage { get; set; }
        public DrawGame DrawGame { get => new DrawGame(); }
        public DrawAnimateImage DrawAnimate { get; set; }
        public DrawPlayGame DrawPlay { get; set; }

        //two page
        public DrawRotate DrawRotate { get; set; }

        public DrawClippingLines DrawClippingLines { get; set; }

    }
}
