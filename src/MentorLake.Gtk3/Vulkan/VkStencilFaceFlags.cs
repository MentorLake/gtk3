namespace MentorLake.Vulkan;

public class VkStencilFaceFlagsHandle : BaseSafeHandle
{
}


public static class VkStencilFaceFlagsExtensions
{

	public static VkStencilFaceFlags Dereference(this VkStencilFaceFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkStencilFaceFlags>(x.DangerousGetHandle());
}
internal class VkStencilFaceFlagsExterns
{
}

public struct VkStencilFaceFlags
{
}
