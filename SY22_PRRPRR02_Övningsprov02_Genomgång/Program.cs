using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_Övningsprov02_Genomgång {
	internal class Program {
		static void Main(string[] args) {
			PowerSource powerSource = new PowerSource(5);
			Console.WriteLine(powerSource.DrawPower(10, 10));

			Battery battery = new Battery(9000, 2, 1.5);
			Console.WriteLine(battery.Discharge(40, 3600));
			Console.WriteLine(battery.Discharge(2, 2300)); // 1p

			RechargeableBattery rechargeableBattery1 = new RechargeableBattery(9000, 2, 1.5, 4);
			RechargeableBattery rechargeableBattery2 = new RechargeableBattery(9000, 2, 1.5, 4);

			rechargeableBattery1.Discharge(3, 1000);
			rechargeableBattery2.Discharge(3, 1000);
			rechargeableBattery1.Charge(478);
			rechargeableBattery2.Charge(477);

			Console.WriteLine(rechargeableBattery1.BatteryLevel);
			Console.WriteLine(rechargeableBattery2.BatteryLevel); // 1p

			List<RechargeableBattery> batteries = new List<RechargeableBattery>() {
				new RechargeableBattery(3000, 2, 10, 5),
				new RechargeableBattery(5000, 3, 8, 69),
				new RechargeableBattery(7000, 4, 14, 1337),
			}; // 1p

			Console.WriteLine(batteries[0].Discharge(30, 100));
			Console.WriteLine(batteries[1].Discharge(45, 10));
			Console.WriteLine(batteries[2].Discharge(90, 3600));

			Console.WriteLine(batteries[0].Charge(100));
			Console.WriteLine(batteries[1].Charge(50));
			Console.WriteLine(batteries[2].Charge(200));

			Console.WriteLine(batteries[0].Discharge(30, 100));
			Console.WriteLine(batteries[1].Discharge(45, 10));
			Console.WriteLine(batteries[2].Discharge(90, 3600)); // 0,5p

		}
	}
}
