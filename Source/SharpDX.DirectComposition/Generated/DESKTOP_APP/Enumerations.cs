// <auto-generated/>

namespace SharpDX.DirectComposition
{
    /// <summary>
    /// <p>Specifies the backface visibility to be applied to a visual.  </p>
    /// </summary>
    /// <doc-id>dn280348</doc-id>
    /// <unmanaged>DCOMPOSITION_BACKFACE_VISIBILITY</unmanaged>
    /// <unmanaged-short>DCOMPOSITION_BACKFACE_VISIBILITY</unmanaged-short>
    public enum BackFaceVisibility : System.Int32
    {
        /// <summary>
        /// <dd> <p>Surfaces in this visual's sub-tree are visible regardless of transformation.</p> </dd>
        /// </summary>
        /// <doc-id>dn280348</doc-id>
        /// <unmanaged>DCOMPOSITION_BACKFACE_VISIBILITY_VISIBLE</unmanaged>
        /// <unmanaged-short>DCOMPOSITION_BACKFACE_VISIBILITY_VISIBLE</unmanaged-short>
        Visible = unchecked ((System.Int32)(0)),
        /// <summary>
        /// <dd> <p>Surfaces in this visual's sub-tree are only visible when facing the observer.</p> </dd>
        /// </summary>
        /// <doc-id>dn280348</doc-id>
        /// <unmanaged>DCOMPOSITION_BACKFACE_VISIBILITY_HIDDEN</unmanaged>
        /// <unmanaged-short>DCOMPOSITION_BACKFACE_VISIBILITY_HIDDEN</unmanaged-short>
        Hidden = unchecked ((System.Int32)(1)),
        /// <summary>
        /// <dd> <p>The back face visibility is the same as that of the target visual's parent visual.</p> </dd>
        /// </summary>
        /// <doc-id>dn280348</doc-id>
        /// <unmanaged>DCOMPOSITION_BACKFACE_VISIBILITY_INHERIT</unmanaged>
        /// <unmanaged-short>DCOMPOSITION_BACKFACE_VISIBILITY_INHERIT</unmanaged-short>
        Inherit = unchecked ((System.Int32)(-1))}

    /// <summary>
    /// <p>Specifies the interpolation mode to be used when a bitmap is composed with any transform where the pixels in the bitmap don't line up exactly one-to-one with pixels on screen. </p>
    /// </summary>
    /// <remarks>
    /// <p>The default interpolation mode for a visual is <strong>DCOMPOSITION_BITMAP_INTERPOLATION_MODE_INHERIT</strong>. If all visuals in a visual tree specify this mode, the default for all visuals is nearest neighbor sampling, which is the fastest mode.</p><p>A single visual can have any combination of visual properties. However, if a 
    /// visual has the following combination of properties, the borders of the visual will default 
    /// to <strong>DCOMPOSITION_BORDER_MODE_HARD</strong>. </p><ul> <li><code>SetCompositeMode(DCOMPOSITION_COMPOSITE_MODE_DESTINATION_INVERT)
    /// </code></li> <li><code>SetBorderMode(DCOMPOSITION_BORDER_MODE_SOFT) 
    /// </code></li> <li><code>SetBitmapInterpolationMode(DCOMPOSITION_BITMAP_INTERPOLATION_MODE_NEAREST_NEIGHBOR)</code></li> </ul><p>If you want a visual to be drawn with antialiasing, use <strong>DCOMPOSITION_BITMAP_INTERPOLATION_MODE_LINEAR</strong> for the content of the visual, and <strong>DCOMPOSITION_BORDER_MODE_SOFT</strong> for the edges.
    /// </p>
    /// </remarks>
    /// <doc-id>hh437364</doc-id>
    /// <unmanaged>DCOMPOSITION_BITMAP_INTERPOLATION_MODE</unmanaged>
    /// <unmanaged-short>DCOMPOSITION_BITMAP_INTERPOLATION_MODE</unmanaged-short>
    public enum BitmapInterpolationMode : System.Int32
    {
        /// <summary>
        /// <dd> <p>Bitmaps are interpolated by using nearest-neighbor sampling.</p> </dd>
        /// </summary>
        /// <doc-id>hh437364</doc-id>
        /// <unmanaged>DCOMPOSITION_BITMAP_INTERPOLATION_MODE_NEAREST_NEIGHBOR</unmanaged>
        /// <unmanaged-short>DCOMPOSITION_BITMAP_INTERPOLATION_MODE_NEAREST_NEIGHBOR</unmanaged-short>
        NearestNeighbor = unchecked ((System.Int32)(0)),
        /// <summary>
        /// <dd> <p>Bitmaps are interpolated by using linear sampling.</p> </dd>
        /// </summary>
        /// <doc-id>hh437364</doc-id>
        /// <unmanaged>DCOMPOSITION_BITMAP_INTERPOLATION_MODE_LINEAR</unmanaged>
        /// <unmanaged-short>DCOMPOSITION_BITMAP_INTERPOLATION_MODE_LINEAR</unmanaged-short>
        Linear = unchecked ((System.Int32)(1)),
        /// <summary>
        /// <dd> <p>Bitmaps are interpolated according to the mode established by the parent visual.</p> </dd>
        /// </summary>
        /// <doc-id>hh437364</doc-id>
        /// <unmanaged>DCOMPOSITION_BITMAP_INTERPOLATION_MODE_INHERIT</unmanaged>
        /// <unmanaged-short>DCOMPOSITION_BITMAP_INTERPOLATION_MODE_INHERIT</unmanaged-short>
        Inherit = unchecked ((System.Int32)(-1))}

    /// <summary>
    /// <p>Specifies the border mode to use when composing a bitmap or applying a clip with any transform such that the edges of the bitmap or clip are not axis-aligned with integer coordinates. </p>
    /// </summary>
    /// <remarks>
    /// <p>The default border mode for any given visual is <strong>DCOMPOSITION_BORDER_MODE_INHERIT</strong>, which delegates the determination of the border mode to the parent visual. If all visuals in a visual tree specify this mode, the default for all visuals is aliased rendering, which is the fastest mode.</p><p>A single visual can have any combination of visual properties. However, if a 
    /// visual has the following combination of properties, the borders of the visual will default 
    /// to <strong>DCOMPOSITION_BORDER_MODE_HARD</strong>. </p><ul> <li><code>SetCompositeMode(DCOMPOSITION_COMPOSITE_MODE_DESTINATION_INVERT)
    /// </code></li> <li><code>SetBorderMode(DCOMPOSITION_BORDER_MODE_SOFT) 
    /// </code></li> <li><code>SetBitmapInterpolationMode(DCOMPOSITION_BITMAP_INTERPOLATION_MODE_NEAREST_NEIGHBOR)</code></li> </ul><p>If you want a visual to be drawn with antialiasing, use <strong>DCOMPOSITION_BITMAP_INTERPOLATION_MODE_LINEAR</strong> for the content of the visual, and <strong>DCOMPOSITION_BORDER_MODE_SOFT</strong> for the edges.
    /// </p>
    /// </remarks>
    /// <doc-id>hh437365</doc-id>
    /// <unmanaged>DCOMPOSITION_BORDER_MODE</unmanaged>
    /// <unmanaged-short>DCOMPOSITION_BORDER_MODE</unmanaged-short>
    public enum BorderMode : System.Int32
    {
        /// <summary>
        /// <dd> <p>Bitmap and clip edges are antialiased.</p> </dd>
        /// </summary>
        /// <doc-id>hh437365</doc-id>
        /// <unmanaged>DCOMPOSITION_BORDER_MODE_SOFT</unmanaged>
        /// <unmanaged-short>DCOMPOSITION_BORDER_MODE_SOFT</unmanaged-short>
        Soft = unchecked ((System.Int32)(0)),
        /// <summary>
        /// <dd> <p>Bitmap and clip edges are aliased. See Remarks.</p> </dd>
        /// </summary>
        /// <doc-id>hh437365</doc-id>
        /// <unmanaged>DCOMPOSITION_BORDER_MODE_HARD</unmanaged>
        /// <unmanaged-short>DCOMPOSITION_BORDER_MODE_HARD</unmanaged-short>
        Hard = unchecked ((System.Int32)(1)),
        /// <summary>
        /// <dd> <p>Bitmap and clip edges are drawn according to the mode established by the parent visual.</p> </dd>
        /// </summary>
        /// <doc-id>hh437365</doc-id>
        /// <unmanaged>DCOMPOSITION_BORDER_MODE_INHERIT</unmanaged>
        /// <unmanaged-short>DCOMPOSITION_BORDER_MODE_INHERIT</unmanaged-short>
        Inherit = unchecked ((System.Int32)(-1))}

    /// <summary>
    /// <p>The mode to use to blend the bitmap content of a visual with  the render target.</p>
    /// </summary>
    /// <remarks>
    /// <p>A single visual can have any combination of visual properties. However, if a 
    /// visual has the following combination of properties, the borders of the visual will default 
    /// to <strong>DCOMPOSITION_BORDER_MODE_HARD</strong>. </p><ul> <li><code>SetCompositeMode(DCOMPOSITION_COMPOSITE_MODE_DESTINATION_INVERT)
    /// </code></li> <li><code>SetBorderMode(DCOMPOSITION_BORDER_MODE_SOFT) 
    /// </code></li> <li><code>SetBitmapInterpolationMode(DCOMPOSITION_BITMAP_INTERPOLATION_MODE_NEAREST_NEIGHBOR)</code></li> </ul><p>If you want a visual to be drawn with antialiasing, use <strong>DCOMPOSITION_BITMAP_INTERPOLATION_MODE_LINEAR</strong> for the content of the visual, and <strong>DCOMPOSITION_BORDER_MODE_SOFT</strong> for the edges.
    /// </p>
    /// </remarks>
    /// <doc-id>hh802900</doc-id>
    /// <unmanaged>DCOMPOSITION_COMPOSITE_MODE</unmanaged>
    /// <unmanaged-short>DCOMPOSITION_COMPOSITE_MODE</unmanaged-short>
    public enum CompositeMode : System.Int32
    {
        /// <summary>
        /// <dd> <p>The standard source-over-destination blend mode.</p> </dd>
        /// </summary>
        /// <doc-id>hh802900</doc-id>
        /// <unmanaged>DCOMPOSITION_COMPOSITE_MODE_SOURCE_OVER</unmanaged>
        /// <unmanaged-short>DCOMPOSITION_COMPOSITE_MODE_SOURCE_OVER</unmanaged-short>
        SourceOver = unchecked ((System.Int32)(0)),
        /// <summary>
        /// <dd> <p>The bitmap colors are inverted.  </p> </dd>
        /// </summary>
        /// <doc-id>hh802900</doc-id>
        /// <unmanaged>DCOMPOSITION_COMPOSITE_MODE_DESTINATION_INVERT</unmanaged>
        /// <unmanaged-short>DCOMPOSITION_COMPOSITE_MODE_DESTINATION_INVERT</unmanaged-short>
        DestinationInvert = unchecked ((System.Int32)(1)),
        /// <summary>
        /// <dd> <p>Bitmap colors subtract for color channels in the background.  </p> </dd>
        /// </summary>
        /// <doc-id>hh802900</doc-id>
        /// <unmanaged>DCOMPOSITION_COMPOSITE_MODE_MIN_BLEND</unmanaged>
        /// <unmanaged-short>DCOMPOSITION_COMPOSITE_MODE_MIN_BLEND</unmanaged-short>
        MinimumBlend = unchecked ((System.Int32)(2)),
        /// <summary>
        /// <dd> <p>Bitmaps are blended according to the mode established by the parent visual. </p> </dd>
        /// </summary>
        /// <doc-id>hh802900</doc-id>
        /// <unmanaged>DCOMPOSITION_COMPOSITE_MODE_INHERIT</unmanaged>
        /// <unmanaged-short>DCOMPOSITION_COMPOSITE_MODE_INHERIT</unmanaged-short>
        Inherit = unchecked ((System.Int32)(-1))}

    /// <summary>
    /// <p>Sets the depth mode property associated with this visual.</p>
    /// </summary>
    /// <doc-id>mt589904</doc-id>
    /// <unmanaged>DCOMPOSITION_DEPTH_MODE</unmanaged>
    /// <unmanaged-short>DCOMPOSITION_DEPTH_MODE</unmanaged-short>
    public enum DepthMode : System.Int32
    {
        /// <summary>
        /// <dd>  <p>The new depth mode.</p> </dd>
        /// </summary>
        /// <doc-id>mt589904</doc-id>
        /// <unmanaged>DCOMPOSITION_DEPTH_MODE_TREE</unmanaged>
        /// <unmanaged-short>DCOMPOSITION_DEPTH_MODE_TREE</unmanaged-short>
        Tree = unchecked ((System.Int32)(0)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <doc-id>mt589904</doc-id>
        /// <unmanaged>DCOMPOSITION_DEPTH_MODE_SPATIAL</unmanaged>
        /// <unmanaged-short>DCOMPOSITION_DEPTH_MODE_SPATIAL</unmanaged-short>
        Spatial = unchecked ((System.Int32)(1)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <doc-id>mt589904</doc-id>
        /// <unmanaged>DCOMPOSITION_DEPTH_MODE_SORTED</unmanaged>
        /// <unmanaged-short>DCOMPOSITION_DEPTH_MODE_SORTED</unmanaged-short>
        SortEd = unchecked ((System.Int32)(3)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <doc-id>mt589904</doc-id>
        /// <unmanaged>DCOMPOSITION_DEPTH_MODE_INHERIT</unmanaged>
        /// <unmanaged-short>DCOMPOSITION_DEPTH_MODE_INHERIT</unmanaged-short>
        Inherit = unchecked ((System.Int32)(-1))}

    /// <summary>
    /// <p>Specifies how the effective opacity value of a visual is applied to that visual?s content and children.</p>
    /// </summary>
    /// <doc-id>dn280349</doc-id>
    /// <unmanaged>DCOMPOSITION_OPACITY_MODE</unmanaged>
    /// <unmanaged-short>DCOMPOSITION_OPACITY_MODE</unmanaged-short>
    public enum OpacityMode : System.Int32
    {
        /// <summary>
        /// <dd> <p>The target visual defines a logical layer into which its entire sub-tree is composed with a starting effective opacity of 1.0. The original opacity value is then used to blend the layer onto the visual?s background.</p> </dd>
        /// </summary>
        /// <doc-id>dn280349</doc-id>
        /// <unmanaged>DCOMPOSITION_OPACITY_MODE_LAYER</unmanaged>
        /// <unmanaged-short>DCOMPOSITION_OPACITY_MODE_LAYER</unmanaged-short>
        Layer = unchecked ((System.Int32)(0)),
        /// <summary>
        /// <dd> <p>The opacity value is multiplied with the effective opacity of the parent visual and the result is then individually applied to each piece of content in this visual?s sub-tree.</p> </dd>
        /// </summary>
        /// <doc-id>dn280349</doc-id>
        /// <unmanaged>DCOMPOSITION_OPACITY_MODE_MULTIPLY</unmanaged>
        /// <unmanaged-short>DCOMPOSITION_OPACITY_MODE_MULTIPLY</unmanaged-short>
        Multiply = unchecked ((System.Int32)(1)),
        /// <summary>
        /// <dd> <p>The opacity mode is the same as that of the target visual?s parent visual.</p> </dd>
        /// </summary>
        /// <doc-id>dn280349</doc-id>
        /// <unmanaged>DCOMPOSITION_OPACITY_MODE_INHERIT</unmanaged>
        /// <unmanaged-short>DCOMPOSITION_OPACITY_MODE_INHERIT</unmanaged-short>
        Inherit = unchecked ((System.Int32)(-1))}
}