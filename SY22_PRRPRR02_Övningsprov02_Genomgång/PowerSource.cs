using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_Övningsprov02_Genomgång {
	internal class PowerSource {
		private double _voltage; // 0,5p

		public double DrawPower(double power, double duration) {
			double product = power * duration;
			return product;
		} // 1p

		public PowerSource(double inputVoltage) {
			_voltage = inputVoltage;
		} // 0,5p
	}
}
