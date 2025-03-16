namespace MentorLake.Vulkan;

public class VkPhysicalDeviceTypeHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceTypeExtensions
{

	public static VkPhysicalDeviceType Dereference(this VkPhysicalDeviceTypeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceType>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceTypeExterns
{
}

public struct VkPhysicalDeviceType
{
}
