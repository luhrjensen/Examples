#include "../../libraries/bin/headers/KClmtr.h"
#include <stdio.h>

using namespace KClmtrBase;
using namespace KClmtrNative;

class PrintKClmtr : public KClmtr {
	public:
		void printFlicker(Flicker flicker) {
                        if(KleinsErrorCodes::shouldStopMeasuring(flicker.getErrorCode())) {
                                stopMeasuring();
                                printf("Error: %s", KleinsErrorCodes::errorCodesToString(flicker.getErrorCode()).c_str());
                                fflush(stdout);
			} else {
				printf("1\t%f\t%f\t%f\t%f\n", flicker.getPeakFrequencyPercent().v[0][0], flicker.getPeakFrequencyPercent().v[0][1],  //Percent
											  flicker.getPeakFrequencyDB().v[0][0], flicker.getPeakFrequencyDB().v[0][1]); //Db
				printf("2\t%f\t%f\t%f\t%f\n", flicker.getPeakFrequencyPercent().v[1][0], flicker.getPeakFrequencyPercent().v[1][1],
											  flicker.getPeakFrequencyDB().v[1][0], flicker.getPeakFrequencyDB().v[1][1]);
				printf("3\t%f\t%f\t%f\t%f\n", flicker.getPeakFrequencyPercent().v[2][0], flicker.getPeakFrequencyPercent().v[2][1],
											  flicker.getPeakFrequencyDB().v[2][0], flicker.getPeakFrequencyDB().v[2][1]);
			}
	}
};

int main(int argc, char* argv[])
{
	PrintKClmtr kclmtr;

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
		kclmtr.startFlicker();
		getchar();
		kclmtr.stopFlicker();
	} else {
		printf("Not Open\n");
	}
	kclmtr.closePort();
	getchar();
	return 0;
}
