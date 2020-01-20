// Sample Continuously Measuring.cpp : Defines the entry point for the console application.
//
#include "../../../libraries/bin/headers/KClmtr.h"
#include <stdio.h>
#include "stdafx.h"

using namespace KClmtrBase;
using namespace KClmtrNative;

class subClass : public KClmtr
{
public:
	void printMeasure(Measurement measure) {
		if(KleinsErrorCodes::shouldStopMeasuring(measure.getErrorCode())) {
			stopMeasuring();
			printf("ERROR: %s\n", KleinsErrorCodes::errorCodesToString(measure.getErrorCode()).c_str());
		} else { 
			printf("x: %f y: %f Y: %f avgBy: %d\n", measure.getCIE1931_x(), measure.getCIE1931_y(), measure.getBigY(), measure.getAveragingby());
		}
	}
};

int _tmain(int argc, _TCHAR* argv[])
{
	subClass kclmtr;

	kclmtr.setPort("COM3");
	kclmtr.connect();
	if(kclmtr.isPortOpen() ==  true)
	{
		printf("Open\n");
		printf("SN: '%s'\n", kclmtr.getSerialNumber().c_str());
		printf("Model: '%s'\n", kclmtr.getModel().c_str());
		//kclmtr->setMeasureSpeedMode(KClmtr::SPEEDMODE_FAST);  //To set the Speed to be Fast Measuring
		kclmtr.startMeasuring();
	}
	else
		printf("Not Open\n");

	getchar();
	kclmtr.stopMeasuring();
	kclmtr.closePort();
	getchar();
	return 0;
}

