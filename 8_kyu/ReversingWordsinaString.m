#import <Foundation/Foundation.h>
NSString* reverse(NSString* text) {

      NSArray* array= [text componentsSeparatedByString:@" " ];
      NSArray* reversedArray = [[array reverseObjectEnumerator] allObjects];
      
      NSString * result = [reversedArray componentsJoinedByString:@" "];
      
      return  result;
}
