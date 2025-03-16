namespace MentorLake.Vulkan;

public class VkPhysicalDeviceShaderTileImagePropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceShaderTileImagePropertiesEXTExtensions
{

	public static VkPhysicalDeviceShaderTileImagePropertiesEXT Dereference(this VkPhysicalDeviceShaderTileImagePropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceShaderTileImagePropertiesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceShaderTileImagePropertiesEXTExterns
{
}

public struct VkPhysicalDeviceShaderTileImagePropertiesEXT
{
}
