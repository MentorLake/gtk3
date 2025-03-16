namespace MentorLake.Vulkan;

public class VkExternalImageFormatPropertiesHandle : BaseSafeHandle
{
}


public static class VkExternalImageFormatPropertiesExtensions
{

	public static VkExternalImageFormatProperties Dereference(this VkExternalImageFormatPropertiesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalImageFormatProperties>(x.DangerousGetHandle());
}
internal class VkExternalImageFormatPropertiesExterns
{
}

public struct VkExternalImageFormatProperties
{
}
