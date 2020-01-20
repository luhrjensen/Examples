// Sample CalFiles.cpp : Defines the entry point for the console application.
//

#include "../../../libraries/bin/headers/KClmtr.h"
#include <stdio.h>
#include "stdafx.h"

using namespace KClmtrBase;
using namespace KClmtrBase::KClmtrNative;

int _tmain(int argc, _TCHAR* argv[])
{
	KClmtr kclmtr;

	kclmtr.setPort("COM3");
	kclmtr.connect();
	if(kclmtr.isPortOpen() ==  true)
	{
		printf("Open\n");
		printf("SN: '%s'\n", kclmtr.getSerialNumber().c_str());
		printf("Model: '%s'\n", kclmtr.getModel().c_str());
		
		//Profile List
		vector<string> calList = kclmtr.getCalFileList();
		for(int i = 0; i < 12; ++i)	
			printf("%s\n", calList[i].c_str());

		//Setting a profile
		kclmtr.setCalFileID(10);
		printf("%s\n", kclmtr.getCalFileName().c_str());

		//Using and getting a measurment with the corrected values
		Measurement measure = kclmtr.getNextMeasurement();
		if(KleinsErrorCodes::shouldStopMeasuring(measure.getErrorCode())) {
			kclmtr.stopMeasuring();
			printf("ERROR: %s\n", KleinsErrorCodes::errorCodesToString(measure.getErrorCode()).c_str());
		} else { 
			printf("x: %f y: %f Y: %f\n", measure.getCIE1931_x(), measure.getCIE1931_y(), measure.getBigY());
		}					
	}
	else
		printf("Not Open\n");

	kclmtr.closePort();
	getchar();
	return 0;
}