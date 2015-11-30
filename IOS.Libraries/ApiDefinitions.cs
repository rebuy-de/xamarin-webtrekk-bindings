using System;
using Foundation;
using ObjCRuntime;

namespace IOS.Libraries
{
    // @interface WTConfiguration : NSObject
    [BaseType (typeof(NSObject))]
    interface WTConfiguration
    {
        // @property (readonly, copy, nonatomic) NSURL * serverUrl;
        [Export ("serverUrl", ArgumentSemantic.Copy)]
        NSUrl ServerUrl { get; }

        // @property (readonly, copy, nonatomic) NSString * trackId;
        [Export ("trackId")]
        string TrackId { get; }

        // @property (nonatomic) NSUInteger samplingRate;
        [Export ("samplingRate")]
        nuint SamplingRate { get; set; }

        // @property (nonatomic) NSTimeInterval sendDelay;
        [Export ("sendDelay")]
        double SendDelay { get; set; }

        // @property (copy, nonatomic) NSString * appVersionParameter;
        [Export ("appVersionParameter")]
        string AppVersionParameter { get; set; }

        // @property (getter = isUsingAdIdentifier, nonatomic) BOOL useAdIdentifier;
        [Export ("useAdIdentifier")]
        bool UseAdIdentifier { [Bind ("isUsingAdIdentifier")] get; set; }

        // -(instancetype)initWithServerUrl:(NSURL *)serverUrl trackId:(NSString *)trackId;
        [Export ("initWithServerUrl:trackId:")]
        IntPtr Constructor (NSUrl serverUrl, string trackId);

        // -(void)crossDeviceDataAddEmail:(NSString *)email;
        [Export ("crossDeviceDataAddEmail:")]
        void CrossDeviceDataAddEmail (string email);

        // -(void)crossDeviceDataAddEmailAsMD5:(NSString *)md5;
        [Export ("crossDeviceDataAddEmailAsMD5:")]
        void CrossDeviceDataAddEmailAsMD5 (string md5);

        // -(void)crossDeviceDataAddEmailAsSHA256:(NSString *)sha256;
        [Export ("crossDeviceDataAddEmailAsSHA256:")]
        void CrossDeviceDataAddEmailAsSHA256 (string sha256);

        // -(void)crossDeviceDataAddPhoneNumber:(NSString *)phoneNumber;
        [Export ("crossDeviceDataAddPhoneNumber:")]
        void CrossDeviceDataAddPhoneNumber (string phoneNumber);

        // -(void)crossDeviceDataAddPhoneNumberAsMD5:(NSString *)md5;
        [Export ("crossDeviceDataAddPhoneNumberAsMD5:")]
        void CrossDeviceDataAddPhoneNumberAsMD5 (string md5);

        // -(void)crossDeviceDataAddPhoneNumberAsSHA256:(NSString *)sha256;
        [Export ("crossDeviceDataAddPhoneNumberAsSHA256:")]
        void CrossDeviceDataAddPhoneNumberAsSHA256 (string sha256);

        // -(void)crossDeviceDataAddAddressFirstName:(NSString *)firstName lastName:(NSString *)lastName postalCode:(NSString *)postalCode street:(NSString *)street streetNumber:(NSString *)streetNumber;
        [Export ("crossDeviceDataAddAddressFirstName:lastName:postalCode:street:streetNumber:")]
        void CrossDeviceDataAddAddressFirstName (string firstName, string lastName, string postalCode, string street, string streetNumber);

        // -(void)crossDeviceDataAddressAddAsMD5:(NSString *)md5;
        [Export ("crossDeviceDataAddressAddAsMD5:")]
        void CrossDeviceDataAddressAddAsMD5 (string md5);

        // -(void)crossDeviceDataAddressAddAsSHA256:(NSString *)sha56;
        [Export ("crossDeviceDataAddressAddAsSHA256:")]
        void CrossDeviceDataAddressAddAsSHA256 (string sha56);

        // -(void)crossDeviceDataAddFacebookId:(NSString *)fId;
        [Export ("crossDeviceDataAddFacebookId:")]
        void CrossDeviceDataAddFacebookId (string fId);

        // -(void)crossDeviceDataAddTwitterId:(NSString *)tId;
        [Export ("crossDeviceDataAddTwitterId:")]
        void CrossDeviceDataAddTwitterId (string tId);

        // -(void)crossDeviceDataAddLinkedInId:(NSString *)lId;
        [Export ("crossDeviceDataAddLinkedInId:")]
        void CrossDeviceDataAddLinkedInId (string lId);

        // -(void)crossDeviceDataAddGooglePlusId:(NSString *)gId;
        [Export ("crossDeviceDataAddGooglePlusId:")]
        void CrossDeviceDataAddGooglePlusId (string gId);

        // -(void)clearCrossDeviceData;
        [Export ("clearCrossDeviceData")]
        void ClearCrossDeviceData ();

        // -(NSDictionary *)getCrossDeviceDictionary;
        [Export ("getCrossDeviceDictionary")]
        NSDictionary CrossDeviceDictionary { get; }
    }

    // @interface Webtrekk : NSObject
    [BaseType (typeof(NSObject))]
    interface Webtrekk
    {
        // +(void)startWithServerUrl:(NSURL *)serverUrl trackId:(NSString *)trackId;
        [Static]
        [Export ("startWithServerUrl:trackId:")]
        void StartWithServerUrl (NSUrl serverUrl, string trackId);

        // +(void)startWithServerUrl:(NSURL *)serverUrl trackId:(NSString *)trackId samplingRate:(NSUInteger)samplingRate;
        [Static]
        [Export ("startWithServerUrl:trackId:samplingRate:")]
        void StartWithServerUrl (NSUrl serverUrl, string trackId, nuint samplingRate);

        // +(void)startWithServerUrl:(NSURL *)serverUrl trackId:(NSString *)trackId samplingRate:(NSUInteger)samplingRate sendDelay:(NSTimeInterval)sendDelay;
        [Static]
        [Export ("startWithServerUrl:trackId:samplingRate:sendDelay:")]
        void StartWithServerUrl (NSUrl serverUrl, string trackId, nuint samplingRate, double sendDelay);

        // +(void)startWithServerUrl:(NSURL *)serverUrl trackId:(NSString *)trackId samplingRate:(NSUInteger)samplingRate sendDelay:(NSTimeInterval)sendDelay appVersionParameter:(NSString *)appVersionParameter;
        [Static]
        [Export ("startWithServerUrl:trackId:samplingRate:sendDelay:appVersionParameter:")]
        void StartWithServerUrl (NSUrl serverUrl, string trackId, nuint samplingRate, double sendDelay, string appVersionParameter);

        // +(void)startWithConfiguration:(WTConfiguration *)config;
        [Static]
        [Export ("startWithConfiguration:")]
        void StartWithConfiguration (WTConfiguration config);

        // +(void)stop;
        [Static]
        [Export ("stop")]
        void Stop ();

        // +(void)trackClick:(NSString *)clickId contentId:(NSString *)contentId;
        [Static]
        [Export ("trackClick:contentId:")]
        void TrackClick (string clickId, string contentId);

        // +(void)trackClick:(NSString *)clickId contentId:(NSString *)contentId additionalParameters:(NSDictionary *)additionalParameters;
        [Static]
        [Export ("trackClick:contentId:additionalParameters:")]
        void TrackClick (string clickId, string contentId, NSDictionary additionalParameters);

        // +(void)trackContent:(NSString *)contentId;
        [Static]
        [Export ("trackContent:")]
        void TrackContent (string contentId);

        // +(void)trackContent:(NSString *)contentId additionalParameters:(NSDictionary *)additionalParameters;
        [Static]
        [Export ("trackContent:additionalParameters:")]
        void TrackContent (string contentId, NSDictionary additionalParameters);

        // +(BOOL)optedOut;
        // +(void)setOptedOut:(BOOL)optedOut;
        [Static]
        [Export ("optedOut")]
        bool OptedOut { get; set; }

        // +(NSString *)everId;
        [Static]
        [Export ("everId")]
        string EverId ();

        // +(NSString *)version;
        [Static]
        [Export ("version")]
        string Version ();

        // +(BOOL)isThisVersionAnUpdate;
        [Static]
        [Export ("isThisVersionAnUpdate")]
        bool IsThisVersionAnUpdate ();

        // +(NSString *)appVersionParameter;
        [Static]
        [Export ("appVersionParameter")]
        string AppVersionParameter ();

        // +(void)setAppVersionParameter:(NSString *)appVersionParameter;
        [Static]
        [Export ("setAppVersionParameter:")]
        void SetAppVersionParameter (string appVersionParameter);

        // +(BOOL)isUsingAdIdentifier;
        [Static]
        [Export ("isUsingAdIdentifier")]
        bool IsUsingAdIdentifier ();

        // +(void)useAdIdentifier:(BOOL)useAdIdentifier;
        [Static]
        [Export ("useAdIdentifier:")]
        void UseAdIdentifier (bool useAdIdentifier);

        // +(void)addCrossDeviceDataEmail:(NSString *)email;
        [Static]
        [Export ("addCrossDeviceDataEmail:")]
        void AddCrossDeviceDataEmail (string email);

        // +(void)addCrossDeviceDataEmailAsMD5:(NSString *)md5;
        [Static]
        [Export ("addCrossDeviceDataEmailAsMD5:")]
        void AddCrossDeviceDataEmailAsMD5 (string md5);

        // +(void)addCrossDeviceDataEmailAsSHA256:(NSString *)sha256;
        [Static]
        [Export ("addCrossDeviceDataEmailAsSHA256:")]
        void AddCrossDeviceDataEmailAsSHA256 (string sha256);

        // +(void)addCrossDeviceDataPhoneNumber:(NSString *)phoneNumber;
        [Static]
        [Export ("addCrossDeviceDataPhoneNumber:")]
        void AddCrossDeviceDataPhoneNumber (string phoneNumber);

        // +(void)addCrossDeviceDataPhoneNumberAsMD5:(NSString *)md5;
        [Static]
        [Export ("addCrossDeviceDataPhoneNumberAsMD5:")]
        void AddCrossDeviceDataPhoneNumberAsMD5 (string md5);

        // +(void)addCrossDeviceDataPhoneNumberAsSHA256:(NSString *)sha256;
        [Static]
        [Export ("addCrossDeviceDataPhoneNumberAsSHA256:")]
        void AddCrossDeviceDataPhoneNumberAsSHA256 (string sha256);

        // +(void)addCrossDeviceDataAddressFirstName:(NSString *)firstName lastName:(NSString *)lastName postalCode:(NSString *)postalCode street:(NSString *)street streetNumber:(NSString *)streetNumber;
        [Static]
        [Export ("addCrossDeviceDataAddressFirstName:lastName:postalCode:street:streetNumber:")]
        void AddCrossDeviceDataAddressFirstName (string firstName, string lastName, string postalCode, string street, string streetNumber);

        // +(void)addCrossDeviceDataAddressAsMD5:(NSString *)md5;
        [Static]
        [Export ("addCrossDeviceDataAddressAsMD5:")]
        void AddCrossDeviceDataAddressAsMD5 (string md5);

        // +(void)addCrossDeviceDataAddressAsSHA256:(NSString *)sha56;
        [Static]
        [Export ("addCrossDeviceDataAddressAsSHA256:")]
        void AddCrossDeviceDataAddressAsSHA256 (string sha56);

        // +(void)addCrossDeviceDataFacebookId:(NSString *)facebookId;
        [Static]
        [Export ("addCrossDeviceDataFacebookId:")]
        void AddCrossDeviceDataFacebookId (string facebookId);

        // +(void)addCrossDeviceDataTwitterId:(NSString *)twitterId;
        [Static]
        [Export ("addCrossDeviceDataTwitterId:")]
        void AddCrossDeviceDataTwitterId (string twitterId);

        // +(void)addCrossDeviceDataLinkedInId:(NSString *)linkedInId;
        [Static]
        [Export ("addCrossDeviceDataLinkedInId:")]
        void AddCrossDeviceDataLinkedInId (string linkedInId);

        // +(void)addCrossDeviceDataGooglePlusId:(NSString *)googlePlusId;
        [Static]
        [Export ("addCrossDeviceDataGooglePlusId:")]
        void AddCrossDeviceDataGooglePlusId (string googlePlusId);

        // +(void)clearCrossDeviceData;
        [Static]
        [Export ("clearCrossDeviceData")]
        void ClearCrossDeviceData ();
    }

    // @interface WTMediaCategories : NSObject
    [BaseType (typeof(NSObject))]
    interface WTMediaCategories
    {
        // @property (readonly, nonatomic) NSString * category1;
        [Export ("category1")]
        string Category1 { get; }

        // @property (readonly, nonatomic) NSString * category2;
        [Export ("category2")]
        string Category2 { get; }

        // @property (readonly, nonatomic) NSString * category3;
        [Export ("category3")]
        string Category3 { get; }

        // @property (readonly, nonatomic) NSString * category4;
        [Export ("category4")]
        string Category4 { get; }

        // @property (readonly, nonatomic) NSString * category5;
        [Export ("category5")]
        string Category5 { get; }

        // @property (readonly, nonatomic) NSString * category6;
        [Export ("category6")]
        string Category6 { get; }

        // @property (readonly, nonatomic) NSString * category7;
        [Export ("category7")]
        string Category7 { get; }

        // @property (readonly, nonatomic) NSString * category8;
        [Export ("category8")]
        string Category8 { get; }

        // @property (readonly, nonatomic) NSString * category9;
        [Export ("category9")]
        string Category9 { get; }

        // @property (readonly, nonatomic) NSString * category10;
        [Export ("category10")]
        string Category10 { get; }

        // +(id)newWithCategories:(NSArray *)categories;
        [Static]
        [Export ("newWithCategories:")]
        NSObject NewWithCategories (NSObject[] categories);

        // +(id)newWithCategory1:(NSString *)category1;
        [Static]
        [Export ("newWithCategory1:")]
        NSObject NewWithCategory1 (string category1);

        // +(id)newWithCategory1:(NSString *)category1 category2:(NSString *)category2;
        [Static]
        [Export ("newWithCategory1:category2:")]
        NSObject NewWithCategory1 (string category1, string category2);

        // +(id)newWithCategory1:(NSString *)category1 category2:(NSString *)category2 category3:(NSString *)category3;
        [Static]
        [Export ("newWithCategory1:category2:category3:")]
        NSObject NewWithCategory1 (string category1, string category2, string category3);

        // +(id)newWithCategory1:(NSString *)category1 category2:(NSString *)category2 category3:(NSString *)category3 category4:(NSString *)category4;
        [Static]
        [Export ("newWithCategory1:category2:category3:category4:")]
        NSObject NewWithCategory1 (string category1, string category2, string category3, string category4);

        // +(id)newWithCategory1:(NSString *)category1 category2:(NSString *)category2 category3:(NSString *)category3 category4:(NSString *)category4 category5:(NSString *)category5;
        [Static]
        [Export ("newWithCategory1:category2:category3:category4:category5:")]
        NSObject NewWithCategory1 (string category1, string category2, string category3, string category4, string category5);

        // +(id)newWithCategory1:(NSString *)category1 category2:(NSString *)category2 category3:(NSString *)category3 category4:(NSString *)category4 category5:(NSString *)category5 category6:(NSString *)category6;
        [Static]
        [Export ("newWithCategory1:category2:category3:category4:category5:category6:")]
        NSObject NewWithCategory1 (string category1, string category2, string category3, string category4, string category5, string category6);

        // +(id)newWithCategory1:(NSString *)category1 category2:(NSString *)category2 category3:(NSString *)category3 category4:(NSString *)category4 category5:(NSString *)category5 category6:(NSString *)category6 category7:(NSString *)category7;
        [Static]
        [Export ("newWithCategory1:category2:category3:category4:category5:category6:category7:")]
        NSObject NewWithCategory1 (string category1, string category2, string category3, string category4, string category5, string category6, string category7);

        // +(id)newWithCategory1:(NSString *)category1 category2:(NSString *)category2 category3:(NSString *)category3 category4:(NSString *)category4 category5:(NSString *)category5 category6:(NSString *)category6 category7:(NSString *)category7 category8:(NSString *)category8;
        [Static]
        [Export ("newWithCategory1:category2:category3:category4:category5:category6:category7:category8:")]
        NSObject NewWithCategory1 (string category1, string category2, string category3, string category4, string category5, string category6, string category7, string category8);

        // +(id)newWithCategory1:(NSString *)category1 category2:(NSString *)category2 category3:(NSString *)category3 category4:(NSString *)category4 category5:(NSString *)category5 category6:(NSString *)category6 category7:(NSString *)category7 category8:(NSString *)category8 category9:(NSString *)category9;
        [Static]
        [Export ("newWithCategory1:category2:category3:category4:category5:category6:category7:category8:category9:")]
        NSObject NewWithCategory1 (string category1, string category2, string category3, string category4, string category5, string category6, string category7, string category8, string category9);

        // +(id)newWithCategory1:(NSString *)category1 category2:(NSString *)category2 category3:(NSString *)category3 category4:(NSString *)category4 category5:(NSString *)category5 category6:(NSString *)category6 category7:(NSString *)category7 category8:(NSString *)category8 category9:(NSString *)category9 category10:(NSString *)category10;
        [Static]
        [Export ("newWithCategory1:category2:category3:category4:category5:category6:category7:category8:category9:category10:")]
        NSObject NewWithCategory1 (string category1, string category2, string category3, string category4, string category5, string category6, string category7, string category8, string category9, string category10);
    }
}
