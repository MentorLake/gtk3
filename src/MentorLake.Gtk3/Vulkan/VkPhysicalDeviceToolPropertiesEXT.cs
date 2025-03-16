namespace MentorLake.Vulkan;

public class VkPhysicalDeviceToolPropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceToolPropertiesEXTExtensions
{

	public static VkPhysicalDeviceToolPropertiesEXT Dereference(this VkPhysicalDeviceToolPropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceToolPropertiesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceToolPropertiesEXTExterns
{
}

public struct VkPhysicalDeviceToolPropertiesEXT
{
}
