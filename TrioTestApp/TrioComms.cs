using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrioPCLib;


namespace TrioTestApp
{
    public class TrioComms
    {

        private TrioPC _motionController;
        private int _etherCATNode;
        private short _axisID;

        /// <summary>
        /// Constructor for Trio hardware
        /// </summary>
        /// <param name="motionController">The motion controller.</param>
        /// <param name="etherCATNode">The ether cat node.</param>
        public TrioComms(int etherCATNode)
        {
            _motionController = new TrioPC();
            _etherCATNode = etherCATNode;
            _axisID = (short)_etherCATNode;
        }

        public bool Connect()
        {
            return _motionController.Open(1, 1);
        }

}
}
