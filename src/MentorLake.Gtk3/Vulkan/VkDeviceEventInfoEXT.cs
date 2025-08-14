namespace MentorLake.Vulkan;


public class VkDeviceEventInfoEXTHandle : BaseSafeHandle
{
}


public static class VkDeviceEventInfoEXTExtensions
{

	public static VkDeviceEventInfoEXT Dereference(this VkDeviceEventInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceEventInfoEXT>(x.DangerousGetHandle());
}
internal class VkDeviceEventInfoEXTExterns
{
}


public struct VkDeviceEventInfoEXT
{
}
