# EasyFetch 

Easy-Fetch for Windows 10 (Mobile) v1.2.3-alpha

## About

A Simple utility to help users Manage their device with Device Portal, Download Flash Files, Update Cabs, Store Apps and more!

This great project forked from https://github.com/Empyreal96/Easy-Fetch-UWP. 

Reason: my own edicational purposes (some cool js "injection" mechanics, YT donloader, etc.).
Draft / Not for production.

### What's new in v1.2.3-alpha

- Minimal code refactoring.
- Minimal app logics change ("old" libvideo refactored & NiL.js injected...) 
- "Shorts" handler added
- App certificate prolongated till feb, 25 2025 

  **[Find the latest release here](https://github.com/Empyreal96/Easy-Fetch-UWP/releases/tag/1.13.16-prerelease)**


## What can it do?

- Download WP FFU Files and Emergency files.
- Download W10M Update Cabs
- Download Apps direct from the MS store
- Download YouTube Videos (Low Quality only for now*)
- General File Downloader
- Extract Common Archive Types
- Check for latest Github Release

*Features, Name and Layout may change over time, screenshots to be updated soon*
**Youtube: Some HD videos will throw an exception, if this happens, reduce video quality*

*For Cab Lists go [here](https://github.com/empyreal96/WPCabLinks.db)* 


## Screens

![](Images/shot01.png)
![](Images/shot02.png)
![](Images/shot03.png)


## Requirements

-  Windows 10 Mobile Build 14393+

- Windows 10 Desktop Build 14393+



## Credits and Open Source Used

- https://github.com/Empyreal96/Easy-Fetch-UWP Empyreal96's Easy-Fetch-UWP (Original project)
- Thanks to [@BAstifan](https://github.com/basharast) for help with getting the Device Portal Wrapper, FFU Downloader and StoreLib working and providing some of the info classes used.
- [WindowsDevicePortalWrapper](https://github.com/Microsoft/WindowsDevicePortalWrapper) sample from Microsoft to connect to Device Portal securely.
- Device Path info is using parts of [UWP-SystemInfoCollector](https://github.com/validvoid/UWP-SystemInfoCollector)
- [SoReFetch](https://github.com/gus33000/SoReFetch)/[WPInternals](https://github.com/ReneLergner/WPinternals) for their original "LumiaDownloadModel.cs" class
- [UWP Packages Getter](https://github.com/colinkiama/UWPPackagesGetter) for Installed Packages listing
- [StoreLib](https://github.com/StoreDev/StoreLib) for the original lib to connect to MS Servers
- [libvideo](https://github.com/omansak/libvideo) for the basic YT download functionallity
- [SharpCompressUWP](https://github.com/basharast/SharpCompressUWP) an excellent fork by @basharast to help extract and compress archives
 

## ..
As is. No support. RnD only. DIY. 

## .
[m][e] 2024
