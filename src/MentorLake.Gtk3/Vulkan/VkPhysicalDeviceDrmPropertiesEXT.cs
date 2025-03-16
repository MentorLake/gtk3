namespace MentorLake.Vulkan;

public class VkPhysicalDeviceDrmPropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceDrmPropertiesEXTExtensions
{

	public static VkPhysicalDeviceDrmPropertiesEXT Dereference(this VkPhysicalDeviceDrmPropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceDrmPropertiesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceDrmPropertiesEXTExterns
{
}

public struct VkPhysicalDeviceDrmPropertiesEXT
{
}
