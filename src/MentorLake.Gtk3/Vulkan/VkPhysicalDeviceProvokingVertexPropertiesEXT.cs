namespace MentorLake.Vulkan;


public class VkPhysicalDeviceProvokingVertexPropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceProvokingVertexPropertiesEXTExtensions
{

	public static VkPhysicalDeviceProvokingVertexPropertiesEXT Dereference(this VkPhysicalDeviceProvokingVertexPropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceProvokingVertexPropertiesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceProvokingVertexPropertiesEXTExterns
{
}


public struct VkPhysicalDeviceProvokingVertexPropertiesEXT
{
}
