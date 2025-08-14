namespace MentorLake.Vulkan;


public class VkPhysicalDeviceYcbcrImageArraysFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceYcbcrImageArraysFeaturesEXTExtensions
{

	public static VkPhysicalDeviceYcbcrImageArraysFeaturesEXT Dereference(this VkPhysicalDeviceYcbcrImageArraysFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceYcbcrImageArraysFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceYcbcrImageArraysFeaturesEXTExterns
{
}


public struct VkPhysicalDeviceYcbcrImageArraysFeaturesEXT
{
}
