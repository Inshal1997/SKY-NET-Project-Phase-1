#region Copyright

/*******************************************************************************
 Copyright(c) 2008 - 2009 Advanced Micro Devices, Inc. All Rights Reserved.
 Copyright (c) 2002 - 2006  ATI Technologies Inc. All Rights Reserved.
 
 THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
 ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDED BUT NOT LIMITED TO
 THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A 
 PARTICULAR PURPOSE.
 
 File:        ADL.cs
 
 Purpose:     Implements ADL interface 
 
 Description: Implements some of the methods defined in ADL interface.
              
 ********************************************************************************/

#endregion Copyright

#region Using

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using FARPROC = System.IntPtr;
using HMODULE = System.IntPtr;

#endregion Using

#region ATI.ADL

namespace ATI.ADL
{
    #region Export Delegates
    /// <summary> ADL Memory allocation function allows ADL to callback for memory allocation</summary>
    /// <param name="size">input size</param>
    /// <returns> retrun ADL Error Code</returns>
    internal delegate IntPtr ADL_Main_Memory_Alloc(int size);
    internal delegate IntPtr ADL_MAIN_MALLOC_CALLBACK(int size);
    internal delegate IntPtr ADL_CONTEXT_HANDLE();

    // ///// <summary> ADL Create Function to create ADL Data</summary>
    /// <param name="callback">Call back functin pointer which is ised to allocate memeory </param>
    /// <param name="enumConnectedAdapters">If it is 1, then ADL will only retuen the physical exist adapters </param>
    ///// <returns> retrun ADL Error Code</returns>
    internal delegate int ADL_Main_Control_Create(ADL_Main_Memory_Alloc callback, int enumConnectedAdapters);

    /// <summary> ADL Destroy Function to free up ADL Data</summary>
    /// <returns> retrun ADL Error Code</returns>
    internal delegate int ADL_Main_Control_Destroy();

    /// <summary> ADL Function to get the number of adapters</summary>
    /// <param name="numAdapters">return number of adapters</param>
    /// <returns> retrun ADL Error Code</returns>
    internal delegate int ADL_Adapter_NumberOfAdapters_Get(ref int numAdapters);

    /// <summary> ADL Function to get the GPU adapter information</summary>
    /// <param name="info">return GPU adapter information</param>
    /// <param name="inputSize">the size of the GPU adapter struct</param>
    /// <returns> retrun ADL Error Code</returns>
    internal delegate int ADL_Adapter_AdapterInfo_Get(IntPtr info, int inputSize);

    /// <summary> Function to determine if the adapter is active or not.</summary>
    /// <remarks>The function is used to check if the adapter associated with iAdapterIndex is active</remarks>  
    /// <param name="adapterIndex"> Adapter Index.</param>
    /// <param name="status"> Status of the adapter. True: Active; False: Dsiabled</param>
    /// <returns>Non zero is successfull</returns> 
    internal delegate int ADL_Adapter_Active_Get(int adapterIndex, ref int status);

    /// <summary>Get display information based on adapter index</summary>
    /// <param name="adapterIndex">Adapter Index</param>
    /// <param name="numDisplays">return the total number of supported displays</param>
    /// <param name="displayInfoArray">return ADLDisplayInfo Array for supported displays' information</param>
    /// <param name="forceDetect">force detect or not</param>
    /// <returns>return ADL Error Code</returns>
    internal delegate int ADL_Display_DisplayInfo_Get(int adapterIndex, ref int numDisplays, out IntPtr displayInfoArray, int forceDetect);
    internal delegate int ADL_Power_Info_Get(ADL_CONTEXT_HANDLE context, int adapterIndex, int value, out IntPtr power);
    internal delegate int ADL_FanSpeed_Info_Get(int adapterIndex, int value, out ADLFanSpeedValue fanspeed);
    internal delegate int ADL_Temp_TempInfo_Get(int adapterIndex, int value, out ADLTemperature temp);
    internal delegate int ADL2_Main_Control_Destroy(ADL_CONTEXT_HANDLE context);
    internal delegate int ADL2_Main_Control_Create(ADL_Main_Memory_Alloc callback, int iEnumConnectedAdapters, out ADL_CONTEXT_HANDLE context);
    internal delegate int ADL_Info_CurrentActivity_Get(int iAdapterIndex, out ADLPMActivity lpActivity);
    internal delegate int adl_get_gpu_pci_id(int iAdapterIndex, int gpuindex, char idbuf, int bufsize);


    #endregion Export Delegates

    #region Export Struct

    #region ADLAdapterInfo
    /// <summary> ADLAdapterInfo Structure</summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct ADLAdapterInfo
    {
        /// <summary>The size of the structure</summary>
        int Size;
        /// <summary> Adapter Index</summary>
        internal int AdapterIndex;
        /// <summary> Adapter UDID</summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = (int)ADL.ADL_MAX_PATH)]
        internal string UDID;
        /// <summary> Adapter Bus Number</summary>
        internal int BusNumber;
        /// <summary> Adapter Driver Number</summary>
        internal int DriverNumber;
        /// <summary> Adapter Function Number</summary>
        internal int FunctionNumber;
        /// <summary> Adapter Vendor ID</summary>
        internal int VendorID;
        /// <summary> Adapter Adapter name</summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = (int)ADL.ADL_MAX_PATH)]
        internal string AdapterName;
        /// <summary> Adapter Display name</summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = (int)ADL.ADL_MAX_PATH)]
        internal string DisplayName;
        /// <summary> Adapter Present status</summary>
        internal int Present;
        /// <summary> Adapter Exist status</summary>
        internal int Exist;
        /// <summary> Adapter Driver Path</summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = (int)ADL.ADL_MAX_PATH)]
        internal string DriverPath;
        /// <summary> Adapter Driver Ext Path</summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = (int)ADL.ADL_MAX_PATH)]
        internal string DriverPathExt;
        /// <summary> Adapter PNP String</summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = (int)ADL.ADL_MAX_PATH)]
        internal string PNPString;
        /// <summary> OS Display Index</summary>
        internal int OSDisplayIndex;
    }

    /// <summary> ADLTemperature</summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct ADLTemperature
    {
        /// Must be set to the size of the structure
        internal int iSize;
        /// Temperature in millidegrees Celsius.
        internal int iTemperature;
    }
    #endregion ADLTemperature

    /// <summary> ADLFanSpeedValue</summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct ADLFanSpeedValue
    {
        /// Must be set to the size of the structure
        internal int iSize;
        /// Possible valies: \ref ADL_DL_FANCTRL_SPEED_TYPE_PERCENT or \ref
        /// ADL_DL_FANCTRL_SPEED_TYPE_RPM
        internal int iSpeedType;
        /// Fan speed value
        internal int iFanSpeed;
        /// The only flag for now is: \ref ADL_DL_FANCTRL_FLAG_USER_DEFINED_SPEED
        internal int iFlags;
    }


    /// <summary> ADLAdapterInfo Array</summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct ADLAdapterInfoArray
    {
        /// <summary> ADLAdapterInfo Array </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)ADL.ADL_MAX_ADAPTERS)]
        internal ADLAdapterInfo[] ADLAdapterInfo;
    }
    #endregion ADLAdapterInfo


    #region ADLDisplayInfo
    /// <summary> ADLDisplayID Structure</summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct ADLDisplayID
    {
        /// <summary> Display Logical Index </summary>
        internal int DisplayLogicalIndex;
        /// <summary> Display Physical Index </summary>
        internal int DisplayPhysicalIndex;
        /// <summary> Adapter Logical Index </summary>
        internal int DisplayLogicalAdapterIndex;
        /// <summary> Adapter Physical Index </summary>
        internal int DisplayPhysicalAdapterIndex;
    }

    /// <summary> ADLDisplayInfo Structure</summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct ADLPMActivity
    {
        /// Must be set to the size of the structure
        internal int iSize;
        /// Current engine clock or core clock
        internal int iEngineClock;
        /// Current memory clock.
        internal int iMemoryClock;
        /// Current core voltage.
        internal int iVddc;
        /// GPU utilization.
        internal int iActivityPercent;
        /// Performance level index.
        internal int iCurrentPerformanceLevel;
        /// Current PCIE bus speed.
        internal int iCurrentBusSpeed;
        /// Number of PCIE bus lanes.
        internal int iCurrentBusLanes;
        /// Maximum number of PCIE bus lanes.
        internal int iMaximumBusLanes;
        /// Reserved for future purposes.
        internal int iReserved;
    }

    /// <summary> ADLDisplayInfo Structure</summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct AdapterInfo
    {
        /// \ALL_STRUCT_MEM

        /// Size of the structure.
        internal int iSize;
        /// The ADL index handle. One GPU may be associated with one or two index handles
        internal int iAdapterIndex;
        /// The unique device ID associated with this adapter.
       // internal char strUDID[ADL_MAX_PATH];
        /// The BUS number associated with this adapter.
        internal int iBusNumber;
        /// The driver number associated with this adapter.
        internal int iDeviceNumber;
        /// The function number.
        internal int iFunctionNumber;
        /// The vendor ID associated with this adapter.
        internal int iVendorID;
        /// Adapter name.
       // internal char strAdapterName[ADL_MAX_PATH];
        /// Display name. For example, "\\Display0" for Windows or ":0:0" for Linux.
       // internal char strDisplayName[ADL_MAX_PATH];
        /// Present or not; 1 if present and 0 if not present.It the logical adapter is present, the
        /// display name such as \\.\Display1 can be found from OS
        internal int iPresent;
    }

    /*/// <summary>ADLODParameters Structure</summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct ADLODParameters
    {
        /// Must be set to the size of the structure
        internal int iSize;
        /// Number of standard performance states.
        internal int iNumberOfPerformanceLevels;
        /// Indicates whether the GPU is capable to measure its activity.
        internal int iActivityReportingSupported;
        /// Indicates whether the GPU supports discrete performance levels or performance range.
        internal int iDiscretePerformanceLevels;
        /// Reserved for future use.
        internal int iReserved;
        /// Engine clock range.
       *//* ADLODParameterRange sEngineClock;
        /// Memory clock range.
        ADLODParameterRange sMemoryClock;
        /// Core voltage range.
        ADLODParameterRange sVddc;*//*
    }*/


    /// <summary> ADLDisplayInfo Structure</summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct ADLDisplayInfo
    {
        /// <summary> Display Index </summary>
        internal ADLDisplayID DisplayID;
        /// <summary> Display Controller Index </summary>
        internal int DisplayControllerIndex;
        /// <summary> Display Name </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = (int)ADL.ADL_MAX_PATH)]
        internal string DisplayName;
        /// <summary> Display Manufacturer Name </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = (int)ADL.ADL_MAX_PATH)]
        internal string DisplayManufacturerName;
        /// <summary> Display Type : < The Display type. CRT, TV,CV,DFP are some of display types,</summary>
        internal int DisplayType;
        /// <summary> Display output type </summary>
        internal int DisplayOutputType;
        /// <summary> Connector type</summary>
        internal int DisplayConnector;
        ///<summary> Indicating the display info bits' mask.<summary>
        internal int DisplayInfoMask;
        ///<summary> Indicating the display info value.<summary>
        internal int DisplayInfoValue;
    }
    #endregion ADLDisplayInfo

    #endregion Export Struct

    #region ADL Class
    /// <summary> ADL Class</summary>
    class ADL
    {
        #region Internal Constant
        /// <summary> Define the maximum path</summary>
        internal const int ADL_MAX_PATH = 256;
        /// <summary> Define the maximum adapters</summary>
        internal const int ADL_MAX_ADAPTERS = 40 /* 150 */;
        /// <summary> Define the maximum displays</summary>
        internal const int ADL_MAX_DISPLAYS = 40 /* 150 */;
        /// <summary> Define the maximum device name length</summary>
        internal const int ADL_MAX_DEVICENAME = 32;
        /// <summary> Define the successful</summary>
        internal const int ADL_SUCCESS = 0;
        /// <summary> Define the failure</summary>
        internal const int ADL_FAIL = -1;
        /// <summary> Define the driver ok</summary>
        internal const int ADL_DRIVER_OK = 0;
        /// <summary> Maximum number of GL-Sync ports on the GL-Sync module </summary>
        internal const int ADL_MAX_GLSYNC_PORTS = 8;
        /// <summary> Maximum number of GL-Sync ports on the GL-Sync module </summary>
        internal const int ADL_MAX_GLSYNC_PORT_LEDS = 8;
        /// <summary> Maximum number of ADLMOdes for the adapter </summary>
        internal const int ADL_MAX_NUM_DISPLAYMODES = 1024;

        #endregion Internal Constant

        #region Class ADLImport
        /// <summary> ADLImport class</summary>
        private static class ADLImport
        {
            #region Internal Constant
            /// <summary> Atiadlxx_FileName </summary>
            internal const string Atiadlxx_FileName = "atiadlxx.dll";
            /// <summary> Kernel32_FileName </summary>
            internal const string Kernel32_FileName = "kernel32.dll";
            #endregion Internal Constant

            #region DLLImport
            [DllImport(Kernel32_FileName)]
            internal static extern HMODULE GetModuleHandle(string moduleName);

            [DllImport(Atiadlxx_FileName)]
            internal static extern int ADL_Main_Control_Create(ADL_Main_Memory_Alloc callback, int enumConnectedAdapters);

            [DllImport(Atiadlxx_FileName)]
            internal static extern int ADL_Main_Control_Destroy();

            [DllImport(Atiadlxx_FileName)]
            internal static extern int ADL2_Main_Control_Create(ADL_Main_Memory_Alloc callback, int iEnumConnectedAdapters, out ADL_CONTEXT_HANDLE context);

            [DllImport(Atiadlxx_FileName)]
            internal static extern int ADL2_Main_Control_Destroy();

            [DllImport(Atiadlxx_FileName)]
            internal static extern int ADL_Main_Control_IsFunctionValid(HMODULE module, string procName);

            [DllImport(Atiadlxx_FileName)]
            internal static extern FARPROC ADL_Main_Control_GetProcAddress(HMODULE module, string procName);

            [DllImport(Atiadlxx_FileName)]
            internal static extern int ADL_Adapter_NumberOfAdapters_Get(ref int numAdapters);

            [DllImport(Atiadlxx_FileName)]
            internal static extern int ADL_Adapter_AdapterInfo_Get(IntPtr info, int inputSize);

            [DllImport(Atiadlxx_FileName)]
            internal static extern int ADL_Adapter_Active_Get(int adapterIndex, ref int status);

            [DllImport(Atiadlxx_FileName)]
            internal static extern int ADL_Display_DisplayInfo_Get(int adapterIndex, ref int numDisplays, out IntPtr displayInfoArray, int forceDetect);
            [DllImport(Atiadlxx_FileName)]
            internal static extern int ADL2_Overdrive6_CurrentPower_Get(ADL_CONTEXT_HANDLE context, int adapterIndex, int value, out IntPtr power);

            [DllImport(Atiadlxx_FileName)]
            internal static extern int ADL_Overdrive5_FanSpeed_Get(int adapterIndex, int value, out ADLFanSpeedValue fanspeed);

            [DllImport(Atiadlxx_FileName)]
            internal static extern int ADL_Overdrive5_Temperature_Get(int adapterIndex, int value, out ADLTemperature temp);

            [DllImport(Atiadlxx_FileName)]
            internal static extern int ADL_Overdrive5_CurrentActivity_Get(int iAdapterIndex, out ADLPMActivity lpActivity);

            [DllImport(Atiadlxx_FileName)]
            internal static extern int adl_get_gpu_pci_id(int iAdapterIndex, int gpuindex, char idbuf, int bufsize);

            #endregion DLLImport


        }
        #endregion Class ADLImport

        #region Class ADLCheckLibrary
        /// <summary> ADLCheckLibrary class</summary>
        private class ADLCheckLibrary
        {
            #region Private Members
            private HMODULE ADLLibrary = System.IntPtr.Zero;
            #endregion Private Members

            #region Static Members
            /// <summary> new a private instance</summary>
            private static ADLCheckLibrary ADLCheckLibrary_ = new ADLCheckLibrary();
            #endregion Static Members

            #region Constructor
            /// <summary> Constructor</summary>
            private ADLCheckLibrary()
            {
                try
                {
                    if (1 == ADLImport.ADL_Main_Control_IsFunctionValid(IntPtr.Zero, "ADL_Main_Control_Create"))
                    {
                        ADLLibrary = ADLImport.GetModuleHandle(ADLImport.Atiadlxx_FileName);
                    }
                }
                catch (DllNotFoundException) { }
                catch (EntryPointNotFoundException) { }
                catch (Exception) { }
            }
            #endregion Constructor

            #region Destructor
            /// <summary> Destructor to force calling ADL Destroy function before free up the ADL library</summary>
            ~ADLCheckLibrary()
            {
                if (System.IntPtr.Zero != ADLCheckLibrary_.ADLLibrary)
                {
                    ADLImport.ADL_Main_Control_Destroy();
                }
            }
            #endregion Destructor

            #region Static IsFunctionValid
            /// <summary> Check the import function to see it exists or not</summary>
            /// <param name="functionName"> function name</param>
            /// <returns>return true, if function exists</returns>
            internal static bool IsFunctionValid(string functionName)
            {
                bool result = false;
                if (System.IntPtr.Zero != ADLCheckLibrary_.ADLLibrary)
                {
                    if (1 == ADLImport.ADL_Main_Control_IsFunctionValid(ADLCheckLibrary_.ADLLibrary, functionName))
                    {
                        result = true;
                    }
                }
                return result;
            }
            #endregion Static IsFunctionValid


            //ADLODParameters overdriveParameters = null ;
            //overdriveParameters Size= sizeof (ADLODParameters);

            //if (ADL_OK != ADL_Overdrive5_ODParameters_Get(adapterId, overdriveParameters))
            //{
            //        Console.WriteLine("Failed to get overdrive parameters\n");
            //        return 0;
            //}

            //#region Static GetProcAddress
            ///// <summary> Get the unmanaged function pointer </summary>
            ///// <param name="functionName"> function name</param>
            ///// <returns>return function pointer, if function exists</returns>
            //internal static FARPROC GetProcAddress(string functionName)
            //{
            //    FARPROC result = System.IntPtr.Zero;
            //    if (System.IntPtr.Zero != ADLCheckLibrary_.ADLLibrary)
            //    {
            //        result = ADLImport.ADL_Main_Control_GetProcAddress(ADLCheckLibrary_.ADLLibrary, functionName);
            //    }
            //    return result;
            //}
            //#endregion Static GetProcAddress
        }
        #endregion Class ADLCheckLibrary

        #region Export Functions



        #region ADL_Main_Memory_Alloc
        /// <summary> Build in memory allocation function</summary>
        internal static ADL_Main_Memory_Alloc ADL_Main_Memory_Alloc = ADL_Main_Memory_Alloc_;
        /// <summary> Build in memory allocation function</summary>
        /// <param name="size">input size</param>
        /// <returns>return the memory buffer</returns>
        private static IntPtr ADL_Main_Memory_Alloc_(int size)
        {
            IntPtr result = Marshal.AllocCoTaskMem(size);
            return result;
        }
        #endregion ADL2_Main_Memory_Alloc

        #region ADL_Main_Control_Create
        /// <summary> ADL_Main_Control_Create Delegates</summary>
        internal static ADL_Main_Control_Create ADL_Main_Control_Create
        {
            get
            {
                if (!ADL_Main_Control_Create_Check && null == ADL_Main_Control_Create_)
                {
                    ADL_Main_Control_Create_Check = true;
                    if (ADLCheckLibrary.IsFunctionValid("ADL_Main_Control_Create"))
                    {
                        ADL_Main_Control_Create_ = ADLImport.ADL_Main_Control_Create;
                    }
                }
                return ADL_Main_Control_Create_;
            }
        }
        /// <summary> Private Delegate</summary>
        private static ADL_Main_Control_Create ADL_Main_Control_Create_ = null;
        /// <summary> check flag to indicate the delegate has been checked</summary>
        private static bool ADL_Main_Control_Create_Check = false;
        #endregion ADL_Main_Control_Create

        #region ADL2_Main_Control_Create
        /// <summary> ADL2_Main_Control_Create Delegates</summary>
        internal static ADL2_Main_Control_Create ADL2_Main_Control_Create
        {
            get
            {
                if (!ADL2_Main_Control_Create_Check && null == ADL2_Main_Control_Create_)
                {
                    ADL2_Main_Control_Create_Check = true;
                    if (ADLCheckLibrary.IsFunctionValid("ADL2_Main_Control_Create"))
                    {
                        ADL2_Main_Control_Create_ = ADLImport.ADL2_Main_Control_Create;
                    }
                }
                return ADL2_Main_Control_Create_;
            }
        }
        /// <summary> Private Delegate</summary>
        private static ADL2_Main_Control_Create ADL2_Main_Control_Create_ = null;
        /// <summary> check flag to indicate the delegate has been checked</summary>
        private static bool ADL2_Main_Control_Create_Check = false;
        #endregion ADL2_Main_Control_Create

        #region ADL_Main_Control_Destroy
        /// <summary> ADL_Main_Control_Destroy Delegates</summary>
        internal static ADL_Main_Control_Destroy ADL_Main_Control_Destroy
        {
            get
            {
                if (!ADL_Main_Control_Destroy_Check && null == ADL_Main_Control_Destroy_)
                {
                    ADL_Main_Control_Destroy_Check = true;
                    if (ADLCheckLibrary.IsFunctionValid("ADL_Main_Control_Destroy"))
                    {
                        ADL_Main_Control_Destroy_ = ADLImport.ADL_Main_Control_Destroy;
                    }
                }
                return ADL_Main_Control_Destroy_;
            }
        }
        /// <summary> Private Delegate</summary>
        private static ADL_Main_Control_Destroy ADL_Main_Control_Destroy_ = null;
        /// <summary> check flag to indicate the delegate has been checked</summary>
        private static bool ADL_Main_Control_Destroy_Check = false;
        #endregion ADL_Main_Control_Destroy

        #region ADL2_Main_Control_Destroy
        /// <summary> ADL_Main_Control_Destroy Delegates</summary>
        internal static ADL_Main_Control_Destroy ADL2_Main_Control_Destroy
        {
            get
            {
                if (!ADL2_Main_Control_Destroy_Check && null == ADL2_Main_Control_Destroy_)
                {
                    ADL2_Main_Control_Destroy_Check = true;
                    if (ADLCheckLibrary.IsFunctionValid("ADL2_Main_Control_Destroy"))
                    {
                        ADL2_Main_Control_Destroy_ = ADLImport.ADL2_Main_Control_Destroy;
                    }
                }
                return ADL2_Main_Control_Destroy_;
            }
        }
        /// <summary> Private Delegate</summary>
        private static ADL_Main_Control_Destroy ADL2_Main_Control_Destroy_ = null;
        /// <summary> check flag to indicate the delegate has been checked</summary>
        private static bool ADL2_Main_Control_Destroy_Check = false;
        #endregion ADL_Main_Control_Destroy

        #region ADL_Adapter_NumberOfAdapters_Get
        /// <summary> ADL_Adapter_NumberOfAdapters_Get Delegates</summary>
        internal static ADL_Adapter_NumberOfAdapters_Get ADL_Adapter_NumberOfAdapters_Get
        {
            get
            {
                if (!ADL_Adapter_NumberOfAdapters_Get_Check && null == ADL_Adapter_NumberOfAdapters_Get_)
                {
                    ADL_Adapter_NumberOfAdapters_Get_Check = true;
                    if (ADLCheckLibrary.IsFunctionValid("ADL_Adapter_NumberOfAdapters_Get"))
                    {
                        ADL_Adapter_NumberOfAdapters_Get_ = ADLImport.ADL_Adapter_NumberOfAdapters_Get;
                    }
                }
                return ADL_Adapter_NumberOfAdapters_Get_;
            }
        }
        /// <summary> Private Delegate</summary>
        private static ADL_Adapter_NumberOfAdapters_Get ADL_Adapter_NumberOfAdapters_Get_ = null;
        /// <summary> check flag to indicate the delegate has been checked</summary>
        private static bool ADL_Adapter_NumberOfAdapters_Get_Check = false;
        #endregion ADL_Adapter_NumberOfAdapters_Get

        #region ADL_Adapter_AdapterInfo_Get
        /// <summary> ADL_Adapter_AdapterInfo_Get Delegates</summary>
        internal static ADL_Adapter_AdapterInfo_Get ADL_Adapter_AdapterInfo_Get
        {
            get
            {
                if (!ADL_Adapter_AdapterInfo_Get_Check && null == ADL_Adapter_AdapterInfo_Get_)
                {
                    ADL_Adapter_AdapterInfo_Get_Check = true;
                    if (ADLCheckLibrary.IsFunctionValid("ADL_Adapter_AdapterInfo_Get"))
                    {
                        ADL_Adapter_AdapterInfo_Get_ = ADLImport.ADL_Adapter_AdapterInfo_Get;
                    }
                }
                return ADL_Adapter_AdapterInfo_Get_;
            }
        }
        /// <summary> Private Delegate</summary>
        private static ADL_Adapter_AdapterInfo_Get ADL_Adapter_AdapterInfo_Get_ = null;
        /// <summary> check flag to indicate the delegate has been checked</summary>
        private static bool ADL_Adapter_AdapterInfo_Get_Check = false;
        #endregion ADL_Adapter_AdapterInfo_Get

        #region ADL_Adapter_Active_Get
        /// <summary> ADL_Adapter_Active_Get Delegates</summary>
        internal static ADL_Adapter_Active_Get ADL_Adapter_Active_Get
        {
            get
            {
                if (!ADL_Adapter_Active_Get_Check && null == ADL_Adapter_Active_Get_)
                {
                    ADL_Adapter_Active_Get_Check = true;
                    if (ADLCheckLibrary.IsFunctionValid("ADL_Adapter_Active_Get"))
                    {
                        ADL_Adapter_Active_Get_ = ADLImport.ADL_Adapter_Active_Get;
                    }
                }
                return ADL_Adapter_Active_Get_;
            }
        }
        /// <summary> Private Delegate</summary>
        private static ADL_Adapter_Active_Get ADL_Adapter_Active_Get_ = null;
        /// <summary> check flag to indicate the delegate has been checked</summary>
        private static bool ADL_Adapter_Active_Get_Check = false;
        #endregion ADL_Adapter_Active_Get


        private static ADL_Power_Info_Get ADL_Power_Info_Get_ = null;
        private static bool ADL_Power_Usage_Get_Check = false;
        internal static ADL_Power_Info_Get ADL_Power_Info_Get
        {
            get
            {
                if (!ADL_Power_Usage_Get_Check && null == ADL_Power_Info_Get_)
                {
                    // ADL_Display_DisplayInfo_Get_Check = true;
                    if (ADLCheckLibrary.IsFunctionValid("ADL2_Overdrive6_CurrentPower_Get"))
                    {
                        ADL_Power_Info_Get_ = ADLImport.ADL2_Overdrive6_CurrentPower_Get;
                    }
                }
                return ADL_Power_Info_Get_;
            }
        }
        internal static ADL_CONTEXT_HANDLE context = null;
        #endregion Export Functions


        private static ADL_FanSpeed_Info_Get ADL_FanSpeed_Info_Get_ = null;
        private static bool ADL_FanSpeed_Get_Check = false;
        internal static ADL_FanSpeed_Info_Get ADL_FanSpeed_Info_Get
        {
            get
            {
                if (!ADL_FanSpeed_Get_Check && null == ADL_FanSpeed_Info_Get_)
                {
                    // ADL_Display_DisplayInfo_Get_Check = true;
                    if (ADLCheckLibrary.IsFunctionValid("ADL_Overdrive5_FanSpeed_Get"))
                    {
                        ADL_FanSpeed_Info_Get_ = ADLImport.ADL_Overdrive5_FanSpeed_Get;
                    }
                }
                return ADL_FanSpeed_Info_Get_;
            }
        }


        #region ADL_Temp_TempInfo_Get
        /// <summary> ADL_Temp_TempInfo_Get Delegates</summary>
        internal static ADL_Temp_TempInfo_Get ADL_Temp_TempInfo_Get
        {
            get
            {
                if (!ADL_Temp_TempInfo_Get_Check && null == ADL_Temp_TempInfo_Get_)
                {
                    ADL_Temp_TempInfo_Get_Check = true;
                    if (ADLCheckLibrary.IsFunctionValid("ADL_Overdrive5_Temperature_Get"))
                    {
                        ADL_Temp_TempInfo_Get_ = ADLImport.ADL_Overdrive5_Temperature_Get;
                    }
                }
                return ADL_Temp_TempInfo_Get_;
            }
        }
        /// <summary> Private Delegate</summary>      
        private static ADL_Temp_TempInfo_Get ADL_Temp_TempInfo_Get_ = null;
        /// <summary> check flag to indicate the delegate has been checked</summary>
        private static bool ADL_Temp_TempInfo_Get_Check = false;

        #endregion ADL_Temp_TempInfo_Get


        #region ADL_Info_CurrentActivity_Get
        /// <summary> ADL_Temp_TempInfo_Get Delegates</summary> 
        internal static ADL_Info_CurrentActivity_Get ADL_Info_CurrentActivity_Get
        {
            get
            {
                if (!ADL_Info_CurrentActivity_Get_Check && null == ADL_Info_CurrentActivity_Get_)
                {
                    ADL_Info_CurrentActivity_Get_Check = true;
                    if (ADLCheckLibrary.IsFunctionValid("ADL_Overdrive5_CurrentActivity_Get"))
                    {
                        ADL_Info_CurrentActivity_Get_ = ADLImport.ADL_Overdrive5_CurrentActivity_Get;
                    }
                }
                return ADL_Info_CurrentActivity_Get_;
            }
        }
        /// <summary> Private Delegate</summary>      
        private static ADL_Info_CurrentActivity_Get ADL_Info_CurrentActivity_Get_ = null;
        /// <summary> check flag to indicate the delegate has been checked</summary>
        private static bool ADL_Info_CurrentActivity_Get_Check = false;

        #endregion ADL_Info_CurrentActivity_Get

        #region adl_get_gpu_pci_id
        /// <summary> ADL_Temp_TempInfo_Get Delegates</summary>
        internal static adl_get_gpu_pci_id adl_get_gpu_pci_id

        {
            get
            {
                if (!adl_get_gpu_pci_id_Check && null == adl_get_gpu_pci_id_)
                {
                    adl_get_gpu_pci_id_Check = true;
                    if (ADLCheckLibrary.IsFunctionValid("adl_get_gpu_pci_id"))
                    {
                        adl_get_gpu_pci_id_ = ADLImport.adl_get_gpu_pci_id;
                    }
                }
                return adl_get_gpu_pci_id_;
            }
        }
        /// <summary> Private Delegate</summary>      
        private static adl_get_gpu_pci_id adl_get_gpu_pci_id_ = null;
        /// <summary> check flag to indicate the delegate has been checked</summary>
        private static bool adl_get_gpu_pci_id_Check = false;

        /* public uint[] Initialize_ADL_Data(int[] miner_slot)
         {

             int Pcislot = 0;
             uint[] pci_index = new uint[miner_slot.Length];
             for (uint i = 0; i < data.Header.GpuEntryCount; i++)
             {

                  memclock = activity.iMemoryClock / 1000; 
                  coreclock = activity.iEngineClock /1000;
                 if (memclock != null && coreclock != null)
                 {
                     Char delimiter = '&';
                     String[] GPUid = data.GpuEntries[i].GpuId.Split(delimiter);
                     Char delim = '_';
                     String[] MSI_Pcislot = GPUid[4].Split(delim);
                     Pcislot = Convert.ToInt32(MSI_Pcislot[1], 16);
                     // Console.WriteLine(MSI_Pcislot[1]);
                     int len = 0;
                     while (len < miner_slot.Length)
                     {
                         if (Pcislot == miner_slot[len] && miner_slot[len] != 0)
                         {
                             msi_index[len] = i;
                             break;
                         }
                         len++;
                     }
                 }
             }
             return msi_index;

         }*/

        #endregion adl_get_gpu_pci_id

        // internal static ADL_CONTEXT_HANDLE context = null;
        #endregion Export Functions



    }


    // #endregion ADL Class
}

//#endregion ATI.ADL