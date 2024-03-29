﻿using System;

namespace Task_DEV_6
{
    /// <summary>
    /// class for command average price type
    /// </summary>
    class AveragePriceTypeCommand : ICommand
    {
        PriceListCars PriceList { get; set; }
        string Mark { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="priceList"></param>
        /// <param name="mark"></param>
        public AveragePriceTypeCommand(PriceListCars priceList, string mark)
        {
            this.PriceList = priceList;
            this.Mark = mark;
        }

        /// <summary>
        /// method for call command average price type
        /// </summary>
        public void Execute() => Console.WriteLine(this.PriceList?.GetEveragePriceMark(this.Mark));
    }
}
