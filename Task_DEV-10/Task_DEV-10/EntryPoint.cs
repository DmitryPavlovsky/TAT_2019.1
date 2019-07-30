﻿using System;

namespace Task_DEV_10
{
    /// <summary>
    /// Base class of program.
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// The entry point of program.
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
            try
            {
                var shop = new Shop();
                var requester = new RequestHandler(shop);
                requester.HandleRequests();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}
