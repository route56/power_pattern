using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainForm
{
	enum OSEvents
	{
		None,
		StandbyStarted,
		StandbyEnd,
	}

	class Win32EventHandler
	{
		const int WM_POWERBROADCAST = (0x0218);
		const int PBT_APMQUERYSUSPEND = (0x0000);
		const int PBT_APMRESUMESUSPEND = (0x0007);
		const int PBT_APMQUERYSTANDBY = (0x0001);
		const int PBT_APMQUERYSUSPENDFAILED = (0x0002);
		const int PBT_APMQUERYSTANDBYFAILED = (0x0003);
		const int PBT_APMSUSPEND = (0x0004);
		const int PBT_APMSTANDBY = (0x0005);
		const int PBT_APMRESUMECRITICAL = (0x0006);
		const int PBT_APMRESUMESTANDBY = (0x0008);
		const int PBTF_APMRESUMEFROMFAILURE = (0x00000001);
		const int PBT_APMBATTERYLOW = (0x0009);
		const int PBT_APMPOWERSTATUSCHANGE = (0x000A);
		const int PBT_APMOEMEVENT = (0x000B);
		const int PBT_APMRESUMEAUTOMATIC = (0x0012);

		internal static OSEvents Handle(ref System.Windows.Forms.Message m)
		{
			OSEvents osevent = OSEvents.None;

			switch (m.Msg)
			{
				case WM_POWERBROADCAST:
					switch (m.WParam.ToInt32())
					{
						//value passed when system is going on standby / suspended
						case PBT_APMQUERYSUSPEND:
							osevent = OSEvents.StandbyStarted;
							break;
						//value passed when system is resumed after suspension.
						case PBT_APMRESUMESUSPEND:
							osevent = OSEvents.StandbyEnd;
							break;

						////value passed when system Suspend Failed
						//case (PBT_APMQUERYSUSPENDFAILED):
						////value passed when system is suspended
						//case (PBT_APMSUSPEND):
						////value passed when system is resumed automatically
						//case (PBT_APMRESUMEAUTOMATIC):
						////value passed when system is resumed from critical
						////suspension possibly due to battery failure
						//case (PBT_APMRESUMECRITICAL):
						////value passed when system is low on battery
						//case (PBT_APMBATTERYLOW):
						////value passed when system power status changed
						////from battery to AC power or vice-a-versa
						//case (PBT_APMPOWERSTATUSCHANGE):
						////value passed when OEM Event is fired. Not sure what that is??
						//case (PBT_APMOEMEVENT):
						//    break;
					}
					break;
				default:
					break;
			}

			return osevent;
		}
	}
}
