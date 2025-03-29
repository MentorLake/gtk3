namespace MentorLake.Atk;

public interface AtkImageHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class AtkImageHandleImpl : BaseSafeHandle, AtkImageHandle
{
}

public static class AtkImageHandleExtensions
{
	public static string GetImageDescription(this MentorLake.Atk.AtkImageHandle image)
	{
		if (image.IsInvalid || image.IsClosed) throw new Exception("Invalid or closed handle (AtkImageHandle)");
		return AtkImageHandleExterns.atk_image_get_image_description(image);
	}

	public static string GetImageLocale(this MentorLake.Atk.AtkImageHandle image)
	{
		if (image.IsInvalid || image.IsClosed) throw new Exception("Invalid or closed handle (AtkImageHandle)");
		return AtkImageHandleExterns.atk_image_get_image_locale(image);
	}

	public static T GetImagePosition<T>(this T image, out int x, out int y, MentorLake.Atk.AtkCoordType coord_type) where T : AtkImageHandle
	{
		if (image.IsInvalid || image.IsClosed) throw new Exception("Invalid or closed handle (AtkImageHandle)");
		AtkImageHandleExterns.atk_image_get_image_position(image, out x, out y, coord_type);
		return image;
	}

	public static T GetImageSize<T>(this T image, out int width, out int height) where T : AtkImageHandle
	{
		if (image.IsInvalid || image.IsClosed) throw new Exception("Invalid or closed handle (AtkImageHandle)");
		AtkImageHandleExterns.atk_image_get_image_size(image, out width, out height);
		return image;
	}

	public static bool SetImageDescription(this MentorLake.Atk.AtkImageHandle image, string description)
	{
		if (image.IsInvalid || image.IsClosed) throw new Exception("Invalid or closed handle (AtkImageHandle)");
		return AtkImageHandleExterns.atk_image_set_image_description(image, description);
	}

}

internal class AtkImageHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_image_get_image_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkImageHandleImpl>))] MentorLake.Atk.AtkImageHandle image);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_image_get_image_locale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkImageHandleImpl>))] MentorLake.Atk.AtkImageHandle image);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_image_get_image_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkImageHandleImpl>))] MentorLake.Atk.AtkImageHandle image, out int x, out int y, MentorLake.Atk.AtkCoordType coord_type);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_image_get_image_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkImageHandleImpl>))] MentorLake.Atk.AtkImageHandle image, out int width, out int height);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_image_set_image_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkImageHandleImpl>))] MentorLake.Atk.AtkImageHandle image, string description);

}
