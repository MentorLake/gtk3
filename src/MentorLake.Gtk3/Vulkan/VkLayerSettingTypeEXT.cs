namespace MentorLake.Vulkan;

public class VkLayerSettingTypeEXTHandle : BaseSafeHandle
{
}


public static class VkLayerSettingTypeEXTExtensions
{

	public static VkLayerSettingTypeEXT Dereference(this VkLayerSettingTypeEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkLayerSettingTypeEXT>(x.DangerousGetHandle());
}
internal class VkLayerSettingTypeEXTExterns
{
}

public struct VkLayerSettingTypeEXT
{
}
