namespace MentorLake.Vulkan;


public class VkMicromapCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkMicromapCreateInfoEXTExtensions
{

	public static VkMicromapCreateInfoEXT Dereference(this VkMicromapCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMicromapCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkMicromapCreateInfoEXTExterns
{
}


public struct VkMicromapCreateInfoEXT
{
}
