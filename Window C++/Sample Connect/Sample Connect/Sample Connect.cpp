// Sample Connect.cpp : Defines the entry point for the console application.
//
#include "KClmtr.h"
#include <stdio.h>
#include "stdafx.h"
#include <conio.h>
#include <ctime>

using namespace KClmtrBase;
using namespace KClmtrBase::KClmtrNative;

int _tmain(int argc, _TCHAR* argv[])
{
	KClmtr kclmtr;

	kclmtr.setPort("COM3");
	kclmtr.connect();
	if (kclmtr.isPortOpen())
	{
		printf("Open\n");
		printf("SN: '%s'\n", kclmtr.getSerialNumber().c_str());
		printf("Model: '%s'\n", kclmtr.getModel().c_str());
		//kclmtr.setMeasureSpeedMode(KClmtr::SPEEDMODE_FAST);
		Measurement measure = kclmtr.getNextMeasurement();
		if(KleinsErrorCodes::shouldStopMeasuring(measure.getErrorCode())) {
			kclmtr.stopMeasuring();
			printf("ERROR: %s\n", KleinsErrorCodes::errorCodesToString(measure.getErrorCode()).c_str());
		} else { 
			printf("x: %f y: %f Y: %f\n", measure.getCIE1931_x(), measure.getCIE1931_y(), measure.getBigY());
		}
	} else {
		printf("Not Open\n");
	}
	fflush(stdout);
	kclmtr.closePort();
	getchar();
	return 0;
}

