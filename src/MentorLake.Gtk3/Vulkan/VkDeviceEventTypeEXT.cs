namespace MentorLake.Vulkan;


public class VkDeviceEventTypeEXTHandle : BaseSafeHandle
{
}


public static class VkDeviceEventTypeEXTExtensions
{

	public static VkDeviceEventTypeEXT Dereference(this VkDeviceEventTypeEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceEventTypeEXT>(x.DangerousGetHandle());
}
internal class VkDeviceEventTypeEXTExterns
{
}


public struct VkDeviceEventTypeEXT
{
}
