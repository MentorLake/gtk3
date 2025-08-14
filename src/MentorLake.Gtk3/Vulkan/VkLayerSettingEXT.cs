namespace MentorLake.Vulkan;


public class VkLayerSettingEXTHandle : BaseSafeHandle
{
}


public static class VkLayerSettingEXTExtensions
{

	public static VkLayerSettingEXT Dereference(this VkLayerSettingEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkLayerSettingEXT>(x.DangerousGetHandle());
}
internal class VkLayerSettingEXTExterns
{
}


public struct VkLayerSettingEXT
{
}
