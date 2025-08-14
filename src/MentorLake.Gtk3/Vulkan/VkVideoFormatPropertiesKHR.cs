namespace MentorLake.Vulkan;


public class VkVideoFormatPropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkVideoFormatPropertiesKHRExtensions
{

	public static VkVideoFormatPropertiesKHR Dereference(this VkVideoFormatPropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoFormatPropertiesKHR>(x.DangerousGetHandle());
}
internal class VkVideoFormatPropertiesKHRExterns
{
}


public struct VkVideoFormatPropertiesKHR
{
}
