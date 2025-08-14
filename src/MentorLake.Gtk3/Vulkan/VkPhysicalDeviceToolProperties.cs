namespace MentorLake.Vulkan;


public class VkPhysicalDeviceToolPropertiesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceToolPropertiesExtensions
{

	public static VkPhysicalDeviceToolProperties Dereference(this VkPhysicalDeviceToolPropertiesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceToolProperties>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceToolPropertiesExterns
{
}


public struct VkPhysicalDeviceToolProperties
{
}
