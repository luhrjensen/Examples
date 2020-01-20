//
//  Sample_Continuously_MeasuringAppDelegate.m
//  Sample Continuously Measuring
//
//  Created by Klein Instruments on 5/25/12.
//  Copyright 2012 Klein Instruments. All rights reserved.
//

#import "Sample_Continuously_MeasuringAppDelegate.h"

@implementation Sample_Continuously_MeasuringAppDelegate

@synthesize window, portName, x, y, L;

- (void)applicationDidFinishLaunching:(NSNotification *)aNotification
{
    kclmtr = [[NSKClmtr alloc] init];
    [kclmtr addTargetForMeasure:self action:@selector(printTheMeasurement:)];
}

-(IBAction) setPort:(id)sender
{  
    [kclmtr setPort:[portName stringValue]];
}
-(IBAction) connect:(id)sender
{
    [kclmtr connect];
}
-(IBAction) getxyL:(id)sender
{
    if([kclmtr connect])
    {
        [kclmtr startMeasuring];
    }
}
-(IBAction) hold:(id)sender
{
    [kclmtr stopMeasuring];
}

-(void)printTheMeasurement:(id)m
{
    Measurement measure;
    [m getValue:&measure];
    if(KleinsErrorCodes::shouldStopMeasuring(measure.getErrorCode())) {
        [kclmtr stopMeasuring];
        NSRunAlertPanel(@"Error", @"%@", @"OK", nil, nil, KleinsErrorCodes::errorCodesToString(measure.getErrorCode()));
    } else {
        [x setStringValue:[NSString stringWithFormat:@"%f", measure.getCIE1931_x()]];
        [y setStringValue:[NSString stringWithFormat:@"%f", measure.getCIE1931_y()]];
        [L setStringValue:[NSString stringWithFormat:@"%f", measure.getBigY()]];
    }
}
@end
