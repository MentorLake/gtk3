namespace MentorLake.Vulkan;


public class VkRasterizationOrderAMDHandle : BaseSafeHandle
{
}


public static class VkRasterizationOrderAMDExtensions
{

	public static VkRasterizationOrderAMD Dereference(this VkRasterizationOrderAMDHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRasterizationOrderAMD>(x.DangerousGetHandle());
}
internal class VkRasterizationOrderAMDExterns
{
}


public struct VkRasterizationOrderAMD
{
}
