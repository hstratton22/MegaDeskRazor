﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace RazorMegaDesk.Models
{
    public class Deskquote
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Display(Name = "Name")]
        public string CustomerName { get; set; }
        [Range(24, 96)]
        [Required]
        public int Width { get; set; }
        [Range(12, 48)]
        [Required]
        public int Depth { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        public DateTime QuoteDate { get; set; }
        public int Area
        {
            //get { return _width * _depth; }
            get { return Width * Depth; }
        }
        [Range(0, 7)]
        
        [Required]
        [Display(Name = "Drawer Count")]
        public int DrawerCount { get; set; }

        [Required]
        [Display(Name = "Desktop Material"), EnumDataType(typeof(DesktopMaterial))]
        public DesktopMaterial DesktopMaterial { get; set; }

        [Display(Name = "Rush Shipping")]
        public int RushDays { get; set; }

        [Display(Name = "Total Cost")]
        public int Cost
        {
            get
            {
                return AreaTotalCost() + CalcDrawerCost() + CalcRushCost() + CalcSurfaceCost();
            }
        }


        public Deskquote()
        {
            QuoteDate = DateTime.Today;
        }

        private int _rush;
        private int[,] rushShipping;
        private const int BaseCost = 200;
        private const int PerDrawer = 50;
        private const int OversizeSurface = 1;
        private const int OversizeLowNum = 1000;
        private const int OversizeHighNum = 2000;
        


        /// <summary>
        /// w * d of Desk, and calculates cost
        /// </summary>
        /// <returns></returns>
        public int AreaTotalCost()
        {
            int oversizedArea = 0;
            if (Area > OversizeLowNum)
            {
                oversizedArea = Area - OversizeLowNum;
            }
            return BaseCost + (OversizeSurface * oversizedArea);

        }
        /// <summary>
        /// calculates total cost of drawers
        /// </summary>
        /// <returns></returns>
        public int CalcDrawerCost()
        {
            return PerDrawer * DrawerCount;
        }
        /// <summary>
        /// calculates total cost of rush order 
        /// </summary>
        /// <returns></returns>
        public int CalcRushCost()
        {
            int result = 0;
            _rush = RushDays;
            GetRushOrder();
            int speed;
            int weight;
            switch (_rush)
            {
                case 3:
                    speed = 0;
                    break;
                case 5:
                    speed = 1;
                    break;
                case 7:
                    speed = 2;
                    break;
                default:
                    result = 0;
                    return result;
            }

            if (Area < OversizeLowNum) weight = 0;
            else if (Area > OversizeLowNum && Area < OversizeHighNum) weight = 1;
            else weight = 2;


            result = rushShipping[speed, weight];
            return result;
        }
        /// <summary>
        /// calculates surface cost using enum DesktopMaterial
        /// </summary> 
        /// <returns></returns>
        public int CalcSurfaceCost()
        {
            if (DesktopMaterial == DesktopMaterial.Laminate)
            {
                return 100;
            }

            if (DesktopMaterial == DesktopMaterial.Oak)
            {
                return 200;
            }

            if (DesktopMaterial == DesktopMaterial.Pine)
            {
                return 50;
            }

            if (DesktopMaterial == DesktopMaterial.Rosewood)
            {
                return 300;
            }

            if (DesktopMaterial == DesktopMaterial.Veneer)
            {
                return 125;
            }

            return 50;

        }
        /// <summary>
        /// override ToString() including custName for reference
        /// </summary>
        /// <returns></returns>

        public override string ToString()
        {
            return base.ToString() + "\n" +
               "name:" + CustomerName;
        }

        /// <summary>
        /// Opens and Reads the rushorder Price file, then returns it as a 2d Array
        /// </summary>
        /// <returns></returns>
        
        public int[,] GetRushOrder()
        {
            try
            {
                string[] vs = File.ReadAllLines(@"Resources\rushOrderPrices.txt");
                int[] rushPrices = Array.ConvertAll(vs, item => int.Parse(item));
                rushShipping = new int[3, 3];
                int index = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        rushShipping[i, j] = rushPrices[index];
                        index++;
                    }
                }

            }
            catch (FileNotFoundException e)
            {
                //change catch to something more appropriate
                //MessageBox.Show(@"File Could Not be Found" + e);

            }

            return rushShipping;
        }



    }
    public enum DesktopMaterial
    {
        Laminate, Oak, Pine, Rosewood, Veneer
    }
}
