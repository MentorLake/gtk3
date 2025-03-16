namespace MentorLake.Vulkan;

public class VkImageFormatPropertiesHandle : BaseSafeHandle
{
}


public static class VkImageFormatPropertiesExtensions
{

	public static VkImageFormatProperties Dereference(this VkImageFormatPropertiesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageFormatProperties>(x.DangerousGetHandle());
}
internal class VkImageFormatPropertiesExterns
{
}

public struct VkImageFormatProperties
{
}
