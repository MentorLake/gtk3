namespace MentorLake.Gtk3.Atk;

public interface AtkImageHandle
{
}

internal class AtkImageHandleImpl : BaseSafeHandle, AtkImageHandle
{
}

public static class AtkImageHandleExtensions
{
	public static string GetImageDescription(this AtkImageHandle image)
	{
		return AtkImageExterns.atk_image_get_image_description(image);
	}

	public static string GetImageLocale(this AtkImageHandle image)
	{
		return AtkImageExterns.atk_image_get_image_locale(image);
	}

	public static T GetImagePosition<T>(this T image, out int x, out int y, AtkCoordType coord_type) where T : AtkImageHandle
	{
		AtkImageExterns.atk_image_get_image_position(image, out x, out y, coord_type);
		return image;
	}

	public static T GetImageSize<T>(this T image, out int width, out int height) where T : AtkImageHandle
	{
		AtkImageExterns.atk_image_get_image_size(image, out width, out height);
		return image;
	}

	public static bool SetImageDescription(this AtkImageHandle image, string description)
	{
		return AtkImageExterns.atk_image_set_image_description(image, description);
	}

}

internal class AtkImageExterns
{
	[DllImport(Libraries.Atk)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_image_get_image_description(AtkImageHandle image);

	[DllImport(Libraries.Atk)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_image_get_image_locale(AtkImageHandle image);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_image_get_image_position(AtkImageHandle image, out int x, out int y, AtkCoordType coord_type);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_image_get_image_size(AtkImageHandle image, out int width, out int height);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_image_set_image_description(AtkImageHandle image, string description);

}
