﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProcessingTechnologyCalc
{
    public class Tool
    {
        public double Diameter;
        public double Thickness;
    }

    public class ProcessOptions 
    {
        public static int ZSafety = 20;
        public static int VertAxisDist = 16;
        public static int AxisDist = 200;
        public static int Thickness = 30;

        public int MaterialType;
        public int GreatSpeed;
        public int SmallSpeed;
        public int Frequency;
        public int DepthAll;
        public int Depth;

        public List<Tool> ToolsList;
        public int ToolNo;

        public enum TTypeMachine { Denver, Ravelli };
        public static TTypeMachine Machine = ProcessOptions.TTypeMachine.Ravelli;

        public ProcessOptions()
        {
            this.MaterialType = 0;
            this.GreatSpeed = 1500;
            this.SmallSpeed = 250;
            this.Frequency = 2500;
            this.DepthAll = 32;
            this.Depth = 16;
            this.ToolNo = 1;
            this.ToolsList = new List<Tool>();
            //this.Machine = TTypeMachine.Denver;
        }
        public ProcessOptions(ProcessOptions processOptions)
        {
            this.MaterialType = processOptions.MaterialType;
            this.GreatSpeed   = processOptions.GreatSpeed;
            this.SmallSpeed   = processOptions.SmallSpeed;
            this.Frequency    = processOptions.Frequency;
            this.DepthAll     = processOptions.DepthAll;
            this.Depth        = processOptions.Depth;
            this.ToolNo       = processOptions.ToolNo;
            this.ToolsList    = processOptions.ToolsList;
            //this.Machine = processOptions.Machine;
        }
    }
}
