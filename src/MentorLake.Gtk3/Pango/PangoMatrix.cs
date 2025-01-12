namespace MentorLake.Gtk3.Pango;

public class PangoMatrixHandle : BaseSafeHandle
{
}


public static class PangoMatrixHandleExtensions
{
	public static T Concat<T>(this T matrix, PangoMatrixHandle new_matrix) where T : PangoMatrixHandle
	{
		PangoMatrixExterns.pango_matrix_concat(matrix, new_matrix);
		return matrix;
	}

	public static PangoMatrixHandle Copy(this PangoMatrixHandle matrix)
	{
		return PangoMatrixExterns.pango_matrix_copy(matrix);
	}

	public static T Free<T>(this T matrix) where T : PangoMatrixHandle
	{
		PangoMatrixExterns.pango_matrix_free(matrix);
		return matrix;
	}

	public static double GetFontScaleFactor(this PangoMatrixHandle matrix)
	{
		return PangoMatrixExterns.pango_matrix_get_font_scale_factor(matrix);
	}

	public static T GetFontScaleFactors<T>(this T matrix, out double xscale, out double yscale) where T : PangoMatrixHandle
	{
		PangoMatrixExterns.pango_matrix_get_font_scale_factors(matrix, out xscale, out yscale);
		return matrix;
	}

	public static double GetSlantRatio(this PangoMatrixHandle matrix)
	{
		return PangoMatrixExterns.pango_matrix_get_slant_ratio(matrix);
	}

	public static T Rotate<T>(this T matrix, double degrees) where T : PangoMatrixHandle
	{
		PangoMatrixExterns.pango_matrix_rotate(matrix, degrees);
		return matrix;
	}

	public static T Scale<T>(this T matrix, double scale_x, double scale_y) where T : PangoMatrixHandle
	{
		PangoMatrixExterns.pango_matrix_scale(matrix, scale_x, scale_y);
		return matrix;
	}

	public static T TransformDistance<T>(this T matrix, ref double dx, ref double dy) where T : PangoMatrixHandle
	{
		PangoMatrixExterns.pango_matrix_transform_distance(matrix, ref dx, ref dy);
		return matrix;
	}

	public static T TransformPixelRectangle<T>(this T matrix, PangoRectangleHandle rect) where T : PangoMatrixHandle
	{
		PangoMatrixExterns.pango_matrix_transform_pixel_rectangle(matrix, rect);
		return matrix;
	}

	public static T TransformPoint<T>(this T matrix, ref double x, ref double y) where T : PangoMatrixHandle
	{
		PangoMatrixExterns.pango_matrix_transform_point(matrix, ref x, ref y);
		return matrix;
	}

	public static T TransformRectangle<T>(this T matrix, PangoRectangleHandle rect) where T : PangoMatrixHandle
	{
		PangoMatrixExterns.pango_matrix_transform_rectangle(matrix, rect);
		return matrix;
	}

	public static T Translate<T>(this T matrix, double tx, double ty) where T : PangoMatrixHandle
	{
		PangoMatrixExterns.pango_matrix_translate(matrix, tx, ty);
		return matrix;
	}

}
internal class PangoMatrixExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern void pango_matrix_concat(PangoMatrixHandle matrix, PangoMatrixHandle new_matrix);

	[DllImport(Libraries.Pango)]
	internal static extern PangoMatrixHandle pango_matrix_copy(PangoMatrixHandle matrix);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_matrix_free(PangoMatrixHandle matrix);

	[DllImport(Libraries.Pango)]
	internal static extern double pango_matrix_get_font_scale_factor(PangoMatrixHandle matrix);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_matrix_get_font_scale_factors(PangoMatrixHandle matrix, out double xscale, out double yscale);

	[DllImport(Libraries.Pango)]
	internal static extern double pango_matrix_get_slant_ratio(PangoMatrixHandle matrix);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_matrix_rotate(PangoMatrixHandle matrix, double degrees);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_matrix_scale(PangoMatrixHandle matrix, double scale_x, double scale_y);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_matrix_transform_distance(PangoMatrixHandle matrix, ref double dx, ref double dy);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_matrix_transform_pixel_rectangle(PangoMatrixHandle matrix, PangoRectangleHandle rect);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_matrix_transform_point(PangoMatrixHandle matrix, ref double x, ref double y);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_matrix_transform_rectangle(PangoMatrixHandle matrix, PangoRectangleHandle rect);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_matrix_translate(PangoMatrixHandle matrix, double tx, double ty);

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
