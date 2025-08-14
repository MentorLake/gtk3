namespace MentorLake.Vulkan;


public class VkCuFunctionNVXHandle : BaseSafeHandle
{
}


public static class VkCuFunctionNVXExtensions
{

	public static VkCuFunctionNVX Dereference(this VkCuFunctionNVXHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCuFunctionNVX>(x.DangerousGetHandle());
}
internal class VkCuFunctionNVXExterns
{
}


public struct VkCuFunctionNVX
{
}
