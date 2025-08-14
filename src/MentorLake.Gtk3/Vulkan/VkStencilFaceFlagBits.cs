namespace MentorLake.Vulkan;


public class VkStencilFaceFlagBitsHandle : BaseSafeHandle
{
}


public static class VkStencilFaceFlagBitsExtensions
{

	public static VkStencilFaceFlagBits Dereference(this VkStencilFaceFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkStencilFaceFlagBits>(x.DangerousGetHandle());
}
internal class VkStencilFaceFlagBitsExterns
{
}


public struct VkStencilFaceFlagBits
{
}
