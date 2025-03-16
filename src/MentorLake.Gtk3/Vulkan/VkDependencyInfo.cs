namespace MentorLake.Vulkan;

public class VkDependencyInfoHandle : BaseSafeHandle
{
}


public static class VkDependencyInfoExtensions
{

	public static VkDependencyInfo Dereference(this VkDependencyInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDependencyInfo>(x.DangerousGetHandle());
}
internal class VkDependencyInfoExterns
{
}

public struct VkDependencyInfo
{
}
