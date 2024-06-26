﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuggingDemo.Doodle
{
    public class DoodleEnum
    {
        public enum DoodleEnumType
        {
            eraser = 0,
            draw,
            line,
            rect,
            circle,
            arrow,
            cube,
            cylinder,
            cone
        };

        public enum DoodleEnumColor
        {
            black = 0,
            blue,
            red,
            green,
            orange,
            white,
            yellow
        };

        public enum DoodleEnumBrushType
        {
            small = 1,
            middle = 2,
            big = 4,
            bigger = 8
        };


        public enum ShapeSettingType
        {
            ShapeSettingType_Move = 1,
            ShapeSettingType_LeftTop = 2,
            ShapeSettingType_RightTop = 3,
            ShapeSettingType_LeftBottom = 4,
            ShapeSettingType_RightBottom = 5,
            ShapeSettingType_Rotate = 6
        };
    }
}
