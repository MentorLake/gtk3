namespace MentorLake.Pango;

public class PangoMatrixHandle : BaseSafeHandle
{
}


public static class PangoMatrixExtensions
{
	public static void Concat(this MentorLake.Pango.PangoMatrixHandle matrix, MentorLake.Pango.PangoMatrixHandle new_matrix)
	{
		if (matrix.IsInvalid) throw new Exception("Invalid handle (PangoMatrix)");
		PangoMatrixExterns.pango_matrix_concat(matrix, new_matrix);
	}

	public static MentorLake.Pango.PangoMatrixHandle Copy(this MentorLake.Pango.PangoMatrixHandle matrix)
	{
		if (matrix.IsInvalid) throw new Exception("Invalid handle (PangoMatrix)");
		return PangoMatrixExterns.pango_matrix_copy(matrix);
	}

	public static void Free(this MentorLake.Pango.PangoMatrixHandle matrix)
	{
		if (matrix.IsInvalid) throw new Exception("Invalid handle (PangoMatrix)");
		PangoMatrixExterns.pango_matrix_free(matrix);
	}

	public static double GetFontScaleFactor(this MentorLake.Pango.PangoMatrixHandle matrix)
	{
		if (matrix.IsInvalid) throw new Exception("Invalid handle (PangoMatrix)");
		return PangoMatrixExterns.pango_matrix_get_font_scale_factor(matrix);
	}

	public static void GetFontScaleFactors(this MentorLake.Pango.PangoMatrixHandle matrix, out double xscale, out double yscale)
	{
		if (matrix.IsInvalid) throw new Exception("Invalid handle (PangoMatrix)");
		PangoMatrixExterns.pango_matrix_get_font_scale_factors(matrix, out xscale, out yscale);
	}

	public static double GetSlantRatio(this MentorLake.Pango.PangoMatrixHandle matrix)
	{
		if (matrix.IsInvalid) throw new Exception("Invalid handle (PangoMatrix)");
		return PangoMatrixExterns.pango_matrix_get_slant_ratio(matrix);
	}

	public static void Rotate(this MentorLake.Pango.PangoMatrixHandle matrix, double degrees)
	{
		if (matrix.IsInvalid) throw new Exception("Invalid handle (PangoMatrix)");
		PangoMatrixExterns.pango_matrix_rotate(matrix, degrees);
	}

	public static void Scale(this MentorLake.Pango.PangoMatrixHandle matrix, double scale_x, double scale_y)
	{
		if (matrix.IsInvalid) throw new Exception("Invalid handle (PangoMatrix)");
		PangoMatrixExterns.pango_matrix_scale(matrix, scale_x, scale_y);
	}

	public static void TransformDistance(this MentorLake.Pango.PangoMatrixHandle matrix, ref double dx, ref double dy)
	{
		if (matrix.IsInvalid) throw new Exception("Invalid handle (PangoMatrix)");
		PangoMatrixExterns.pango_matrix_transform_distance(matrix, ref dx, ref dy);
	}

	public static void TransformPixelRectangle(this MentorLake.Pango.PangoMatrixHandle matrix, ref MentorLake.Pango.PangoRectangle rect)
	{
		if (matrix.IsInvalid) throw new Exception("Invalid handle (PangoMatrix)");
		PangoMatrixExterns.pango_matrix_transform_pixel_rectangle(matrix, ref rect);
	}

	public static void TransformPoint(this MentorLake.Pango.PangoMatrixHandle matrix, ref double x, ref double y)
	{
		if (matrix.IsInvalid) throw new Exception("Invalid handle (PangoMatrix)");
		PangoMatrixExterns.pango_matrix_transform_point(matrix, ref x, ref y);
	}

	public static void TransformRectangle(this MentorLake.Pango.PangoMatrixHandle matrix, ref MentorLake.Pango.PangoRectangle rect)
	{
		if (matrix.IsInvalid) throw new Exception("Invalid handle (PangoMatrix)");
		PangoMatrixExterns.pango_matrix_transform_rectangle(matrix, ref rect);
	}

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

public struct PangoMatrix
{
	public double xx;
	public double xy;
	public double yx;
	public double yy;
	public double x0;
	public double y0;
}
