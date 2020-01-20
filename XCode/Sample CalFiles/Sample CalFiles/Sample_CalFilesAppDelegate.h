//
//  Sample_CalFilesAppDelegate.h
//  Sample CalFiles
//
//  Created by Klein Instruments on 11/18/2014.
//  Copyright 2014 Klein Instruments. All rights reserved.
//

#import <Cocoa/Cocoa.h>
#import <NSKClmtr/NSKClmtr.h>

@interface Sample_CalFilesAppDelegate : NSObject <NSApplicationDelegate> {
@private
    NSWindow *window;
    NSKClmtr *kclmtr;
}

@property (assign) IBOutlet NSTextField *portName;
@property (assign) IBOutlet NSTextField *x;
@property (assign) IBOutlet NSTextField *y;
@property (assign) IBOutlet NSTextField *L;
@property (assign) IBOutlet NSTextField *calID;
@property (assign) IBOutlet NSTextField *calName;
@property (assign) IBOutlet NSTextView *calList;

-(IBAction) setPort:(id)sender;
-(IBAction) connect:(id)sender;
-(IBAction) getxyL:(id)sender;

-(IBAction) getCalList:(id)sender;
-(IBAction) setCalIDButton:(id)sender;

@end
