namespace MentorLake.Vulkan;


public class VkRenderPassFragmentDensityMapCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkRenderPassFragmentDensityMapCreateInfoEXTExtensions
{

	public static VkRenderPassFragmentDensityMapCreateInfoEXT Dereference(this VkRenderPassFragmentDensityMapCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRenderPassFragmentDensityMapCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkRenderPassFragmentDensityMapCreateInfoEXTExterns
{
}


public struct VkRenderPassFragmentDensityMapCreateInfoEXT
{
}
