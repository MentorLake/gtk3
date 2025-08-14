namespace MentorLake.Vulkan;


public class VkDevicePrivateDataCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkDevicePrivateDataCreateInfoEXTExtensions
{

	public static VkDevicePrivateDataCreateInfoEXT Dereference(this VkDevicePrivateDataCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDevicePrivateDataCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkDevicePrivateDataCreateInfoEXTExterns
{
}


public struct VkDevicePrivateDataCreateInfoEXT
{
}
