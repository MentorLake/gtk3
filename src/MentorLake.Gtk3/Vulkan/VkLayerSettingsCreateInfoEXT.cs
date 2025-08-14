namespace MentorLake.Vulkan;


public class VkLayerSettingsCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkLayerSettingsCreateInfoEXTExtensions
{

	public static VkLayerSettingsCreateInfoEXT Dereference(this VkLayerSettingsCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkLayerSettingsCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkLayerSettingsCreateInfoEXTExterns
{
}


public struct VkLayerSettingsCreateInfoEXT
{
}
