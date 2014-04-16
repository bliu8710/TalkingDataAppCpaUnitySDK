/*
*  Talking Data App Cpa Manager
*
*  liu
*/
#import "TalkingDataAppCpa.h"

extern "C" {      
    void _cpaInit(const char* appKey, const char* channelId);
    void _cpaOnRegister(const char* account);
    void _cpaOnLogin(const char* account);
    void _cpaOnPay(const char* account, const char* orderId, int amount, const char* currencyType);
    void _cpaOnCustEvent1();
    void _cpaOnCustEvent2();
    void _cpaOnCustEvent3();
    void _cpaOnCustEvent4();
    void _cpaOnCustEvent5();
    void _cpaOnCustEvent6();
    void _cpaOnCustEvent7();
    void _cpaOnCustEvent8();
    void _cpaOnCustEvent9();
    void _cpaOnCustEvent10();
}

void _cpaInit(const char* appKey, const char* channelId)
{
    [TalkingDataAppCpa init:[NSString stringWithUTF8String:appKey] withChannelId:[NSString stringWithUTF8String:channelId] ];
}

void _cpaOnRegister(const char* account)
{
    [TalkingDataAppCpa onRegister:[NSString stringWithUTF8String:account] ];
}

void _cpaOnLogin(const char* account)
{
    [TalkingDataAppCpa onLogin:[NSString stringWithUTF8String:account] ];
}

void _cpaOnPay(const char* account, const char* orderId, int amount, const char* currencyType)
{
    [TalkingDataAppCpa onPay:[NSString stringWithUTF8String:account] withOrderId:[NSString stringWithUTF8String:orderId] withAmount:amount withCurrencyType:[NSString stringWithUTF8String:currencyType] ];
}

void _cpaOnCustEvent1()
{
    [TalkingDataAppCpa onCustEvent1 ];
}

void _cpaOnCustEvent2()
{
    [TalkingDataAppCpa onCustEvent2 ];
}

void _cpaOnCustEvent3()
{
    [TalkingDataAppCpa onCustEvent3 ];
}

void _cpaOnCustEvent4()
{
    [TalkingDataAppCpa onCustEvent4 ];
}

void _cpaOnCustEvent5()
{
    [TalkingDataAppCpa onCustEvent5 ];
}

void _cpaOnCustEvent6()
{
    [TalkingDataAppCpa onCustEvent6 ];
}

void _cpaOnCustEvent7()
{
    [TalkingDataAppCpa onCustEvent7 ];
}

void _cpaOnCustEvent8()
{
    [TalkingDataAppCpa onCustEvent8 ];
}

void _cpaOnCustEvent9()
{
    [TalkingDataAppCpa onCustEvent9 ];
}

void _cpaOnCustEvent10()
{
    [TalkingDataAppCpa onCustEvent10 ];
}