// <auto-generated/>

namespace SharpDX.Direct3D12
{
    /// <summary>
    /// Functions
    /// </summary>
    static partial class D3D12
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <param name = "rootSignatureRef">No documentation.</param>
        /// <param name = "version">No documentation.</param>
        /// <param name = "blobOut">No documentation.</param>
        /// <param name = "errorBlobOut">No documentation.</param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>HRESULT D3D12SerializeRootSignature([In] const D3D12_ROOT_SIGNATURE_DESC* pRootSignature,[In] D3D_ROOT_SIGNATURE_VERSION Version,[Out] ID3D10Blob** ppBlob,[Out, Optional] ID3D10Blob** ppErrorBlob)</unmanaged>
        /// <unmanaged-short>D3D12SerializeRootSignature</unmanaged-short>
        public static unsafe SharpDX.Result SerializeRootSignature(System.IntPtr rootSignatureRef, SharpDX.Direct3D12.RootSignatureVersion version, out SharpDX.Direct3D.Blob blobOut, out SharpDX.Direct3D.Blob errorBlobOut)
        {
            System.IntPtr blobOut_ = System.IntPtr.Zero;
            System.IntPtr errorBlobOut_ = System.IntPtr.Zero;
            SharpDX.Result __result__;
            __result__ = D3D12SerializeRootSignature_((void *)rootSignatureRef, unchecked ((System.Int32)version), &blobOut_, &errorBlobOut_);
            if (blobOut_ != System.IntPtr.Zero)
                blobOut = new SharpDX.Direct3D.Blob(blobOut_);
            else
                blobOut = null;
            if (errorBlobOut_ != System.IntPtr.Zero)
                errorBlobOut = new SharpDX.Direct3D.Blob(errorBlobOut_);
            else
                errorBlobOut = null;
            return __result__;
        }

        [System.Runtime.InteropServices.DllImportAttribute("d3d12.dll", EntryPoint = "D3D12SerializeRootSignature", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private unsafe static extern int D3D12SerializeRootSignature_(void *param0, int param1, void *param2, void *param3);
        /// <summary>
        /// <p> Deserializes a root signature so you can determine the layout definition (<strong><see cref = "SharpDX.Direct3D12.RootSignatureDescription"/></strong>). </p>
        /// </summary>
        /// <param name = "srcDataRef">No documentation.</param>
        /// <param name = "srcDataSizeInBytes">No documentation.</param>
        /// <param name = "rootSignatureDeserializerInterfaceRef">No documentation.</param>
        /// <param name = "rootSignatureDeserializerOut">No documentation.</param>
        /// <returns><p> Returns <strong><see cref = "SharpDX.Result.Ok"/></strong> if successful; otherwise, returns one of the Direct3D 12 Return Codes. </p></returns>
        /// <remarks>
        /// <p>This function has been superceded by <strong>D3D12CreateVersionedRootSignatureDeserializer</strong>.</p><p> If an application has a serialized root signature already or has a compiled shader that contains a root signature and wants to determine the layout definition, it can call <strong>D3D12CreateRootSignatureDeserializer</strong> to generate a <strong><see cref = "SharpDX.Direct3D12.RootSignatureDeserializer"/></strong> interface. <strong>ID3D12RootSignatureDeserializer::GetRootSignature</strong> can return the deserialized data structure (<strong><see cref = "SharpDX.Direct3D12.RootSignatureDescription"/></strong>). <strong><see cref = "SharpDX.Direct3D12.RootSignatureDeserializer"/></strong> just owns the lifetime of the memory for the deserialized data structure. </p><p> The <strong>REFIID</strong>, or <strong><see cref = "System.Guid"/></strong>, of the interface to the root signature deserializer can be obtained by using the __uuidof() macro. For example, __uuidof(<strong><see cref = "SharpDX.Direct3D12.RootSignatureDeserializer"/></strong>) will get the <strong><see cref = "System.Guid"/></strong> of the interface to a root signature deserializer. </p><p> The function signature PFN_D3D12_CREATE_ROOT_SIGNATURE_DESERIALIZER is provided as a typedef, so that you can use dynamic linking techniques (GetProcAddress) instead of statically linking. </p>
        /// </remarks>
        /// <doc-id>dn859362</doc-id>
        /// <unmanaged>HRESULT D3D12CreateRootSignatureDeserializer([In, Buffer] const void* pSrcData,[In] SIZE_T SrcDataSizeInBytes,[In] const GUID&amp; pRootSignatureDeserializerInterface,[Out] void** ppRootSignatureDeserializer)</unmanaged>
        /// <unmanaged-short>D3D12CreateRootSignatureDeserializer</unmanaged-short>
        public static unsafe void CreateRootSignatureDeserializer(System.IntPtr srcDataRef, SharpDX.PointerSize srcDataSizeInBytes, System.Guid rootSignatureDeserializerInterfaceRef, out System.IntPtr rootSignatureDeserializerOut)
        {
            SharpDX.Result __result__;
            fixed (void *rootSignatureDeserializerOut_ = &rootSignatureDeserializerOut)
                __result__ = D3D12CreateRootSignatureDeserializer_((void *)srcDataRef, (void *)srcDataSizeInBytes, &rootSignatureDeserializerInterfaceRef, rootSignatureDeserializerOut_);
            __result__.CheckError();
        }

        [System.Runtime.InteropServices.DllImportAttribute("d3d12.dll", EntryPoint = "D3D12CreateRootSignatureDeserializer", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private unsafe static extern int D3D12CreateRootSignatureDeserializer_(void *param0, void *param1, void *param2, void *param3);
        /// <summary>
        /// <p>Generates an interface that can return the deserialized data structure, via <strong>GetUnconvertedRootSignatureDesc</strong>.</p>
        /// </summary>
        /// <param name = "srcDataRef">No documentation.</param>
        /// <param name = "srcDataSizeInBytes">No documentation.</param>
        /// <param name = "rootSignatureDeserializerInterfaceRef">No documentation.</param>
        /// <param name = "rootSignatureDeserializerOut">No documentation.</param>
        /// <returns><p> Returns <strong><see cref = "SharpDX.Result.Ok"/></strong> if successful; otherwise, returns one of the Direct3D 12 Return Codes. </p></returns>
        /// <remarks>
        /// <p> If an application has a serialized root signature already or has a compiled shader that contains a root signature and wants to determine the layout definition, it can call <strong>D3D12CreateVersionedRootSignatureDeserializer</strong> to generate a <strong>ID3D12VersionedRootSignatureDeserializer</strong> interface. <strong>ID3D12VersionedRootSignatureDeserializer::GetRootSignatureDescAtVersion</strong> can return the deserialized data structure (<strong><see cref = "SharpDX.Direct3D12.RootSignatureDescription1"/></strong>). <strong>ID3D12VersionedRootSignatureDeserializer</strong> just owns the lifetime of the memory for the deserialized data structure. </p><p> The <strong>REFIID</strong>, or <strong><see cref = "System.Guid"/></strong>, of the interface to the root signature deserializer can be obtained by using the __uuidof() macro. For example, __uuidof(<strong>ID3D12VersionedRootSignatureDeserializer</strong>) will get the <strong><see cref = "System.Guid"/></strong> of the interface to a root signature deserializer. </p><p> The function signature PFN_D3D12_CREATE_ROOT_SIGNATURE_DESERIALIZER is provided as a typedef, so that you can use dynamic linking techniques (GetProcAddress) instead of statically linking. </p><p>This function supercedes <strong>D3D12CreateRootSignatureDeserializer</strong>.</p>
        /// </remarks>
        /// <doc-id>mt709109</doc-id>
        /// <unmanaged>HRESULT D3D12CreateVersionedRootSignatureDeserializer([In, Buffer] const void* pSrcData,[In] SIZE_T SrcDataSizeInBytes,[In] const GUID&amp; pRootSignatureDeserializerInterface,[Out] void** ppRootSignatureDeserializer)</unmanaged>
        /// <unmanaged-short>D3D12CreateVersionedRootSignatureDeserializer</unmanaged-short>
        public static unsafe void CreateVersionedRootSignatureDeserializer(System.IntPtr srcDataRef, SharpDX.PointerSize srcDataSizeInBytes, System.Guid rootSignatureDeserializerInterfaceRef, out System.IntPtr rootSignatureDeserializerOut)
        {
            SharpDX.Result __result__;
            fixed (void *rootSignatureDeserializerOut_ = &rootSignatureDeserializerOut)
                __result__ = D3D12CreateVersionedRootSignatureDeserializer_((void *)srcDataRef, (void *)srcDataSizeInBytes, &rootSignatureDeserializerInterfaceRef, rootSignatureDeserializerOut_);
            __result__.CheckError();
        }

        [System.Runtime.InteropServices.DllImportAttribute("d3d12.dll", EntryPoint = "D3D12CreateVersionedRootSignatureDeserializer", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private unsafe static extern int D3D12CreateVersionedRootSignatureDeserializer_(void *param0, void *param1, void *param2, void *param3);
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <param name = "adapterRef">No documentation.</param>
        /// <param name = "minimumFeatureLevel">No documentation.</param>
        /// <param name = "riid">No documentation.</param>
        /// <param name = "deviceOut">No documentation.</param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>HRESULT D3D12CreateDevice([In, Optional] IUnknown* pAdapter,[In] D3D_FEATURE_LEVEL MinimumFeatureLevel,[In] const GUID&amp; riid,[Out, Fast] void** ppDevice)</unmanaged>
        /// <unmanaged-short>D3D12CreateDevice</unmanaged-short>
        public static unsafe SharpDX.Result CreateDevice(SharpDX.IUnknown adapterRef, SharpDX.Direct3D.FeatureLevel minimumFeatureLevel, System.Guid riid, SharpDX.Direct3D12.Device deviceOut)
        {
            System.IntPtr adapterRef_ = System.IntPtr.Zero;
            System.IntPtr deviceOut_ = System.IntPtr.Zero;
            SharpDX.Result __result__;
            adapterRef_ = SharpDX.CppObject.ToCallbackPtr<SharpDX.IUnknown>(adapterRef);
            __result__ = D3D12CreateDevice_((void *)adapterRef_, unchecked ((System.Int32)minimumFeatureLevel), &riid, &deviceOut_);
            (deviceOut).NativePointer = deviceOut_;
            return __result__;
        }

        [System.Runtime.InteropServices.DllImportAttribute("d3d12.dll", EntryPoint = "D3D12CreateDevice", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private unsafe static extern int D3D12CreateDevice_(void *param0, int param1, void *param2, void *param3);
        /// <summary>
        /// <p> Gets a debug interface. </p>
        /// </summary>
        /// <param name = "riid"><dd>  <p> The globally unique identifier (<strong><see cref = "System.Guid"/></strong>) for the debug interface. The <strong>REFIID</strong>, or <strong><see cref = "System.Guid"/></strong>, of the debug interface can be obtained by using the __uuidof() macro. For example, __uuidof(<strong><see cref = "SharpDX.Direct3D12.DebugInterface"/></strong>) will get the <strong><see cref = "System.Guid"/></strong> of the debug interface. </p> </dd></param>
        /// <param name = "vDebugOut"><dd>  <p> The debug interface, as a reference to reference to void. See <strong><see cref = "SharpDX.Direct3D12.DebugInterface"/></strong> and <strong><see cref = "SharpDX.Direct3D12.DebugDevice"/></strong>. </p> </dd></param>
        /// <returns><p> This method returns one of the Direct3D 12 Return Codes. </p></returns>
        /// <remarks>
        /// <p> The function signature PFN_D3D12_GET_DEBUG_INTERFACE is provided as a typedef, so that you can use dynamic linking techniques (GetProcAddress) instead of statically linking. </p>
        /// </remarks>
        /// <doc-id>dn986869</doc-id>
        /// <unmanaged>HRESULT D3D12GetDebugInterface([In] const GUID&amp; riid,[Out, Optional] void** ppvDebug)</unmanaged>
        /// <unmanaged-short>D3D12GetDebugInterface</unmanaged-short>
        public static unsafe void GetDebugInterface(System.Guid riid, out System.IntPtr vDebugOut)
        {
            SharpDX.Result __result__;
            fixed (void *vDebugOut_ = &vDebugOut)
                __result__ = D3D12GetDebugInterface_(&riid, vDebugOut_);
            __result__.CheckError();
        }

        [System.Runtime.InteropServices.DllImportAttribute("d3d12.dll", EntryPoint = "D3D12GetDebugInterface", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private unsafe static extern int D3D12GetDebugInterface_(void *param0, void *param1);
        /// <summary>
        /// <p>Generates an interface that can return the deserialized data structure, via <strong>GetUnconvertedRootSignatureDesc</strong>.</p>
        /// </summary>
        /// <param name = "numFeatures">No documentation.</param>
        /// <param name = "iIDsRef">No documentation.</param>
        /// <param name = "configurationStructsRef">No documentation.</param>
        /// <param name = "configurationStructSizesRef">No documentation.</param>
        /// <returns><p> Returns <strong><see cref = "SharpDX.Result.Ok"/></strong> if successful; otherwise, returns one of the Direct3D 12 Return Codes. </p></returns>
        /// <remarks>
        /// <p> If an application has a serialized root signature already or has a compiled shader that contains a root signature and wants to determine the layout definition, it can call <strong>D3D12CreateVersionedRootSignatureDeserializer</strong> to generate a <strong>ID3D12VersionedRootSignatureDeserializer</strong> interface. <strong>ID3D12VersionedRootSignatureDeserializer::GetRootSignatureDescAtVersion</strong> can return the deserialized data structure (<strong><see cref = "SharpDX.Direct3D12.RootSignatureDescription1"/></strong>). <strong>ID3D12VersionedRootSignatureDeserializer</strong> just owns the lifetime of the memory for the deserialized data structure. </p><p> The <strong>REFIID</strong>, or <strong><see cref = "System.Guid"/></strong>, of the interface to the root signature deserializer can be obtained by using the __uuidof() macro. For example, __uuidof(<strong>ID3D12VersionedRootSignatureDeserializer</strong>) will get the <strong><see cref = "System.Guid"/></strong> of the interface to a root signature deserializer. </p><p> The function signature PFN_D3D12_CREATE_ROOT_SIGNATURE_DESERIALIZER is provided as a typedef, so that you can use dynamic linking techniques (GetProcAddress) instead of statically linking. </p><p>This function supercedes <strong>D3D12CreateRootSignatureDeserializer</strong>.</p>
        /// </remarks>
        /// <doc-id>mt709109</doc-id>
        /// <unmanaged>HRESULT D3D12EnableExperimentalFeatures([In] unsigned int NumFeatures,[In, Buffer] const GUID* pIIDs,[In, Buffer, Optional] void* pConfigurationStructs,[In, Buffer, Optional] unsigned int* pConfigurationStructSizes)</unmanaged>
        /// <unmanaged-short>D3D12EnableExperimentalFeatures</unmanaged-short>
        public static unsafe void EnableExperimentalFeatures(System.Int32 numFeatures, System.Guid[] iIDsRef, System.IntPtr configurationStructsRef, System.Int32[] configurationStructSizesRef)
        {
            SharpDX.Result __result__;
            fixed (void *configurationStructSizesRef_ = configurationStructSizesRef)
                fixed (void *iIDsRef_ = iIDsRef)
                    __result__ = D3D12EnableExperimentalFeatures_(numFeatures, iIDsRef_, (void *)configurationStructsRef, configurationStructSizesRef_);
            __result__.CheckError();
        }

        [System.Runtime.InteropServices.DllImportAttribute("d3d12.dll", EntryPoint = "D3D12EnableExperimentalFeatures", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private unsafe static extern int D3D12EnableExperimentalFeatures_(int param0, void *param1, void *param2, void *param3);
    }
}