//
//  Sample_Continuously_MeasuringAppDelegate.h
//  Sample Continuously Measuring
//
//  Created by Klein Instruments on 5/25/12.
//  Copyright 2012 Klein Instruments. All rights reserved.
//

#import <Cocoa/Cocoa.h>
#import <NSKClmtr/NSKClmtr.h>

@interface Sample_Continuously_MeasuringAppDelegate : NSObject <NSApplicationDelegate> {
@private
    NSWindow *window;
    NSKClmtr *kclmtr;
}

@property (assign) IBOutlet NSWindow *window;
@property (assign) IBOutlet NSTextField *portName;
@property (assign) IBOutlet NSTextField *x;
@property (assign) IBOutlet NSTextField *y;
@property (assign) IBOutlet NSTextField *L;

-(IBAction) setPort:(id)sender;
-(IBAction) connect:(id)sender;
-(IBAction) getxyL:(id)sender;
-(IBAction) hold:(id)sender;

-(void)printTheMeasurement:(id)m;


@end
