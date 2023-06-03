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
		kclmtr.startMeasuring();
		Sleep(1500);
		for(int i = 0; i < 10; ++i) {
			Measurement measure;
			if(kclmtr.getMeasurement(measure)) {
				if(KleinsErrorCodes::shouldStopMeasuring(measure.getErrorCode())) {
					kclmtr.stopMeasuring();
					printf("Error: %s", KleinsErrorCodes::errorCodesToString(measure.getErrorCode()).c_str());
				} else {
					printf("x: %f y: %f Y: %f\n", measure.getCIE1931_x(), measure.getCIE1931_y(), measure.getBigY());
				} 
			} else {
				printf("not freash\n");
			}
			Sleep(150);
		}
		kclmtr.stopMeasuring();
	}
	else
		printf("Not Open\n");

	getchar();
	kclmtr.stopMeasuring();
	kclmtr.closePort();
	return 0;
}

