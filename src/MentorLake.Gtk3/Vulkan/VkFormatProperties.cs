namespace MentorLake.Vulkan;


public class VkFormatPropertiesHandle : BaseSafeHandle
{
}


public static class VkFormatPropertiesExtensions
{

	public static VkFormatProperties Dereference(this VkFormatPropertiesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFormatProperties>(x.DangerousGetHandle());
}
internal class VkFormatPropertiesExterns
{
}


public struct VkFormatProperties
{
}
