namespace MentorLake.Vulkan;


public class VkPhysicalDevice4444FormatsFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDevice4444FormatsFeaturesEXTExtensions
{

	public static VkPhysicalDevice4444FormatsFeaturesEXT Dereference(this VkPhysicalDevice4444FormatsFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDevice4444FormatsFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDevice4444FormatsFeaturesEXTExterns
{
}


public struct VkPhysicalDevice4444FormatsFeaturesEXT
{
}
