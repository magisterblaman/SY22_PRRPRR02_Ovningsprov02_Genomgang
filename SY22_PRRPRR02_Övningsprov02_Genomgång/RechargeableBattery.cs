using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_Övningsprov02_Genomgång {
	internal class RechargeableBattery : Battery {

		private double _chargeCurrent;
		private int _chargeCycles;

		public int ChargeCycles {
			get {
				return _chargeCycles;
			}
			private set {
				_chargeCycles = value;
			}
		} // 1p

		public bool IsFullyCharged {
			get {
				if (BatteryLevel == 100) {
					return true;
				} else {
					return false;
				}
			}
		} // 1p

		public double Charge(double duration) { // 1p
			double prevChargeLevel = ChargeLevel;

			ChargeCycles += 1;
			int percent = 100 - ChargeCycles;
			double ff = (double)percent / 100;
			Capacity *= ff; // 1p

			if (Capacity < ChargeLevel) {
				ChargeLevel = Capacity;
			} // 0,5p

			ChargeLevel += duration * _chargeCurrent; // 0,25p
			if (ChargeLevel > Capacity) {
				ChargeLevel = Capacity;
			} // 0,5p

			return (ChargeLevel - prevChargeLevel) * Voltage; // 0,25p
		}

		public RechargeableBattery(double inputCapacity, double inputMaxCurrent, double inputVoltage, double inputChargeCurrent) : base(inputCapacity, inputMaxCurrent, inputVoltage) {
			_chargeCurrent = inputChargeCurrent;

			ChargeCycles = 0;
		} // 1p

	}
}
