namespace MentorLake.Vulkan;


public class VkDevicePrivateDataCreateInfoHandle : BaseSafeHandle
{
}


public static class VkDevicePrivateDataCreateInfoExtensions
{

	public static VkDevicePrivateDataCreateInfo Dereference(this VkDevicePrivateDataCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDevicePrivateDataCreateInfo>(x.DangerousGetHandle());
}
internal class VkDevicePrivateDataCreateInfoExterns
{
}


public struct VkDevicePrivateDataCreateInfo
{
}
