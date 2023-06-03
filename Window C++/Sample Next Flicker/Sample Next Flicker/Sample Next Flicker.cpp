// Sample Continuously Measuring.cpp : Defines the entry point for the console application.
//
#include "KClmtr.h"
#include <stdio.h>
#include "stdafx.h"

using namespace KClmtrBase;
using namespace KClmtrNative;

int _tmain(int argc, _TCHAR* argv[]) {
	KClmtr kclmtr;

	kclmtr.setPort("COM3");
	kclmtr.connect();
	if(kclmtr.isPortOpen() ==  true) {
		printf("Open\n");
		printf("SN: '%s'\n", kclmtr.getSerialNumber().c_str());
		printf("Model: '%s'\n", kclmtr.getModel().c_str());
		printf("Peak\tHz\t\tpercent\t\tHz\t\tdB\n");
		for(int i = 0; i < 10; ++i) {
			Flicker flicker = kclmtr.getNextFlicker();
			if(KleinsErrorCodes::shouldStopMeasuring(flicker.getErrorCode())) {
				kclmtr.stopFlicker();
				printf("Error: %s", KleinsErrorCodes::errorCodesToString(flicker.getErrorCode()).c_str());
			} else {
				printf("1\t%f\t%f\t%f\t%f\n", flicker.getPeakFrequencyPercent().v[0][0], flicker.getPeakFrequencyPercent().v[0][1],  //Percent
											  flicker.getPeakFrequencyDB().v[0][0],		 flicker.getPeakFrequencyDB().v[0][1]); //Db
				printf("2\t%f\t%f\t%f\t%f\n", flicker.getPeakFrequencyPercent().v[1][0], flicker.getPeakFrequencyPercent().v[1][1],
											  flicker.getPeakFrequencyDB().v[1][0],		 flicker.getPeakFrequencyDB().v[1][1]);
				printf("3\t%f\t%f\t%f\t%f\n", flicker.getPeakFrequencyPercent().v[2][0], flicker.getPeakFrequencyPercent().v[2][1],
											  flicker.getPeakFrequencyDB().v[2][0],      flicker.getPeakFrequencyDB().v[2][1]);
			}
		}
	}
	else
		printf("Not Open\n");

	getchar();
	kclmtr.closePort();
	return 0;
}

