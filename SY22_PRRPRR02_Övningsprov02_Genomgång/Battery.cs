using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_Övningsprov02_Genomgång {
	internal class Battery {
		protected double Capacity;
		protected double ChargeLevel;
		protected double Voltage;
		private double _maxCurrent;
		// 0,5p

		public double BatteryLevel {
			get {
				return ChargeLevel / Capacity * 100;
			}
		} // 1p

		public double Discharge(double power, double duration) { // 1p
			double current = power / Voltage; // 0,25p

			if (current > _maxCurrent) {
				current = _maxCurrent;
			} // 0,25p

			double usage = current * duration; // 0,25p

			if (usage > ChargeLevel) {
				usage = ChargeLevel;
			} // 0,25p

			ChargeLevel = ChargeLevel - usage; // 0,25p

			return usage * Voltage; // 0,25p
		}

		public Battery(double inputCapacity, double inputMaxCurrent, double inputVoltage) {
			Capacity = inputCapacity;
			_maxCurrent = inputMaxCurrent;
			Voltage = inputVoltage;

			ChargeLevel = Capacity;
		} // 1p
	}
}
