// <auto-generated/>

namespace SharpDX.X3DAudio
{
    /// <summary>
    /// <p>Specifies directionality for a single-channel non-LFE emitter by scaling DSP behavior with respect to the emitter's orientation.</p>
    /// </summary>
    /// <remarks>
    /// <p>For a detailed explanation of sound cones see Sound Cones.</p>
    /// </remarks>
    /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_cone</doc-id>
    /// <unmanaged>X3DAUDIO_CONE</unmanaged>
    /// <unmanaged-short>X3DAUDIO_CONE</unmanaged-short>
    public partial class Cone
    {
        /// <summary>
        /// <dd> <p>Inner cone angle in radians. This value must be within 0.0f to X3DAUDIO_2PI.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_cone</doc-id>
        /// <unmanaged>InnerAngle</unmanaged>
        /// <unmanaged-short>InnerAngle</unmanaged-short>
        public System.Single InnerAngle;
        /// <summary>
        /// <dd> <p>Outer cone angle in radians. This value must be within <em>InnerAngle</em> to X3DAUDIO_2PI.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_cone</doc-id>
        /// <unmanaged>OuterAngle</unmanaged>
        /// <unmanaged-short>OuterAngle</unmanaged-short>
        public System.Single OuterAngle;
        /// <summary>
        /// <dd> <p>Volume scaler on/within inner cone. This value must be within 0.0f to 2.0f. </p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_cone</doc-id>
        /// <unmanaged>InnerVolume</unmanaged>
        /// <unmanaged-short>InnerVolume</unmanaged-short>
        public System.Single InnerVolume;
        /// <summary>
        /// <dd> <p>Volume scaler on/beyond outer cone. This value must be within 0.0f to 2.0f. </p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_cone</doc-id>
        /// <unmanaged>OuterVolume</unmanaged>
        /// <unmanaged-short>OuterVolume</unmanaged-short>
        public System.Single OuterVolume;
        /// <summary>
        /// <dd> <p>LPF direct-path or reverb-path coefficient scaler on/within inner cone. This value is only used for LPF calculations and must be within 0.0f to 1.0f. </p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_cone</doc-id>
        /// <unmanaged>InnerLPF</unmanaged>
        /// <unmanaged-short>InnerLPF</unmanaged-short>
        public System.Single InnerLpf;
        /// <summary>
        /// <dd> <p>LPF direct-path or reverb-path coefficient scaler on or beyond outer cone. This value is only used for LPF calculations and must be within 0.0f to 1.0f. </p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_cone</doc-id>
        /// <unmanaged>OuterLPF</unmanaged>
        /// <unmanaged-short>OuterLPF</unmanaged-short>
        public System.Single OuterLpf;
        /// <summary>
        /// <dd> <p>Reverb send level scaler on or within inner cone. This must be within 0.0f to 2.0f. </p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_cone</doc-id>
        /// <unmanaged>InnerReverb</unmanaged>
        /// <unmanaged-short>InnerReverb</unmanaged-short>
        public System.Single InnerReverb;
        /// <summary>
        /// <dd> <p>Reverb send level scaler on/beyond outer cone. This must be within 0.0f to 2.0f. 
        /// </p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_cone</doc-id>
        /// <unmanaged>OuterReverb</unmanaged>
        /// <unmanaged-short>OuterReverb</unmanaged-short>
        public System.Single OuterReverb;
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 0, CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
        internal partial struct __Native
        {
            public System.Single InnerAngle;
            public System.Single OuterAngle;
            public System.Single InnerVolume;
            public System.Single OuterVolume;
            public System.Single InnerLpf;
            public System.Single OuterLpf;
            public System.Single InnerReverb;
            public System.Single OuterReverb;
        }

        internal unsafe void __MarshalFree(ref __Native @ref)
        {
        }

        internal unsafe void __MarshalFrom(ref __Native @ref)
        {
            InnerAngle = @ref.InnerAngle;
            OuterAngle = @ref.OuterAngle;
            InnerVolume = @ref.InnerVolume;
            OuterVolume = @ref.OuterVolume;
            InnerLpf = @ref.InnerLpf;
            OuterLpf = @ref.OuterLpf;
            InnerReverb = @ref.InnerReverb;
            OuterReverb = @ref.OuterReverb;
        }

        internal unsafe void __MarshalTo(ref __Native @ref)
        {
            @ref.InnerAngle = InnerAngle;
            @ref.OuterAngle = OuterAngle;
            @ref.InnerVolume = InnerVolume;
            @ref.OuterVolume = OuterVolume;
            @ref.InnerLpf = InnerLpf;
            @ref.OuterLpf = OuterLpf;
            @ref.InnerReverb = InnerReverb;
            @ref.OuterReverb = OuterReverb;
        }
    }

    /// <summary>
    /// <p>Defines a DSP setting at a given normalized distance.</p>
    /// </summary>
    /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_distance_curve_point</doc-id>
    /// <unmanaged>X3DAUDIO_DISTANCE_CURVE_POINT</unmanaged>
    /// <unmanaged-short>X3DAUDIO_DISTANCE_CURVE_POINT</unmanaged-short>
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 0, CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
    public partial struct CurvePoint
    {
        /// <summary>
        /// <dd> <p>Normalized distance. This must be within 0.0f to 1.0f.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_distance_curve_point</doc-id>
        /// <unmanaged>Distance</unmanaged>
        /// <unmanaged-short>Distance</unmanaged-short>
        public System.Single Distance;
        /// <summary>
        /// <dd> <p>DSP control setting.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_distance_curve_point</doc-id>
        /// <unmanaged>DSPSetting</unmanaged>
        /// <unmanaged-short>DSPSetting</unmanaged-short>
        public System.Single DspSetting;
    }

    /// <summary>
    /// <p>Defines an explicit piecewise curve made up of linear segments, directly defining DSP behavior with respect to normalized distance.</p>
    /// </summary>
    /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_distance_curve</doc-id>
    /// <unmanaged>X3DAUDIO_DISTANCE_CURVE</unmanaged>
    /// <unmanaged-short>X3DAUDIO_DISTANCE_CURVE</unmanaged-short>
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 0, CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
    internal partial struct DistanceCurve
    {
        /// <summary>
        /// <dd> <p> <strong><see cref = "SharpDX.X3DAudio.CurvePoint"/></strong> array. The array must have no duplicates and be sorted in ascending order with respect to distance.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_distance_curve</doc-id>
        /// <unmanaged>pPoints</unmanaged>
        /// <unmanaged-short>pPoints</unmanaged-short>
        internal System.IntPtr PointsPointer;
        /// <summary>
        /// <dd> <p>Number of distance curve points. There must be two or more points since all curves must have at least two endpoints defining values at 0.0f and 1.0f normalized distance, respectively.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_distance_curve</doc-id>
        /// <unmanaged>PointCount</unmanaged>
        /// <unmanaged-short>PointCount</unmanaged-short>
        public System.Int32 PointCount;
    }

    /// <summary>
    /// <p>Receives the results from a call to <strong>X3DAudioCalculate</strong>.</p>
    /// </summary>
    /// <remarks>
    /// <p>The following members must be initialized before passing this structure to the <strong>X3DAudioCalculate</strong> function: </p><ul> <li><strong>pMatrixCoefficients </strong></li> <li><strong>pDelayTimes</strong></li> <li><strong>SrcChannelCount </strong></li> <li><strong>DstChannelCount</strong></li> </ul><p>The following members are returned by passing this structure to the <strong>X3DAudioCalculate</strong> function:</p><ul> <li><strong>pMatrixCoefficients </strong></li> <li><strong>pDelayTimes </strong></li> <li><strong>LPFDirectCoefficient </strong></li> <li><strong>LPFReverbCoefficient</strong></li> <li><strong>ReverbLevel </strong></li> <li><strong>DopplerFactor </strong></li> <li><strong>EmitterToListenerAngle</strong></li> <li><strong>EmitterToListenerDistance </strong></li> <li><strong>EmitterVelocityComponent </strong></li> <li><strong>ListenerVelocityComponent</strong></li> </ul><strong>Note</strong>??For <strong>pMatrixCoefficients</strong> and <strong>pDelayTimes</strong>, <strong>X3DAudioCalculate</strong> does not allocate additional memory. <strong>X3DAudioCalculate</strong> merely modifies the values at the memory locations allocated for these references.?
    /// </remarks>
    /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_dsp_settings</doc-id>
    /// <unmanaged>X3DAUDIO_DSP_SETTINGS</unmanaged>
    /// <unmanaged-short>X3DAUDIO_DSP_SETTINGS</unmanaged-short>
    public partial class DspSettings
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_dsp_settings</doc-id>
        /// <unmanaged>pMatrixCoefficients</unmanaged>
        /// <unmanaged-short>pMatrixCoefficients</unmanaged-short>
        internal System.IntPtr MatrixCoefficientsPointer;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_dsp_settings</doc-id>
        /// <unmanaged>pDelayTimes</unmanaged>
        /// <unmanaged-short>pDelayTimes</unmanaged-short>
        internal System.IntPtr DelayTimesPointer;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_dsp_settings</doc-id>
        /// <unmanaged>SrcChannelCount</unmanaged>
        /// <unmanaged-short>SrcChannelCount</unmanaged-short>
        public readonly System.Int32 SourceChannelCount;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_dsp_settings</doc-id>
        /// <unmanaged>DstChannelCount</unmanaged>
        /// <unmanaged-short>DstChannelCount</unmanaged-short>
        public readonly System.Int32 DestinationChannelCount;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_dsp_settings</doc-id>
        /// <unmanaged>LPFDirectCoefficient</unmanaged>
        /// <unmanaged-short>LPFDirectCoefficient</unmanaged-short>
        public System.Single LpfDirectCoefficient;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_dsp_settings</doc-id>
        /// <unmanaged>LPFReverbCoefficient</unmanaged>
        /// <unmanaged-short>LPFReverbCoefficient</unmanaged-short>
        public System.Single LpfReverbCoefficient;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_dsp_settings</doc-id>
        /// <unmanaged>ReverbLevel</unmanaged>
        /// <unmanaged-short>ReverbLevel</unmanaged-short>
        public System.Single ReverbLevel;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_dsp_settings</doc-id>
        /// <unmanaged>DopplerFactor</unmanaged>
        /// <unmanaged-short>DopplerFactor</unmanaged-short>
        public System.Single DopplerFactor;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_dsp_settings</doc-id>
        /// <unmanaged>EmitterToListenerAngle</unmanaged>
        /// <unmanaged-short>EmitterToListenerAngle</unmanaged-short>
        public System.Single EmitterToListenerAngle;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_dsp_settings</doc-id>
        /// <unmanaged>EmitterToListenerDistance</unmanaged>
        /// <unmanaged-short>EmitterToListenerDistance</unmanaged-short>
        public System.Single EmitterToListenerDistance;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_dsp_settings</doc-id>
        /// <unmanaged>EmitterVelocityComponent</unmanaged>
        /// <unmanaged-short>EmitterVelocityComponent</unmanaged-short>
        public System.Single EmitterVelocityComponent;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_dsp_settings</doc-id>
        /// <unmanaged>ListenerVelocityComponent</unmanaged>
        /// <unmanaged-short>ListenerVelocityComponent</unmanaged-short>
        public System.Single ListenerVelocityComponent;
    }

    /// <summary>
    /// <p>Defines a single-point or multiple-point 3D audio source that is used with an arbitrary number of sound channels.</p>
    /// </summary>
    /// <remarks>
    /// <p><strong><see cref = "SharpDX.X3DAudio.Emitter"/></strong> only supports a cone in a single-point emitter. Multi-point emitters are a convenient and efficient way to manage a related group of sound sources. Many properties are shared among all channel points, such as Doppler?the same Doppler shift is applied to all channels in the emitter. Thus, the Doppler value need only be calculated once, not per-point as would be needed with multiple separate single-point emitters. Because <strong><see cref = "SharpDX.X3DAudio.Emitter"/></strong> only has one orientation vector, a multi-point emitter cone would be of limited usefulness, forcing all channels to behave as if they were facing the same direction. If multiple independent cones are needed, multiple single-point emitters should be used, each with its own orientation. </p><p>The parameter type <see cref = "SharpDX.Mathematics.Interop.RawVector3"/> is typed to DirectX::XMFLOAT3, to provide x , y , and z floating-point values. </p><p>X3DAudio uses a left-handed Cartesian coordinate system, with values on the x-axis increasing from left to right, on the y-axis from bottom to top, and on the z-axis from near to far. Azimuths are measured clockwise from a given reference direction. To use X3DAudio with right-handed coordinates, you must negate the .z element of <em>OrientFront</em>, <em>OrientTop</em>, <em>Position</em>, and <em>Velocity</em>.</p><p>For user-defined distance curves, the distance field of the first point must be 0.0f and the distance field of the last point must be 1.0f. </p><p>If an emitter moves beyond a distance of (<strong>CurveDistanceScaler</strong> ? 1.0f), the last point on the curve is used to compute the volume output level. The last point is determined by the following:
    /// </p><pre><see cref = "SharpDX.X3DAudio.DistanceCurve"/>.pPoints[PointCount-1].DSPSetting)</pre>
    /// </remarks>
    /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_emitter</doc-id>
    /// <unmanaged>X3DAUDIO_EMITTER</unmanaged>
    /// <unmanaged-short>X3DAUDIO_EMITTER</unmanaged-short>
    public partial class Emitter
    {
        /// <summary>
        /// <dd> <p>Pointer to a sound cone. Used only with single-channel emitters for matrix, LPF (both direct and reverb paths), and reverb calculations. <c>null</c> specifies the emitter is omnidirectional.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_emitter</doc-id>
        /// <unmanaged>pCone</unmanaged>
        /// <unmanaged-short>pCone</unmanaged-short>
        internal System.IntPtr ConePointer;
        /// <summary>
        /// <dd> <p>Orientation of the front direction. This value must be orthonormal with <strong>OrientTop</strong>. <strong>OrientFront</strong> must be normalized when used. For single-channel emitters without cones <strong>OrientFront</strong> is only used for emitter angle calculations. For multi channel emitters or single-channel with cones <strong>OrientFront</strong> is used for matrix, LPF (both direct and reverb paths), and reverb calculations.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_emitter</doc-id>
        /// <unmanaged>OrientFront</unmanaged>
        /// <unmanaged-short>OrientFront</unmanaged-short>
        public SharpDX.Mathematics.Interop.RawVector3 OrientFront;
        /// <summary>
        /// <dd> <p>Orientation of the top direction. This value must be orthonormal with <strong>OrientFront</strong>. <strong>OrientTop</strong> is only used with multi-channel emitters for matrix calculations.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_emitter</doc-id>
        /// <unmanaged>OrientTop</unmanaged>
        /// <unmanaged-short>OrientTop</unmanaged-short>
        public SharpDX.Mathematics.Interop.RawVector3 OrientTop;
        /// <summary>
        /// <dd> <p>Position in user-defined world units. This value does not affect <strong>Velocity</strong>.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_emitter</doc-id>
        /// <unmanaged>Position</unmanaged>
        /// <unmanaged-short>Position</unmanaged-short>
        public SharpDX.Mathematics.Interop.RawVector3 Position;
        /// <summary>
        /// <dd> <p>Velocity vector in user-defined world units/second. This value is used only for doppler calculations. It does not affect <strong>Position</strong>. 
        /// </p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_emitter</doc-id>
        /// <unmanaged>Velocity</unmanaged>
        /// <unmanaged-short>Velocity</unmanaged-short>
        public SharpDX.Mathematics.Interop.RawVector3 Velocity;
        /// <summary>
        /// <dd> <p>Value to be used for the inner radius calculations. If <strong>InnerRadius</strong> is 0, then no inner radius is used, but <strong>InnerRadiusAngle</strong> may still be used. This value must be between 0.0f and MAX_FLT. 
        /// </p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_emitter</doc-id>
        /// <unmanaged>InnerRadius</unmanaged>
        /// <unmanaged-short>InnerRadius</unmanaged-short>
        public System.Single InnerRadius;
        /// <summary>
        /// <dd> <p>Value to be used for the inner radius angle calculations. This value must be between 0.0f and X3DAUDIO_PI/4.0. </p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_emitter</doc-id>
        /// <unmanaged>InnerRadiusAngle</unmanaged>
        /// <unmanaged-short>InnerRadiusAngle</unmanaged-short>
        public System.Single InnerRadiusAngle;
        /// <summary>
        /// <dd> <p>Number of emitters defined by the <strong><see cref = "SharpDX.X3DAudio.Emitter"/></strong> structure. Must be greater than 0. </p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_emitter</doc-id>
        /// <unmanaged>ChannelCount</unmanaged>
        /// <unmanaged-short>ChannelCount</unmanaged-short>
        public System.Int32 ChannelCount;
        /// <summary>
        /// <dd> <p>Distance from <strong>Position</strong> that channels will be placed if <strong>ChannelCount</strong> is greater than 1. <strong>ChannelRadius</strong> is only used with multi-channel emitters for matrix calculations. Must be greater than or equal to 0.0f.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_emitter</doc-id>
        /// <unmanaged>ChannelRadius</unmanaged>
        /// <unmanaged-short>ChannelRadius</unmanaged-short>
        public System.Single ChannelRadius;
        /// <summary>
        /// <dd> <p>Table of channel positions, expressed as an azimuth in radians along the channel radius with respect to the front orientation vector in the plane orthogonal to the top orientation vector. An azimuth of X3DAUDIO_2PI specifies a channel is a low-frequency effects (LFE) channel. LFE channels are positioned at the emitter base and are calculated with respect to <strong>pLFECurve</strong> only, never <strong>pVolumeCurve</strong>. <strong>pChannelAzimuths</strong> must have at least <strong>ChannelCount</strong> elements, but can be <strong><c>null</c></strong> if <strong>ChannelCount</strong> = 1. The table values must be within 0.0f to X3DAUDIO_2PI. <strong>pChannelAzimuths</strong> is used with multi-channel emitters for matrix calculations. </p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_emitter</doc-id>
        /// <unmanaged>pChannelAzimuths</unmanaged>
        /// <unmanaged-short>pChannelAzimuths</unmanaged-short>
        internal System.IntPtr ChannelAzimuthsPointer;
        /// <summary>
        /// <dd> <p>Volume-level distance curve, which is used only for matrix calculations. <c>null</c> specifies a specialized default curve that conforms to the inverse square law, such that when distance is between 0.0f and <strong>CurveDistanceScaler</strong> ? 1.0f, no attenuation is applied. 
        /// When distance is greater than <strong>CurveDistanceScaler</strong> ? 1.0f, the amplification factor is (<strong>CurveDistanceScaler</strong> ? 1.0f)/distance. At a distance of <strong>CurveDistanceScaler</strong> ? 2.0f, the sound will be at half volume or -6 dB, at a distance of <strong>CurveDistanceScaler</strong> ? 4.0f, the sound will be at one quarter volume or -12 dB, and so on. <strong>pVolumeCurve</strong> and pLFECurve are independent of each other. <strong>pVolumeCurve</strong> does not affect <strong>LFE channel</strong> volume. </p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_emitter</doc-id>
        /// <unmanaged>pVolumeCurve</unmanaged>
        /// <unmanaged-short>pVolumeCurve</unmanaged-short>
        internal System.IntPtr VolumeCurvePointer;
        /// <summary>
        /// <dd> <p>LFE roll-off distance curve, or <c>null</c> to use default curve: [0.0f, <strong>CurveDistanceScaler</strong> ?1.0f], [<strong>CurveDistanceScaler</strong> ?1.0f, 0.0f]. A <c>null</c> value for <strong>pLFECurve</strong> specifies a default curve that conforms to the inverse square law with distances &lt;= <strong>CurveDistanceScaler</strong> clamped to no attenuation. 
        /// <strong>pVolumeCurve</strong> and <strong>pLFECurve</strong> are independent of each other. <strong>pLFECurve</strong> does not affect non LFE channel volume. </p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_emitter</doc-id>
        /// <unmanaged>pLFECurve</unmanaged>
        /// <unmanaged-short>pLFECurve</unmanaged-short>
        internal System.IntPtr LFECurvePointer;
        /// <summary>
        /// <dd> <p>Low-pass filter (LPF) direct-path coefficient distance curve, or <c>null</c> to use the default curve: [0.0f, 1.0f], [1.0f, 0.75f]. <strong>pLPFDirectCurve</strong> is only used for LPF direct-path calculations. 
        /// </p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_emitter</doc-id>
        /// <unmanaged>pLPFDirectCurve</unmanaged>
        /// <unmanaged-short>pLPFDirectCurve</unmanaged-short>
        internal System.IntPtr LPFDirectCurvePointer;
        /// <summary>
        /// <dd> <p>LPF reverb-path coefficient distance curve, or <c>null</c> to use default curve: [0.0f, 0.75f], [1.0f, 0.75f]. <strong>pLPFReverbCurve</strong> is only used for LPF reverb path calculations.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_emitter</doc-id>
        /// <unmanaged>pLPFReverbCurve</unmanaged>
        /// <unmanaged-short>pLPFReverbCurve</unmanaged-short>
        internal System.IntPtr LPFReverbCurvePointer;
        /// <summary>
        /// <dd> <p>Reverb send level distance curve, or <c>null</c> to use default curve: [0.0f, 1.0f], [1.0f, 0.0f]. </p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_emitter</doc-id>
        /// <unmanaged>pReverbCurve</unmanaged>
        /// <unmanaged-short>pReverbCurve</unmanaged-short>
        internal System.IntPtr ReverbCurvePointer;
        /// <summary>
        /// <dd> <p>Curve distance scaler that is used to scale normalized distance curves to user-defined world units, and/or to exaggerate their effect. This does not affect any other calculations. The value must be within the range FLT_MIN to FLT_MAX. <strong>CurveDistanceScaler</strong> is only used for matrix, LPF (both direct and reverb paths), and reverb calculations.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_emitter</doc-id>
        /// <unmanaged>CurveDistanceScaler</unmanaged>
        /// <unmanaged-short>CurveDistanceScaler</unmanaged-short>
        public System.Single CurveDistanceScaler;
        /// <summary>
        /// <dd> <p>Doppler shift scaler that is used to exaggerate Doppler shift effect. <strong>DopplerScaler</strong> is only used for Doppler calculations and does not affect any other calculations. The value must be within the range 0.0f to FLT_MAX.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_emitter</doc-id>
        /// <unmanaged>DopplerScaler</unmanaged>
        /// <unmanaged-short>DopplerScaler</unmanaged-short>
        public System.Single DopplerScaler;
    }

    /// <summary>
    /// <p>Defines a point of 3D audio reception.</p>
    /// </summary>
    /// <remarks>
    /// <p>X3DAudio uses a left-handed Cartesian coordinate system, with values on the x-axis increasing from left to right, on the y-axis from bottom to top, and on the z-axis from near to far. Azimuths are measured clockwise from a given reference direction. To use X3DAudio with right-handed coordinates, you must negate the .z element of <em>OrientFront</em>, <em>OrientTop</em>, <em>Position</em>, and <em>Velocity</em>.</p><p>The parameter type <strong><see cref = "SharpDX.Mathematics.Interop.RawVector3"/></strong> is typed to DirectX::XMFLOAT3, to provide x, y and z floating-point values. </p><p>A listener's front and top vectors must be orthonormal. To be considered orthonormal, a pair of vectors must have a magnitude of 1 +- 1x10-5 and a dot product of 0 +- 1x10-5. </p>
    /// </remarks>
    /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_listener</doc-id>
    /// <unmanaged>X3DAUDIO_LISTENER</unmanaged>
    /// <unmanaged-short>X3DAUDIO_LISTENER</unmanaged-short>
    public partial class Listener
    {
        /// <summary>
        /// <dd> <p>Orientation of front direction. When <strong>pCone</strong> is <c>null</c> <strong>OrientFront</strong> is used only for matrix and delay calculations. When <strong>pCone</strong> is not <c>null</c> <strong>OrientFront</strong> is used for matrix, LPF (both direct and reverb paths), and reverb calculations. This value must be orthonormal with <strong>OrientTop</strong> when used.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_listener</doc-id>
        /// <unmanaged>OrientFront</unmanaged>
        /// <unmanaged-short>OrientFront</unmanaged-short>
        public SharpDX.Mathematics.Interop.RawVector3 OrientFront;
        /// <summary>
        /// <dd> <p>Orientation of top direction, used only for matrix and delay calculations. This value must be orthonormal with <strong>OrientFront</strong> when used.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_listener</doc-id>
        /// <unmanaged>OrientTop</unmanaged>
        /// <unmanaged-short>OrientTop</unmanaged-short>
        public SharpDX.Mathematics.Interop.RawVector3 OrientTop;
        /// <summary>
        /// <dd> <p>Position in user-defined world units. This value does not affect <strong>Velocity</strong>.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_listener</doc-id>
        /// <unmanaged>Position</unmanaged>
        /// <unmanaged-short>Position</unmanaged-short>
        public SharpDX.Mathematics.Interop.RawVector3 Position;
        /// <summary>
        /// <dd> <p>Velocity vector in user-defined world units per second, used only for doppler calculations. This value does not affect <strong>Position</strong>.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_listener</doc-id>
        /// <unmanaged>Velocity</unmanaged>
        /// <unmanaged-short>Velocity</unmanaged-short>
        public SharpDX.Mathematics.Interop.RawVector3 Velocity;
        /// <summary>
        /// <dd> <p>Pointer to an <strong><see cref = "SharpDX.X3DAudio.Cone"/></strong> structure for this listener. Providing a listener cone will specify that additional calculations are performed when determining the volume and filter DSP parameters for individual sound sources. A <c>null</c> <strong>pCone</strong> value specifies an omnidirectional sound and no cone processing is applied. <strong>pCone</strong> is only used for matrix, LPF (both direct and reverb paths), and reverb calculations.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.x3daudio.x3daudio_listener</doc-id>
        /// <unmanaged>pCone</unmanaged>
        /// <unmanaged-short>pCone</unmanaged-short>
        internal System.IntPtr ConePointer;
    }
}