// <auto-generated/>

namespace SharpDX.XInput
{
    /// <summary>
    /// Functions
    /// </summary>
    static partial class XInput
    {
        /// <summary>
        /// <p>Retrieves the current state of the specified controller.</p>
        /// </summary>
        /// <param name = "dwUserIndex"><dd> <p>Index of the user's controller. Can be a value from 0 to 3. For information about how this value is determined and how the value maps to indicators on the controller, see Multiple Controllers.</p> </dd></param>
        /// <param name = "stateRef"><dd> <p>Pointer to an <strong><see cref = "SharpDX.XInput.State"/></strong> structure that receives the current state of the controller.</p> </dd></param>
        /// <returns><p>If the function succeeds, the return value is <strong>ERROR_SUCCESS</strong>.</p><p>If the controller is not connected, the return value is <strong>ERROR_DEVICE_NOT_CONNECTED</strong>.</p><p>If the function fails, the return value is an error code defined in Winerror.h. The function does not use <strong>SetLastError</strong> to set the calling thread's last-error code.</p></returns>
        /// <remarks>
        /// <p>When <strong>XInputGetState</strong> is used to retrieve controller data, the left and right triggers are each reported separately. For legacy reasons, when DirectInput retrieves controller data, the two triggers share the same axis. The legacy behavior is noticeable in the current Game Device Control Panel, which uses DirectInput for controller state.</p>
        /// </remarks>
        /// <doc-id>microsoft.directx_sdk.reference.xinputgetstate</doc-id>
        /// <unmanaged>DWORD XInputGetState([In] DWORD dwUserIndex,[Out] XINPUT_STATE* pState)</unmanaged>
        /// <unmanaged-short>XInputGetState</unmanaged-short>
        public static unsafe System.Int32 XInputGetState(System.Int32 dwUserIndex, out SharpDX.XInput.State stateRef)
        {
            stateRef = default (SharpDX.XInput.State);
            System.Int32 __result__;
            fixed (void *stateRef_ = &stateRef)
                __result__ = XInputGetState_(dwUserIndex, stateRef_);
            return __result__;
        }

        [System.Runtime.InteropServices.DllImportAttribute("xinput1_4.dll", EntryPoint = "XInputGetState", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private unsafe static extern int XInputGetState_(int param0, void *param1);
        /// <summary>
        /// <p>Sends data to a connected controller. This function is used to activate the vibration function of a controller.</p>
        /// </summary>
        /// <param name = "dwUserIndex"><dd> <p>Index of the user's controller. Can be a value from 0 to 3. For information about how this value is determined and how the value maps to indicators on the controller, see Multiple Controllers.</p> </dd></param>
        /// <param name = "vibrationRef"><dd> <p>Pointer to an <strong><see cref = "SharpDX.XInput.Vibration"/></strong> structure containing the vibration information to send to the controller.</p> </dd></param>
        /// <returns><p>If the function succeeds, the return value is <strong>ERROR_SUCCESS</strong>.</p><p>If the controller is not connected, the return value is <strong>ERROR_DEVICE_NOT_CONNECTED</strong>.</p><p>If the function fails, the return value is an error code defined in WinError.h. The function does not use <em>SetLastError</em> to set the calling thread's last-error code.</p></returns>
        /// <doc-id>microsoft.directx_sdk.reference.xinputsetstate</doc-id>
        /// <unmanaged>DWORD XInputSetState([In] DWORD dwUserIndex,[In] XINPUT_VIBRATION* pVibration)</unmanaged>
        /// <unmanaged-short>XInputSetState</unmanaged-short>
        public static unsafe System.Int32 XInputSetState(System.Int32 dwUserIndex, ref SharpDX.XInput.Vibration vibrationRef)
        {
            SharpDX.XInput.Vibration.__Native vibrationRef_ = default (SharpDX.XInput.Vibration.__Native);
            System.Int32 __result__;
            vibrationRef.__MarshalTo(ref vibrationRef_);
            __result__ = XInputSetState_(dwUserIndex, &vibrationRef_);
            vibrationRef.__MarshalFree(ref vibrationRef_);
            return __result__;
        }

        [System.Runtime.InteropServices.DllImportAttribute("xinput1_4.dll", EntryPoint = "XInputSetState", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private unsafe static extern int XInputSetState_(int param0, void *param1);
        /// <summary>
        /// <p>Retrieves the capabilities and features of a connected controller.</p>
        /// </summary>
        /// <param name = "dwUserIndex"><dd> <p>Index of the user's controller. Can be a value in the range 0?3. For information about how this value is determined and how the value maps to indicators on the controller, see Multiple Controllers. </p> </dd></param>
        /// <param name = "dwFlags"><dd> <p>Input flags that identify the controller type. If this value is 0, then the capabilities of all controllers connected to the system are returned. Currently, only one value is supported:</p> <table> <tr><th>Value</th><th>Description</th></tr> <tr><td><strong>XINPUT_FLAG_GAMEPAD</strong></td><td>Limit query to devices of Xbox 360 Controller type.</td></tr> </table> <p>?</p> <p>Any value of <em>dwflags</em> other than the above or 0 is illegal and will result in an error break when debugging.</p> </dd></param>
        /// <param name = "capabilitiesRef"><dd> <p>Pointer to an <strong><see cref = "SharpDX.XInput.Capabilities"/></strong> structure that receives the controller capabilities.</p> </dd></param>
        /// <returns><p>If the function succeeds, the return value is <strong>ERROR_SUCCESS</strong>.</p><p>If the controller is not connected, the return value is <strong>ERROR_DEVICE_NOT_CONNECTED</strong>.</p><p>If the function fails, the return value is an error code defined in WinError.h. The function does not use <em>SetLastError</em> to set the calling thread's last-error code.</p></returns>
        /// <remarks>
        /// <strong>Note</strong>??The legacy XINPUT 9.1.0 version (included in Windows?Vista and later) always returned a fixed set of capabilities regardless of attached device.?
        /// </remarks>
        /// <doc-id>microsoft.directx_sdk.reference.xinputgetcapabilities</doc-id>
        /// <unmanaged>DWORD XInputGetCapabilities([In] DWORD dwUserIndex,[In] DWORD dwFlags,[Out] XINPUT_CAPABILITIES* pCapabilities)</unmanaged>
        /// <unmanaged-short>XInputGetCapabilities</unmanaged-short>
        public static unsafe System.Int32 XInputGetCapabilities(System.Int32 dwUserIndex, SharpDX.XInput.DeviceQueryType dwFlags, out SharpDX.XInput.Capabilities capabilitiesRef)
        {
            SharpDX.XInput.Capabilities.__Native capabilitiesRef_ = default (SharpDX.XInput.Capabilities.__Native);
            capabilitiesRef = default (SharpDX.XInput.Capabilities);
            System.Int32 __result__;
            __result__ = XInputGetCapabilities_(dwUserIndex, unchecked ((System.Int32)dwFlags), &capabilitiesRef_);
            capabilitiesRef.__MarshalFrom(ref capabilitiesRef_);
            return __result__;
        }

        [System.Runtime.InteropServices.DllImportAttribute("xinput1_4.dll", EntryPoint = "XInputGetCapabilities", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private unsafe static extern int XInputGetCapabilities_(int param0, int param1, void *param2);
        /// <summary>
        /// <p>Sets the reporting state of XInput.</p>
        /// </summary>
        /// <param name = "enable"><dd> <p>If enable is <strong><see cref = "SharpDX.Result.False"/></strong>, XInput will only send neutral data in response to <strong>XInputGetState</strong> (all buttons up, axes centered, and triggers at 0). <strong>XInputSetState</strong> calls will be registered but not sent to the device. Sending any value other than <strong><see cref = "SharpDX.Result.False"/> </strong>will restore reading and writing functionality to normal.</p> </dd></param>
        /// <remarks>
        /// <p>This function is meant to be called when an application gains or loses focus (such as via <strong>WM_ACTIVATEAPP</strong>). Using this function, you will not have to change the XInput query loop in your application as neutral data will always be reported if XInput is disabled.
        /// </p><p>In a controller that supports vibration effects:</p><ul> <li>Passing <strong><see cref = "SharpDX.Result.False"/></strong> will stop any vibration effects currently playing. In this state, calls to <strong>XInputSetState</strong> will be registered, but not passed to the device.</li> <li>Passing <strong>TRUE</strong> will pass the last vibration request (even if it is 0) sent to <strong>XInputSetState</strong> to the device.</li> </ul>
        /// </remarks>
        /// <doc-id>microsoft.directx_sdk.reference.xinputenable</doc-id>
        /// <unmanaged>void XInputEnable([In] BOOL enable)</unmanaged>
        /// <unmanaged-short>XInputEnable</unmanaged-short>
        public static unsafe void XInputEnable(SharpDX.Mathematics.Interop.RawBool enable)
        {
            XInputEnable_(enable);
        }

        [System.Runtime.InteropServices.DllImportAttribute("xinput1_4.dll", EntryPoint = "XInputEnable", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private unsafe static extern void XInputEnable_(SharpDX.Mathematics.Interop.RawBool param0);
        /// <summary>
        /// <p>Retrieves the sound rendering and sound capture audio device IDs that are associated with the headset connected to the specified controller.</p>
        /// </summary>
        /// <param name = "dwUserIndex"><dd> <p> Index of the gamer associated with the device.</p> </dd></param>
        /// <param name = "renderDeviceIdRef"><dd> <p> Windows Core Audio device ID string for render (speakers).</p> </dd></param>
        /// <param name = "renderCountRef"><dd> <p> Size, in wide-chars, of the render device ID string buffer.</p> </dd></param>
        /// <param name = "captureDeviceIdRef"><dd> <p>Windows Core Audio device ID string for capture (microphone).</p> </dd></param>
        /// <param name = "captureCountRef"><dd> <p>Size, in wide-chars, of capture device ID string buffer.</p> </dd></param>
        /// <returns><p>If the function successfully retrieves the device IDs for render and capture, the return code is <strong>ERROR_SUCCESS</strong>.</p><p>If there is no headset connected to the controller, the function will also retrieve <strong>ERROR_SUCCESS</strong> with <strong><c>null</c></strong> as the values for <em>pRenderDeviceId</em> and <em>pCaptureDeviceId</em>.</p><p>If the controller port device is not physically connected, the function will return <strong>ERROR_DEVICE_NOT_CONNECTED</strong>.</p><p>If the function fails, it will return a valid Win32 error code.</p></returns>
        /// <remarks>
        /// <p>Callers must allocate the memory for the buffers passed to <strong>XInputGetAudioDeviceIds</strong>. The resulting strings can be of arbitrary length.</p>
        /// </remarks>
        /// <doc-id>microsoft.directx_sdk.reference.xinputgetaudiodeviceids</doc-id>
        /// <unmanaged>DWORD XInputGetAudioDeviceIds([In] DWORD dwUserIndex,[Out, Buffer, Optional] wchar_t* pRenderDeviceId,[InOut, Optional] unsigned int* pRenderCount,[Out, Buffer, Optional] wchar_t* pCaptureDeviceId,[InOut, Optional] unsigned int* pCaptureCount)</unmanaged>
        /// <unmanaged-short>XInputGetAudioDeviceIds</unmanaged-short>
        public static unsafe System.Int32 XInputGetAudioDeviceIds(System.Int32 dwUserIndex, System.IntPtr renderDeviceIdRef, System.IntPtr renderCountRef, System.IntPtr captureDeviceIdRef, System.IntPtr captureCountRef)
        {
            System.Int32 __result__;
            __result__ = XInputGetAudioDeviceIds_(dwUserIndex, (void *)renderDeviceIdRef, (void *)renderCountRef, (void *)captureDeviceIdRef, (void *)captureCountRef);
            return __result__;
        }

        [System.Runtime.InteropServices.DllImportAttribute("xinput1_4.dll", EntryPoint = "XInputGetAudioDeviceIds", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private unsafe static extern int XInputGetAudioDeviceIds_(int param0, void *param1, void *param2, void *param3, void *param4);
        /// <summary>
        /// <p>Retrieves the battery type and charge status of a wireless controller.</p>
        /// </summary>
        /// <param name = "dwUserIndex"><dd> <p>Index of the signed-in gamer associated with the device. Can be a value in the range 0?XUSER_MAX_COUNT ? 1.</p> </dd></param>
        /// <param name = "devType"><dd> <p>Specifies which device associated with this user index should be queried. Must be <strong>BATTERY_DEVTYPE_GAMEPAD</strong> or <strong>BATTERY_DEVTYPE_HEADSET</strong>.</p> </dd></param>
        /// <param name = "batteryInformationRef"><dd> <p>Pointer to an <strong><see cref = "SharpDX.XInput.BatteryInformation"/></strong> structure that receives the battery information.</p> </dd></param>
        /// <returns><p>If the function succeeds, the return value is <strong>ERROR_SUCCESS</strong>.</p></returns>
        /// <doc-id>microsoft.directx_sdk.reference.xinputgetbatteryinformation</doc-id>
        /// <unmanaged>DWORD XInputGetBatteryInformation([In] DWORD dwUserIndex,[In] unsigned char devType,[Out] XINPUT_BATTERY_INFORMATION* pBatteryInformation)</unmanaged>
        /// <unmanaged-short>XInputGetBatteryInformation</unmanaged-short>
        public static unsafe System.Int32 XInputGetBatteryInformation(System.Int32 dwUserIndex, SharpDX.XInput.BatteryDeviceType devType, out SharpDX.XInput.BatteryInformation batteryInformationRef)
        {
            batteryInformationRef = default (SharpDX.XInput.BatteryInformation);
            System.Int32 __result__;
            fixed (void *batteryInformationRef_ = &batteryInformationRef)
                __result__ = XInputGetBatteryInformation_(dwUserIndex, unchecked ((System.Int32)devType), batteryInformationRef_);
            return __result__;
        }

        [System.Runtime.InteropServices.DllImportAttribute("xinput1_4.dll", EntryPoint = "XInputGetBatteryInformation", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private unsafe static extern int XInputGetBatteryInformation_(int param0, int param1, void *param2);
        /// <summary>
        /// <p>Retrieves a gamepad input event.</p>
        /// </summary>
        /// <param name = "dwUserIndex"><dd> <p>[in] Index of the signed-in gamer associated with the device. Can be a value in the range 0?XUSER_MAX_COUNT ? 1, or XUSER_INDEX_ANY to fetch the next available input event from any user.</p> </dd></param>
        /// <param name = "dwReserved"><dd> <p>[in] Reserved</p> </dd></param>
        /// <param name = "keystrokeRef"><dd> <p>[out] Pointer to an <strong><see cref = "SharpDX.XInput.Keystroke"/></strong> structure that receives an input event.</p> </dd></param>
        /// <returns><p>If the function succeeds, the return value is <strong>ERROR_SUCCESS</strong>.</p><p>If no new keys have been pressed, the return value is <strong>ERROR_EMPTY</strong>.</p><p>If the controller is not connected or the user has not activated it, the return value is <strong>ERROR_DEVICE_NOT_CONNECTED</strong>. See the Remarks section below.</p><p>If the function fails, the return value is an error code defined in Winerror.h. The function does not use <strong>SetLastError</strong> to set the calling thread's last-error code.</p></returns>
        /// <remarks>
        /// <p>Wireless controllers are not considered active upon system startup, and calls to any of the <em>XInput</em> functions before a wireless controller is made active return <strong>ERROR_DEVICE_NOT_CONNECTED</strong>. Game titles must examine the return code and be prepared to handle this condition. Wired controllers are automatically activated when they are inserted. Wireless controllers are activated when the user presses the START or Xbox Guide button to power on the controller.</p>
        /// </remarks>
        /// <doc-id>microsoft.directx_sdk.reference.xinputgetkeystroke</doc-id>
        /// <unmanaged>DWORD XInputGetKeystroke([In] DWORD dwUserIndex,[In] DWORD dwReserved,[Out] XINPUT_KEYSTROKE* pKeystroke)</unmanaged>
        /// <unmanaged-short>XInputGetKeystroke</unmanaged-short>
        public static unsafe System.Int32 XInputGetKeystroke(System.Int32 dwUserIndex, System.Int32 dwReserved, out SharpDX.XInput.Keystroke keystrokeRef)
        {
            keystrokeRef = default (SharpDX.XInput.Keystroke);
            System.Int32 __result__;
            fixed (void *keystrokeRef_ = &keystrokeRef)
                __result__ = XInputGetKeystroke_(dwUserIndex, dwReserved, keystrokeRef_);
            return __result__;
        }

        [System.Runtime.InteropServices.DllImportAttribute("xinput1_4.dll", EntryPoint = "XInputGetKeystroke", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private unsafe static extern int XInputGetKeystroke_(int param0, int param1, void *param2);
    }
}