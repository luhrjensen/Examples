#include "../../libraries/bin/headers/KClmtr.h"
#include <stdio.h>

using namespace KClmtrBase;
using namespace KClmtrNative;

int main(int argc, char* argv[])
{
	KClmtr kclmtr;

	kclmtr.setPort("/dev/ttyUSB0");
	kclmtr.connect();
	if(kclmtr.isPortOpen() ==  true) {
		printf("Open\n");
		printf("SN: '%s'\n", kclmtr.getSerialNumber().c_str());
		printf("Model: '%s'\n", kclmtr.getModel().c_str());
		vector<string> calList = kclmtr.getCalFileList();
		for(int i = 0; i < 12; ++i)
			printf("%s\n", calList[i].c_str());
		kclmtr.setCalFileID(10);
		printf("Selected: %s\n", kclmtr.getCalFileName().c_str());
		Measurement measure = kclmtr.getNextMeasurement();
		if(KleinsErrorCodes::shouldStopMeasuring(measure.getErrorCode())) {
			kclmtr.stopMeasuring();
			printf("Error: %s", KleinsErrorCodes::errorCodesToString(measure.getErrorCode()).c_str());
			fflush(stdout);
		} else {
			printf("x: %f y: %f Y: %f\n", measure.getCIE1931_x(), measure.getCIE1931_y(), measure.getBigY());
		}
	} else {
		printf("Not Open\n");
	}
	kclmtr.closePort();
	getchar();
	return 0;
}
