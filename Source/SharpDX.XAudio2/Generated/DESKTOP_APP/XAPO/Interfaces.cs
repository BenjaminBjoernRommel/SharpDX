// <auto-generated/>

namespace SharpDX.XAPO
{
    [System.Runtime.InteropServices.GuidAttribute("A410B984-9839-4819-A0BE-2856AE6B3ADB")]
    public partial interface AudioProcessor : SharpDX.IUnknown
    {
    }

    [System.Runtime.InteropServices.GuidAttribute("A410B984-9839-4819-A0BE-2856AE6B3ADB")]
    public partial class AudioProcessorNative : SharpDX.ComObject, SharpDX.XAPO.AudioProcessor
    {
        public AudioProcessorNative(System.IntPtr nativePtr): base (nativePtr)
        {
        }

        public static explicit operator AudioProcessorNative(System.IntPtr nativePtr) => nativePtr == System.IntPtr.Zero ? null : new AudioProcessorNative(nativePtr);
        /// <summary>
        /// <p>Returns the registration properties of an XAPO. </p>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.ixapo.ixapo.getregistrationproperties</doc-id>
        /// <unmanaged>GetRegistrationProperties</unmanaged>
        /// <unmanaged-short>GetRegistrationProperties</unmanaged-short>
        public SharpDX.XAPO.RegistrationProperties RegistrationProperties_
        {
            get
            {
                GetRegistrationProperties_(out var __output__);
                return __output__;
            }
        }

        /// <summary>
        /// <p>Returns the registration properties of an XAPO. </p>
        /// </summary>
        /// <param name = "registrationPropertiesOut"><dd> <p> Receives a reference to a <strong><see cref = "SharpDX.XAPO.RegistrationProperties"/></strong> structure containing the registration properties the XAPO was created with; use <strong>XAPOFree</strong> to free the structure. </p> </dd></param>
        /// <returns><p>Returns <see cref = "SharpDX.Result.Ok"/> if successful; returns an error code otherwise.</p></returns>
        /// <doc-id>microsoft.directx_sdk.ixapo.ixapo.getregistrationproperties</doc-id>
        /// <unmanaged>HRESULT IXAPO::GetRegistrationProperties([Out] XAPO_REGISTRATION_PROPERTIES** ppRegistrationProperties)</unmanaged>
        /// <unmanaged-short>IXAPO::GetRegistrationProperties</unmanaged-short>
        internal unsafe void GetRegistrationProperties_(out SharpDX.XAPO.RegistrationProperties registrationPropertiesOut)
        {
            SharpDX.XAPO.RegistrationProperties.__Native registrationPropertiesOut_ = default (SharpDX.XAPO.RegistrationProperties.__Native);
            registrationPropertiesOut = default (SharpDX.XAPO.RegistrationProperties);
            SharpDX.Result __result__;
            __result__ = SharpDX.XAudio2.LocalInterop.CalliStdCallint(this._nativePointer, &registrationPropertiesOut_, (*(void ***)this._nativePointer)[3]);
            registrationPropertiesOut.__MarshalFrom(ref registrationPropertiesOut_);
            __result__.CheckError();
        }

        /// <summary>
        /// <p>Queries if a specific input format is supported for a given output format.</p>
        /// </summary>
        /// <param name = "outputFormatRef"><dd> <p> Output format.</p> </dd></param>
        /// <param name = "requestedInputFormatRef"><dd> <p> Input format to check for being supported.</p> </dd></param>
        /// <param name = "supportedInputFormatOut"><dd> <p> If not <c>null</c>, and the input format is not supported for the given output format, <em>ppSupportedInputFormat</em> returns a reference to the closest input format that is supported. Use <strong>XAPOFree</strong> to free the returned structure. </p> </dd></param>
        /// <returns><p>Returns <see cref = "SharpDX.Result.Ok"/> if the format pair is supported. Returns XAPO_E_FORMAT_UNSUPPORTED if the format pair is not supported.</p></returns>
        /// <remarks>
        /// <p>The <strong>IXAPO::IsOutputFormatSupported</strong> and <strong>IsInputFormatSupported</strong> methods allow an XAPO to indicate which audio formats it is capable of processing. If a requested format is not supported, the XAPO should return the closest format that it does support. The closest format should be determined based on frame rate, bit depth, and channel count, in that order of importance. The behavior of <strong>IsInputFormatSupported</strong> is allowed to change, based on the internal state of the XAPO, but its behavior should remain constant between calls to the <strong>IXAPO::LockForProcess</strong> and <strong>IXAPO::UnlockForProcess</strong> methods. </p>
        /// </remarks>
        /// <doc-id>microsoft.directx_sdk.ixapo.ixapo.isinputformatsupported</doc-id>
        /// <unmanaged>HRESULT IXAPO::IsInputFormatSupported([In] const WAVEFORMATEX* pOutputFormat,[In] const WAVEFORMATEX* pRequestedInputFormat,[Out, Optional] WAVEFORMATEX** ppSupportedInputFormat)</unmanaged>
        /// <unmanaged-short>IXAPO::IsInputFormatSupported</unmanaged-short>
        internal unsafe SharpDX.Result IsInputFormatSupported_(ref SharpDX.Multimedia.WaveFormat outputFormatRef, ref SharpDX.Multimedia.WaveFormat requestedInputFormatRef, out SharpDX.Multimedia.WaveFormat supportedInputFormatOut)
        {
            SharpDX.Multimedia.WaveFormat.__Native outputFormatRef_ = default (SharpDX.Multimedia.WaveFormat.__Native);
            SharpDX.Multimedia.WaveFormat.__Native requestedInputFormatRef_ = default (SharpDX.Multimedia.WaveFormat.__Native);
            SharpDX.Multimedia.WaveFormat.__Native supportedInputFormatOut_ = default (SharpDX.Multimedia.WaveFormat.__Native);
            supportedInputFormatOut = default (SharpDX.Multimedia.WaveFormat);
            SharpDX.Result __result__;
            outputFormatRef.__MarshalTo(ref outputFormatRef_);
            requestedInputFormatRef.__MarshalTo(ref requestedInputFormatRef_);
            __result__ = SharpDX.XAudio2.LocalInterop.CalliStdCallint(this._nativePointer, &outputFormatRef_, &requestedInputFormatRef_, &supportedInputFormatOut_, (*(void ***)this._nativePointer)[4]);
            supportedInputFormatOut.__MarshalFrom(ref supportedInputFormatOut_);
            outputFormatRef.__MarshalFree(ref outputFormatRef_);
            requestedInputFormatRef.__MarshalFree(ref requestedInputFormatRef_);
            return __result__;
        }

        /// <summary>
        /// <p>Queries if a specific output format is supported for a given input format.</p>
        /// </summary>
        /// <param name = "inputFormatRef"><dd> <p>Input format. </p> </dd></param>
        /// <param name = "requestedOutputFormatRef"><dd> <p>Output format to check for being supported.</p> </dd></param>
        /// <param name = "supportedOutputFormatOut"><dd> <p>If not <c>null</c> and the output format is not supported for the given input format, <em>ppSupportedOutputFormat</em> returns a reference to the closest output format that is supported. Use <strong>XAPOFree</strong> to free the returned structure. </p> </dd></param>
        /// <returns><p>Returns <see cref = "SharpDX.Result.Ok"/> if the format pair is supported. Returns XAPO_E_FORMAT_UNSUPPORTED if the format pair is not supported.</p></returns>
        /// <remarks>
        /// <p>The <strong>IXAPO::IsInputFormatSupported</strong> and <strong>IsOutputFormatSupported</strong> methods allow an XAPO to indicate which audio formats it is capable of processing. If a requested format is not supported, the XAPO should return the closest format that it does support. The closest format should be determined based on frame rate, bit depth, and channel count, in that order of importance. The behavior of <strong>IsOutputFormatSupported</strong> is allowed to change, based on the internal state of the XAPO, but its behavior should remain constant between calls to the <strong>IXAPO::LockForProcess</strong> and <strong>IXAPO::UnlockForProcess</strong> methods.</p>
        /// </remarks>
        /// <doc-id>microsoft.directx_sdk.ixapo.ixapo.isoutputformatsupported</doc-id>
        /// <unmanaged>HRESULT IXAPO::IsOutputFormatSupported([In] const WAVEFORMATEX* pInputFormat,[In] const WAVEFORMATEX* pRequestedOutputFormat,[Out, Optional] WAVEFORMATEX** ppSupportedOutputFormat)</unmanaged>
        /// <unmanaged-short>IXAPO::IsOutputFormatSupported</unmanaged-short>
        internal unsafe SharpDX.Result IsOutputFormatSupported_(ref SharpDX.Multimedia.WaveFormat inputFormatRef, ref SharpDX.Multimedia.WaveFormat requestedOutputFormatRef, out SharpDX.Multimedia.WaveFormat supportedOutputFormatOut)
        {
            SharpDX.Multimedia.WaveFormat.__Native inputFormatRef_ = default (SharpDX.Multimedia.WaveFormat.__Native);
            SharpDX.Multimedia.WaveFormat.__Native requestedOutputFormatRef_ = default (SharpDX.Multimedia.WaveFormat.__Native);
            SharpDX.Multimedia.WaveFormat.__Native supportedOutputFormatOut_ = default (SharpDX.Multimedia.WaveFormat.__Native);
            supportedOutputFormatOut = default (SharpDX.Multimedia.WaveFormat);
            SharpDX.Result __result__;
            inputFormatRef.__MarshalTo(ref inputFormatRef_);
            requestedOutputFormatRef.__MarshalTo(ref requestedOutputFormatRef_);
            __result__ = SharpDX.XAudio2.LocalInterop.CalliStdCallint(this._nativePointer, &inputFormatRef_, &requestedOutputFormatRef_, &supportedOutputFormatOut_, (*(void ***)this._nativePointer)[5]);
            supportedOutputFormatOut.__MarshalFrom(ref supportedOutputFormatOut_);
            inputFormatRef.__MarshalFree(ref inputFormatRef_);
            requestedOutputFormatRef.__MarshalFree(ref requestedOutputFormatRef_);
            return __result__;
        }

        /// <summary>
        /// <p>Performs any effect-specific initialization.</p>
        /// </summary>
        /// <param name = "dataRef"><dd> <p> Effect-specific initialization parameters, may be <c>null</c> if <em>DataByteSize</em> is 0.</p> </dd></param>
        /// <param name = "dataByteSize"><dd> <p> Size of <em>pData</em> in bytes, may be 0 if <em>pData</em> is <c>null</c>.</p> </dd></param>
        /// <returns><p>Returns <see cref = "SharpDX.Result.Ok"/> if successful, an error code otherwise.</p></returns>
        /// <remarks>
        /// <p>The contents of <em>pData</em> are defined by a given XAPO. Immutable parameters (constant for the lifetime of the XAPO) should be set in this method. Once initialized, an XAPO cannot be initialized again. An XAPO should be initialized before passing it to XAudio2 as part of an effect chain. </p><strong>Note</strong>??XAudio2 does not call this method, it should be called by the client before passing the XAPO to XAudio2.?
        /// </remarks>
        /// <doc-id>microsoft.directx_sdk.ixapo.ixapo.initialize</doc-id>
        /// <unmanaged>HRESULT IXAPO::Initialize([In, Buffer, Optional] const void* pData,[In] unsigned int DataByteSize)</unmanaged>
        /// <unmanaged-short>IXAPO::Initialize</unmanaged-short>
        internal unsafe void Initialize_(System.IntPtr dataRef, System.Int32 dataByteSize)
        {
            SharpDX.Result __result__;
            __result__ = SharpDX.XAudio2.LocalInterop.CalliStdCallint(this._nativePointer, (void *)dataRef, dataByteSize, (*(void ***)this._nativePointer)[6]);
            __result__.CheckError();
        }

        /// <summary>
        /// <p>Resets variables dependent on frame history.</p>
        /// </summary>
        /// <remarks>
        /// <p>Constant and locked parameters such as the input and output formats remain unchanged. Variables set by <strong>IXAPOParameters::SetParameters</strong> remain unchanged. </p><p>For example, an effect with delay should zero out its delay line during this method, but should not reallocate anything as the XAPO remains locked with a constant input and output configuration. </p><p>XAudio2 only calls this method if the XAPO is locked. </p><p>This method is called from the realtime thread and should not block.
        /// </p>
        /// </remarks>
        /// <doc-id>microsoft.directx_sdk.ixapo.ixapo.reset</doc-id>
        /// <unmanaged>void IXAPO::Reset()</unmanaged>
        /// <unmanaged-short>IXAPO::Reset</unmanaged-short>
        internal unsafe void Reset_()
        {
            SharpDX.XAudio2.LocalInterop.CalliStdCallvoid(this._nativePointer, (*(void ***)this._nativePointer)[7]);
        }

        /// <summary>
        /// <p>Called by XAudio2 to lock the input and output configurations of an XAPO allowing it to do any final initialization before <strong>Process</strong> is called on the realtime thread.</p>
        /// </summary>
        /// <param name = "inputLockedParameterCount">No documentation.</param>
        /// <param name = "inputLockedParametersRef">No documentation.</param>
        /// <param name = "outputLockedParameterCount">No documentation.</param>
        /// <param name = "outputLockedParametersRef">No documentation.</param>
        /// <returns><p>Returns <see cref = "SharpDX.Result.Ok"/> if successful, an error code otherwise.</p></returns>
        /// <remarks>
        /// <p>Once locked, the input and output configuration and any other locked parameters remain constant until <strong>UnLockForProcess</strong> is called. After an XAPO is locked, further calls to <strong>LockForProcess</strong> have no effect until the <strong>UnLockForProcess</strong> function is called. </p><p>An XAPO indicates what specific formats it supports through its implementation of the <strong>IsInputFormatSupported</strong> and <strong>IsOutputFormatSupported</strong> methods. An XAPO should assert the input and output configurations are supported and that any required effect-specific initialization is complete. The <strong>IsInputFormatSupported</strong>, <strong>IsOutputFormatSupported</strong>, and <strong>Initialize</strong> methods should be used as necessary before calling this method. </p><p>Because <strong>Process</strong> is a nonblocking method, all internal memory buffers required for <strong>Process</strong> should be allocated in <strong>LockForProcess</strong>. </p><p> <strong>Process</strong> is never called before <strong>LockForProcess</strong> returns successfully. </p><p><strong>LockForProcess</strong> is called directly by XAudio2 and should not be called by the client code. </p>
        /// </remarks>
        /// <doc-id>microsoft.directx_sdk.ixapo.ixapo.lockforprocess</doc-id>
        /// <unmanaged>HRESULT IXAPO::LockForProcess([In] unsigned int InputLockedParameterCount,[In, Buffer] const XAPO_LOCKFORPROCESS_BUFFER_PARAMETERS* pInputLockedParameters,[In] unsigned int OutputLockedParameterCount,[In, Buffer] const XAPO_LOCKFORPROCESS_BUFFER_PARAMETERS* pOutputLockedParameters)</unmanaged>
        /// <unmanaged-short>IXAPO::LockForProcess</unmanaged-short>
        internal unsafe void LockForProcess_(System.Int32 inputLockedParameterCount, SharpDX.XAPO.LockParameters[] inputLockedParametersRef, System.Int32 outputLockedParameterCount, SharpDX.XAPO.LockParameters[] outputLockedParametersRef)
        {
            SharpDX.XAPO.LockParameters.__Native[] inputLockedParametersRef_ = new SharpDX.XAPO.LockParameters.__Native[inputLockedParametersRef.Length];
            SharpDX.XAPO.LockParameters.__Native[] outputLockedParametersRef_ = new SharpDX.XAPO.LockParameters.__Native[outputLockedParametersRef.Length];
            SharpDX.Result __result__;
            for (int i = 0; i < inputLockedParametersRef.Length; ++i)
                inputLockedParametersRef[i].__MarshalTo(ref (inputLockedParametersRef_)[i]);
            for (int i = 0; i < outputLockedParametersRef.Length; ++i)
                outputLockedParametersRef[i].__MarshalTo(ref (outputLockedParametersRef_)[i]);
            fixed (void *_outputLockedParametersRef = outputLockedParametersRef_)
                fixed (void *_inputLockedParametersRef = inputLockedParametersRef_)
                    __result__ = SharpDX.XAudio2.LocalInterop.CalliStdCallint(this._nativePointer, inputLockedParameterCount, _inputLockedParametersRef, outputLockedParameterCount, _outputLockedParametersRef, (*(void ***)this._nativePointer)[8]);
            for (int i = 0; i < inputLockedParametersRef.Length; ++i)
                inputLockedParametersRef[i].__MarshalFree(ref (inputLockedParametersRef_)[i]);
            for (int i = 0; i < outputLockedParametersRef.Length; ++i)
                outputLockedParametersRef[i].__MarshalFree(ref (outputLockedParametersRef_)[i]);
            __result__.CheckError();
        }

        /// <summary>
        /// <p>Deallocates variables that were allocated with the <strong>LockForProcess</strong> method.</p>
        /// </summary>
        /// <remarks>
        /// <p>Unlocking an XAPO instance allows it to be reused with different input and output formats.</p>
        /// </remarks>
        /// <doc-id>microsoft.directx_sdk.ixapo.ixapo.unlockforprocess</doc-id>
        /// <unmanaged>void IXAPO::UnlockForProcess()</unmanaged>
        /// <unmanaged-short>IXAPO::UnlockForProcess</unmanaged-short>
        internal unsafe void UnlockForProcess_()
        {
            SharpDX.XAudio2.LocalInterop.CalliStdCallvoid(this._nativePointer, (*(void ***)this._nativePointer)[9]);
        }

        /// <summary>
        /// <p>Runs the XAPO's digital signal processing (DSP) code on the given input and output buffers.</p>
        /// </summary>
        /// <param name = "inputProcessParameterCount"><dd> <p> Number of elements in pInputProcessParameters. </p> <strong>Note</strong>??XAudio2 currently supports only one input stream and one output stream. ? </dd></param>
        /// <param name = "inputProcessParametersRef"><dd> <p> Input array of <strong><see cref = "SharpDX.XAPO.BufferParameters"/></strong> structures. </p> </dd></param>
        /// <param name = "outputProcessParameterCount"><dd> <p>Number of elements in <em>pOutputProcessParameters</em>. </p> <strong>Note</strong>??XAudio2 currently supports only one input stream and one output stream. ? </dd></param>
        /// <param name = "outputProcessParametersRef"><dd> <p>Output array of <strong><see cref = "SharpDX.XAPO.BufferParameters"/></strong> structures. On input, the value of <strong><see cref = "SharpDX.XAPO.BufferParameters"/></strong>. <strong>ValidFrameCount</strong> indicates the number of frames that the XAPO should write to the output buffer. On output, the value of <strong><see cref = "SharpDX.XAPO.BufferParameters"/></strong>. <strong>ValidFrameCount</strong> indicates the actual number of frames written.</p> </dd></param>
        /// <param name = "isEnabled"><dd> <p> TRUE to process normally; <see cref = "SharpDX.Result.False"/> to process thru. See Remarks for additional information.</p> </dd></param>
        /// <remarks>
        /// <p>Implementations of this function should not block, as the function is called from the realtime audio processing thread. </p><p>All code that could cause a delay, such as format validation and memory allocation, should be put in the <strong>IXAPO::LockForProcess</strong> method, which is not called from the realtime audio processing thread.  </p><p>For in-place processing, the <em>pInputProcessParameters</em> parameter will not necessarily be the same as <em>pOutputProcessParameters</em>. Rather, their <em>pBuffer</em> members will point to the same memory.  </p><p>Multiple input and output buffers may be used with in-place XAPOs, though the input buffer count must equal the output buffer count. For in-place processing when multiple input and output buffers are used, the XAPO may assume the number of input buffers equals the number of output buffers.  </p><p>In addition to writing to the output buffer, as appropriate, an XAPO is responsible for setting the output stream's buffer flags and valid frame count.  </p><p>When <em>IsEnabled</em> is <see cref = "SharpDX.Result.False"/>, the XAPO should not apply its normal processing to the given input/output buffers during. It should instead pass data from input to output with as little modification possible. Effects that perform format conversion should continue to do so. Effects must ensure transitions between normal and thru processing do not introduce discontinuities into the signal.  </p><p>When writing a <strong>Process</strong> method, it is important to note XAudio2 audio data is interleaved, which means data from each channel is adjacent for a particular sample number. For example, if there was a 4-channel wave playing into an XAudio2 source voice, the audio data would be a sample of channel 0, a sample of channel 1, a sample of channel 2, a sample of channel 3, and then the next sample of channels 0, 1, 2, 3, and so on.
        /// </p>
        /// </remarks>
        /// <doc-id>microsoft.directx_sdk.ixapo.ixapo.process</doc-id>
        /// <unmanaged>void IXAPO::Process([In] unsigned int InputProcessParameterCount,[In, Buffer, Optional] const XAPO_PROCESS_BUFFER_PARAMETERS* pInputProcessParameters,[In] unsigned int OutputProcessParameterCount,[In, Buffer] XAPO_PROCESS_BUFFER_PARAMETERS* pOutputProcessParameters,[In] BOOL IsEnabled)</unmanaged>
        /// <unmanaged-short>IXAPO::Process</unmanaged-short>
        internal unsafe void Process_(System.Int32 inputProcessParameterCount, SharpDX.XAPO.BufferParameters[] inputProcessParametersRef, System.Int32 outputProcessParameterCount, SharpDX.XAPO.BufferParameters[] outputProcessParametersRef, SharpDX.Mathematics.Interop.RawBool isEnabled)
        {
            fixed (void *outputProcessParametersRef_ = outputProcessParametersRef)
                fixed (void *inputProcessParametersRef_ = inputProcessParametersRef)
                    SharpDX.XAudio2.LocalInterop.CalliStdCallvoid0(this._nativePointer, inputProcessParameterCount, inputProcessParametersRef_, outputProcessParameterCount, outputProcessParametersRef_, isEnabled, (*(void ***)this._nativePointer)[10]);
        }

        /// <summary>
        /// <p>Returns the number of input frames required to generate the given number of output frames.</p>
        /// </summary>
        /// <param name = "outputFrameCount"><dd> <p> The number of output frames desired.</p> </dd></param>
        /// <returns><p>Returns the number of input frames required.</p></returns>
        /// <remarks>
        /// <p>XAudio2 calls this method to determine what size input buffer an XAPO requires to generate the given number of output frames. This method only needs to be called once while an XAPO is locked. <strong>CalcInputFrames</strong> is only called by XAudio2 if the XAPO is locked. </p><p>This function should not block, because it may be called from the realtime audio processing thread. </p>
        /// </remarks>
        /// <doc-id>microsoft.directx_sdk.ixapo.ixapo.calcinputframes</doc-id>
        /// <unmanaged>unsigned int IXAPO::CalcInputFrames([In] unsigned int OutputFrameCount)</unmanaged>
        /// <unmanaged-short>IXAPO::CalcInputFrames</unmanaged-short>
        internal unsafe System.Int32 CalcInputFrames_(System.Int32 outputFrameCount)
        {
            System.Int32 __result__;
            __result__ = SharpDX.XAudio2.LocalInterop.CalliStdCallint(this._nativePointer, outputFrameCount, (*(void ***)this._nativePointer)[11]);
            return __result__;
        }

        /// <summary>
        /// <p>Returns the number of output frames that will be generated from a given number of input frames.</p>
        /// </summary>
        /// <param name = "inputFrameCount"><dd> <p> The number of input frames.</p> </dd></param>
        /// <returns><p>Returns the number of output frames that will be produced. </p></returns>
        /// <remarks>
        /// <p>XAudio2 calls this method to determine how large of an output buffer an XAPO will require for a certain number of input frames. <strong>CalcOutputFrames</strong> is only called by XAudio2 if the XAPO is locked. </p><p>This function should not block, because it may be called from the realtime audio processing thread. </p>
        /// </remarks>
        /// <doc-id>microsoft.directx_sdk.ixapo.ixapo.calcoutputframes</doc-id>
        /// <unmanaged>unsigned int IXAPO::CalcOutputFrames([In] unsigned int InputFrameCount)</unmanaged>
        /// <unmanaged-short>IXAPO::CalcOutputFrames</unmanaged-short>
        internal unsafe System.Int32 CalcOutputFrames_(System.Int32 inputFrameCount)
        {
            System.Int32 __result__;
            __result__ = SharpDX.XAudio2.LocalInterop.CalliStdCallint(this._nativePointer, inputFrameCount, (*(void ***)this._nativePointer)[12]);
            return __result__;
        }
    }

    [System.Runtime.InteropServices.GuidAttribute("26D95C66-80F2-499A-AD54-5AE7F01C6D98")]
    internal partial interface ParameterProvider : SharpDX.IUnknown
    {
    }

    [System.Runtime.InteropServices.GuidAttribute("26D95C66-80F2-499A-AD54-5AE7F01C6D98")]
    internal partial class ParameterProviderNative : SharpDX.ComObject, SharpDX.XAPO.ParameterProvider
    {
        public ParameterProviderNative(System.IntPtr nativePtr): base (nativePtr)
        {
        }

        public static explicit operator ParameterProviderNative(System.IntPtr nativePtr) => nativePtr == System.IntPtr.Zero ? null : new ParameterProviderNative(nativePtr);
        /// <summary>
        /// <p>Sets effect-specific parameters.</p>
        /// </summary>
        /// <param name = "parametersRef"><dd> <p> Effect-specific parameter block.</p> </dd></param>
        /// <param name = "parameterByteSize"><dd> <p> Size of pParameters, in bytes.</p> </dd></param>
        /// <remarks>
        /// <p>The data in <em>pParameters</em> is completely effect-specific and determined by the implementation of the <strong>IXAPOParameters::SetParameters</strong> function. The data passed to <strong>SetParameters</strong> can be used to set the state of the XAPO and control the behavior of the <strong>IXAPO::Process</strong> function. </p><p><strong>SetParameters</strong> can only be called on the real-time audio processing thread; no synchronization between <strong>SetParameters</strong> and the <strong>IXAPO::Process</strong> method is necessary. However, the <strong>IXAudio2Voice::SetEffectParameters</strong> method may be called from any thread as it adds in the required synchronization to deliver a copy (asynchronously) of the parameters to <strong>SetParameters</strong> on the real-time thread; no synchronization between <strong>IXAudio2Voice::SetEffectParameters</strong> and the <strong>IXAPO::Process</strong> method is necessary. </p>
        /// </remarks>
        /// <doc-id>microsoft.directx_sdk.ixapoparameters.ixapoparameters.setparameters</doc-id>
        /// <unmanaged>void IXAPOParameters::SetParameters([In, Buffer] const void* pParameters,[In] unsigned int ParameterByteSize)</unmanaged>
        /// <unmanaged-short>IXAPOParameters::SetParameters</unmanaged-short>
        internal unsafe void SetParameters_(System.IntPtr parametersRef, System.Int32 parameterByteSize)
        {
            SharpDX.XAudio2.LocalInterop.CalliStdCallvoid(this._nativePointer, (void *)parametersRef, parameterByteSize, (*(void ***)this._nativePointer)[3]);
        }

        /// <summary>
        /// <p>Gets the current values for any effect-specific parameters.</p>
        /// </summary>
        /// <param name = "parametersRef"><dd> <p>Receives an effect-specific parameter block.</p> </dd></param>
        /// <param name = "parameterByteSize"><dd> <p> Size of pParameters, in bytes.</p> </dd></param>
        /// <remarks>
        /// <p>The data in <em>pParameters</em> is completely effect-specific and determined by the implementation of the <strong>IXAPOParameters::GetParameters</strong> function. The data returned in <em>pParameters</em> can be used to provide information about the current state of the XAPO. </p><p>Unlike SetParameters, XAudio2 does not call this method on the realtime audio processing thread. Thus, the XAPO must protect variables shared with <strong>IXAPOParameters::SetParameters</strong> or <strong>IXAPO::Process</strong> using appropriate synchronization. The <strong>CXAPOParametersBase</strong> class is an implementation of <strong><see cref = "SharpDX.XAPO.ParameterProvider"/></strong> and its implementation of <strong>GetParameters</strong> efficiently handles this synchronization for the user. </p><p>XAudio2 calls this method from the <strong>IXAudio2Voice::GetEffectParameters</strong> method. </p><p>This method may block and should never be called from the realtime audio processing thread instead get the current parameters from <strong>CXAPOParametersBase::BeginProcess</strong>.</p>
        /// </remarks>
        /// <doc-id>microsoft.directx_sdk.ixapoparameters.ixapoparameters.getparameters</doc-id>
        /// <unmanaged>void IXAPOParameters::GetParameters([Out, Buffer] void* pParameters,[In] unsigned int ParameterByteSize)</unmanaged>
        /// <unmanaged-short>IXAPOParameters::GetParameters</unmanaged-short>
        internal unsafe void GetParameters_(System.IntPtr parametersRef, System.Int32 parameterByteSize)
        {
            SharpDX.XAudio2.LocalInterop.CalliStdCallvoid(this._nativePointer, (void *)parametersRef, parameterByteSize, (*(void ***)this._nativePointer)[4]);
        }
    }
}