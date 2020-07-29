using System;
using Wapiti.API.V1.Common.Enumerations;

namespace Wapiti.API.V1.CoinDoors
{
    public class CoinDoor
    {
        /// <summary>
        /// Id for the saved coin door profile
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Friendly human readable name for the coin door.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Cost of a credit. $0.00 when status is freeplay.
        /// </summary>
        public Decimal CreditCost { get; set; }

        /// <summary>
        /// Optional: Where the game is located.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Status of the door. Default is Freeplay.
        /// </summary>
        public DoorStatus Status { get; set; }
    }
}
