/*
	Els_kom_CryptoPP_Wrapper.h
*/
#ifdef __CPLUSPLUS
extern "C" {
#endif

#pragma once
#ifdef ELS_KOM_CRYPTOPP_WRAPPER_EXPORTS
#define Els_kom_Wrapper_Extern extern "C" __declspec(dllexport)
Els_kom_Wrapper_Extern int __cdecl Unpack_KOM_Generic(LPCSTR FileName, byte FileData, LPCSTR DestPath, int Alg);
Els_kom_Wrapper_Extern int __cdecl Pack_KOM_Generic(LPCSTR FileName, byte FileData, LPCSTR DestPath, int Alg);
# if (_MSC_VER >= 1900)
# error "This Project is not Complete Yet. So as Such it cannot be compiled until All Algorithms are Complete on Packing and Unpacking."
# endif
#else
#define Els_kom_Wrapper_Extern extern "C" __declspec(dllimport)
Els_kom_Wrapper_Extern int Unpack_KOM_Generic(LPCSTR FileName, byte FileData, LPCSTR DestPath, int Alg);
Els_kom_Wrapper_Extern int Pack_KOM_Generic(LPCSTR FileName, byte FileData, LPCSTR DestPath, int Alg);
#endif

#if (_MSC_VER < 1900)
#error "This Project cannot be compiled with C++ older than C++ 14.\nPlease get a newer version of C++."
#endif

#ifdef __CPLUSPLUS
}
#endif