namespace MentorLake.Pango;

/// <summary>
/// <para>
/// A `PangoMatrix` specifies a transformation between user-space
/// and device coordinates.
/// </para>
/// <para>
/// The transformation is given by
/// </para>
/// <para>
/// ```
/// x_device = x_user * matrix->xx + y_user * matrix->xy + matrix->x0;
/// y_device = x_user * matrix->yx + y_user * matrix->yy + matrix->y0;
/// ```
/// </para>
/// </summary>

public class PangoMatrixHandle : BaseSafeHandle
{
}


public static class PangoMatrixExtensions
{
/// <summary>
/// <para>
/// Changes the transformation represented by @matrix to be the
/// transformation given by first applying transformation
/// given by @new_matrix then applying the original transformation.
/// </para>
/// </summary>

/// <param name="matrix">
/// a `PangoMatrix`
/// </param>
/// <param name="new_matrix">
/// a `PangoMatrix`
/// </param>

	public static void Concat(this MentorLake.Pango.PangoMatrixHandle matrix, MentorLake.Pango.PangoMatrixHandle new_matrix)
	{
		if (matrix.IsInvalid) throw new Exception("Invalid handle (PangoMatrix)");
		PangoMatrixExterns.pango_matrix_concat(matrix, new_matrix);
	}

/// <summary>
/// <para>
/// Copies a `PangoMatrix`.
/// </para>
/// </summary>

/// <param name="matrix">
/// a `PangoMatrix`
/// </param>
/// <return>
/// the newly allocated `PangoMatrix`
/// </return>

	public static MentorLake.Pango.PangoMatrixHandle Copy(this MentorLake.Pango.PangoMatrixHandle matrix)
	{
		if (matrix.IsInvalid) throw new Exception("Invalid handle (PangoMatrix)");
		return PangoMatrixExterns.pango_matrix_copy(matrix);
	}

/// <summary>
/// <para>
/// Free a `PangoMatrix`.
/// </para>
/// </summary>

/// <param name="matrix">
/// a `PangoMatrix`, may be %NULL
/// </param>

	public static void Free(this MentorLake.Pango.PangoMatrixHandle matrix)
	{
		if (matrix.IsInvalid) throw new Exception("Invalid handle (PangoMatrix)");
		PangoMatrixExterns.pango_matrix_free(matrix);
	}

/// <summary>
/// <para>
/// Returns the scale factor of a matrix on the height of the font.
/// </para>
/// <para>
/// That is, the scale factor in the direction perpendicular to the
/// vector that the X coordinate is mapped to.  If the scale in the X
/// coordinate is needed as well, use [method@Pango.Matrix.get_font_scale_factors].
/// </para>
/// </summary>

/// <param name="matrix">
/// a `PangoMatrix`, may be %NULL
/// </param>
/// <return>
/// the scale factor of @matrix on the height of the font,
///   or 1.0 if @matrix is %NULL.
/// </return>

	public static double GetFontScaleFactor(this MentorLake.Pango.PangoMatrixHandle matrix)
	{
		if (matrix.IsInvalid) throw new Exception("Invalid handle (PangoMatrix)");
		return PangoMatrixExterns.pango_matrix_get_font_scale_factor(matrix);
	}

/// <summary>
/// <para>
/// Calculates the scale factor of a matrix on the width and height of the font.
/// </para>
/// <para>
/// That is, @xscale is the scale factor in the direction of the X coordinate,
/// and @yscale is the scale factor in the direction perpendicular to the
/// vector that the X coordinate is mapped to.
/// </para>
/// <para>
/// Note that output numbers will always be non-negative.
/// </para>
/// </summary>

/// <param name="matrix">
/// a `PangoMatrix`
/// </param>
/// <param name="xscale">
/// output scale factor in the x direction
/// </param>
/// <param name="yscale">
/// output scale factor perpendicular to the x direction
/// </param>

	public static void GetFontScaleFactors(this MentorLake.Pango.PangoMatrixHandle matrix, out double xscale, out double yscale)
	{
		if (matrix.IsInvalid) throw new Exception("Invalid handle (PangoMatrix)");
		PangoMatrixExterns.pango_matrix_get_font_scale_factors(matrix, out xscale, out yscale);
	}

/// <summary>
/// <para>
/// Gets the slant ratio of a matrix.
/// </para>
/// <para>
/// For a simple shear matrix in the form:
/// </para>
/// <para>
///     1 λ
///     0 1
/// </para>
/// <para>
/// this is simply λ.
/// </para>
/// </summary>

/// <param name="matrix">
/// a `PangoMatrix`
/// </param>
/// <return>
/// the slant ratio of @matrix
/// </return>

	public static double GetSlantRatio(this MentorLake.Pango.PangoMatrixHandle matrix)
	{
		if (matrix.IsInvalid) throw new Exception("Invalid handle (PangoMatrix)");
		return PangoMatrixExterns.pango_matrix_get_slant_ratio(matrix);
	}

/// <summary>
/// <para>
/// Changes the transformation represented by @matrix to be the
/// transformation given by first rotating by @degrees degrees
/// counter-clockwise then applying the original transformation.
/// </para>
/// </summary>

/// <param name="matrix">
/// a `PangoMatrix`
/// </param>
/// <param name="degrees">
/// degrees to rotate counter-clockwise
/// </param>

	public static void Rotate(this MentorLake.Pango.PangoMatrixHandle matrix, double degrees)
	{
		if (matrix.IsInvalid) throw new Exception("Invalid handle (PangoMatrix)");
		PangoMatrixExterns.pango_matrix_rotate(matrix, degrees);
	}

/// <summary>
/// <para>
/// Changes the transformation represented by @matrix to be the
/// transformation given by first scaling by @sx in the X direction
/// and @sy in the Y direction then applying the original
/// transformation.
/// </para>
/// </summary>

/// <param name="matrix">
/// a `PangoMatrix`
/// </param>
/// <param name="scale_x">
/// amount to scale by in X direction
/// </param>
/// <param name="scale_y">
/// amount to scale by in Y direction
/// </param>

	public static void Scale(this MentorLake.Pango.PangoMatrixHandle matrix, double scale_x, double scale_y)
	{
		if (matrix.IsInvalid) throw new Exception("Invalid handle (PangoMatrix)");
		PangoMatrixExterns.pango_matrix_scale(matrix, scale_x, scale_y);
	}

/// <summary>
/// <para>
/// Transforms the distance vector (@dx,@dy) by @matrix.
/// </para>
/// <para>
/// This is similar to [method@Pango.Matrix.transform_point],
/// except that the translation components of the transformation
/// are ignored. The calculation of the returned vector is as follows:
/// </para>
/// <para>
/// ```
/// dx2 = dx1 * xx + dy1 * xy;
/// dy2 = dx1 * yx + dy1 * yy;
/// ```
/// </para>
/// <para>
/// Affine transformations are position invariant, so the same vector
/// always transforms to the same vector. If (@x1,@y1) transforms
/// to (@x2,@y2) then (@x1+@dx1,@y1+@dy1) will transform to
/// (@x1+@dx2,@y1+@dy2) for all values of @x1 and @x2.
/// </para>
/// </summary>

/// <param name="matrix">
/// a `PangoMatrix`
/// </param>
/// <param name="dx">
/// in/out X component of a distance vector
/// </param>
/// <param name="dy">
/// in/out Y component of a distance vector
/// </param>

	public static void TransformDistance(this MentorLake.Pango.PangoMatrixHandle matrix, ref double dx, ref double dy)
	{
		if (matrix.IsInvalid) throw new Exception("Invalid handle (PangoMatrix)");
		PangoMatrixExterns.pango_matrix_transform_distance(matrix, ref dx, ref dy);
	}

/// <summary>
/// <para>
/// First transforms the @rect using @matrix, then calculates the bounding box
/// of the transformed rectangle.
/// </para>
/// <para>
/// This function is useful for example when you want to draw a rotated
/// @PangoLayout to an image buffer, and want to know how large the image
/// should be and how much you should shift the layout when rendering.
/// </para>
/// <para>
/// For better accuracy, you should use [method@Pango.Matrix.transform_rectangle]
/// on original rectangle in Pango units and convert to pixels afterward
/// using [func@extents_to_pixels]'s first argument.
/// </para>
/// </summary>

/// <param name="matrix">
/// a `PangoMatrix`
/// </param>
/// <param name="rect">
/// in/out bounding box in device units
/// </param>

	public static void TransformPixelRectangle(this MentorLake.Pango.PangoMatrixHandle matrix, ref MentorLake.Pango.PangoRectangle rect)
	{
		if (matrix.IsInvalid) throw new Exception("Invalid handle (PangoMatrix)");
		PangoMatrixExterns.pango_matrix_transform_pixel_rectangle(matrix, ref rect);
	}

/// <summary>
/// <para>
/// Transforms the point (@x, @y) by @matrix.
/// </para>
/// </summary>

/// <param name="matrix">
/// a `PangoMatrix`
/// </param>
/// <param name="x">
/// in/out X position
/// </param>
/// <param name="y">
/// in/out Y position
/// </param>

	public static void TransformPoint(this MentorLake.Pango.PangoMatrixHandle matrix, ref double x, ref double y)
	{
		if (matrix.IsInvalid) throw new Exception("Invalid handle (PangoMatrix)");
		PangoMatrixExterns.pango_matrix_transform_point(matrix, ref x, ref y);
	}

/// <summary>
/// <para>
/// First transforms @rect using @matrix, then calculates the bounding box
/// of the transformed rectangle.
/// </para>
/// <para>
/// This function is useful for example when you want to draw a rotated
/// @PangoLayout to an image buffer, and want to know how large the image
/// should be and how much you should shift the layout when rendering.
/// </para>
/// <para>
/// If you have a rectangle in device units (pixels), use
/// [method@Pango.Matrix.transform_pixel_rectangle].
/// </para>
/// <para>
/// If you have the rectangle in Pango units and want to convert to
/// transformed pixel bounding box, it is more accurate to transform it first
/// (using this function) and pass the result to pango_extents_to_pixels(),
/// first argument, for an inclusive rounded rectangle.
/// However, there are valid reasons that you may want to convert
/// to pixels first and then transform, for example when the transformed
/// coordinates may overflow in Pango units (large matrix translation for
/// example).
/// </para>
/// </summary>

/// <param name="matrix">
/// a `PangoMatrix`
/// </param>
/// <param name="rect">
/// in/out bounding box in Pango units
/// </param>

	public static void TransformRectangle(this MentorLake.Pango.PangoMatrixHandle matrix, ref MentorLake.Pango.PangoRectangle rect)
	{
		if (matrix.IsInvalid) throw new Exception("Invalid handle (PangoMatrix)");
		PangoMatrixExterns.pango_matrix_transform_rectangle(matrix, ref rect);
	}

/// <summary>
/// <para>
/// Changes the transformation represented by @matrix to be the
/// transformation given by first translating by (@tx, @ty)
/// then applying the original transformation.
/// </para>
/// </summary>

/// <param name="matrix">
/// a `PangoMatrix`
/// </param>
/// <param name="tx">
/// amount to translate in the X direction
/// </param>
/// <param name="ty">
/// amount to translate in the Y direction
/// </param>

	public static void Translate(this MentorLake.Pango.PangoMatrixHandle matrix, double tx, double ty)
	{
		if (matrix.IsInvalid) throw new Exception("Invalid handle (PangoMatrix)");
		PangoMatrixExterns.pango_matrix_translate(matrix, tx, ty);
	}


	public static PangoMatrix Dereference(this PangoMatrixHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoMatrix>(x.DangerousGetHandle());
}
internal class PangoMatrixExterns
{
	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_matrix_concat([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoMatrixHandle>))] MentorLake.Pango.PangoMatrixHandle matrix, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoMatrixHandle>))] MentorLake.Pango.PangoMatrixHandle new_matrix);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoMatrixHandle>))]
	internal static extern MentorLake.Pango.PangoMatrixHandle pango_matrix_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoMatrixHandle>))] MentorLake.Pango.PangoMatrixHandle matrix);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_matrix_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoMatrixHandle>))] MentorLake.Pango.PangoMatrixHandle matrix);

	[DllImport(PangoLibrary.Name)]
	internal static extern double pango_matrix_get_font_scale_factor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoMatrixHandle>))] MentorLake.Pango.PangoMatrixHandle matrix);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_matrix_get_font_scale_factors([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoMatrixHandle>))] MentorLake.Pango.PangoMatrixHandle matrix, out double xscale, out double yscale);

	[DllImport(PangoLibrary.Name)]
	internal static extern double pango_matrix_get_slant_ratio([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoMatrixHandle>))] MentorLake.Pango.PangoMatrixHandle matrix);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_matrix_rotate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoMatrixHandle>))] MentorLake.Pango.PangoMatrixHandle matrix, double degrees);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_matrix_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoMatrixHandle>))] MentorLake.Pango.PangoMatrixHandle matrix, double scale_x, double scale_y);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_matrix_transform_distance([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoMatrixHandle>))] MentorLake.Pango.PangoMatrixHandle matrix, ref double dx, ref double dy);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_matrix_transform_pixel_rectangle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoMatrixHandle>))] MentorLake.Pango.PangoMatrixHandle matrix, ref MentorLake.Pango.PangoRectangle rect);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_matrix_transform_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoMatrixHandle>))] MentorLake.Pango.PangoMatrixHandle matrix, ref double x, ref double y);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_matrix_transform_rectangle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoMatrixHandle>))] MentorLake.Pango.PangoMatrixHandle matrix, ref MentorLake.Pango.PangoRectangle rect);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_matrix_translate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoMatrixHandle>))] MentorLake.Pango.PangoMatrixHandle matrix, double tx, double ty);

}

/// <summary>
/// <para>
/// A `PangoMatrix` specifies a transformation between user-space
/// and device coordinates.
/// </para>
/// <para>
/// The transformation is given by
/// </para>
/// <para>
/// ```
/// x_device = x_user * matrix->xx + y_user * matrix->xy + matrix->x0;
/// y_device = x_user * matrix->yx + y_user * matrix->yy + matrix->y0;
/// ```
/// </para>
/// </summary>

public struct PangoMatrix
{
	/// <summary>
/// <para>
/// 1st component of the transformation matrix
/// </para>
/// </summary>

public double xx;
	/// <summary>
/// <para>
/// 2nd component of the transformation matrix
/// </para>
/// </summary>

public double xy;
	/// <summary>
/// <para>
/// 3rd component of the transformation matrix
/// </para>
/// </summary>

public double yx;
	/// <summary>
/// <para>
/// 4th component of the transformation matrix
/// </para>
/// </summary>

public double yy;
	/// <summary>
/// <para>
/// x translation
/// </para>
/// </summary>

public double x0;
	/// <summary>
/// <para>
/// y translation
/// </para>
/// </summary>

public double y0;
}
