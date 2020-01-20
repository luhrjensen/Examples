//
//  Sample_CalFilesAppDelegate.m
//  Sample CalFiles
//
//  Created by Klein Instruments on 11/18/2014.
//  Copyright 2014 Klein Instruments. All rights reserved.
//

#import "Sample_CalFilesAppDelegate.h"

@implementation Sample_CalFilesAppDelegate

- (void)applicationDidFinishLaunching:(NSNotification *)aNotification
{
    kclmtr = [[NSKClmtr alloc] init];
}

- (IBAction)setPort:(id)sender
{
    [kclmtr setPort:[_portName stringValue]];
}
- (IBAction)connect:(id)sender
{
    [kclmtr connect];
}
- (IBAction)getxyL:(id)sender
{
    Measurement m = [kclmtr getNextMeasurment:1];
    if(KleinsErrorCodes::shouldStopMeasuring(m.getErrorCode())) {
        NSRunAlertPanel(@"Error", @"%@", @"OK", nil, nil, KleinsErrorCodes::errorCodesToString(m.getErrorCode()));
    } else {
        [_x setStringValue:[NSString stringWithFormat:@"%f", m.getCIE1931_x()]];
        [_y setStringValue:[NSString stringWithFormat:@"%f", m.getCIE1931_y()]];
        [_L setStringValue:[NSString stringWithFormat:@"%f", m.getBigY()]];
    }
}

- (IBAction)getCalList:(id)sender
{
    NSMutableString *calList2 = [[NSMutableString alloc] init];
    NSArray *CalList1 = [kclmtr getCalfileList];
    for(int i = 0; i < 12; ++i)
        [calList2 appendFormat:@"%s\n", [[CalList1 objectAtIndex:i] UTF8String]]; 
    [_calList setString:calList2];
}
- (IBAction)setCalIDButton:(id)sender
{
    [kclmtr setCalFileID:[[_calID stringValue] intValue]];
    [_calName setStringValue:[kclmtr getCalfileName]];
}


@end
