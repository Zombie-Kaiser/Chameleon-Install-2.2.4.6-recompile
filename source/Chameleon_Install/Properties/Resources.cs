using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Chameleon_Install.Properties;

[CompilerGenerated]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (object.ReferenceEquals(resourceMan, null))
			{
				ResourceManager resourceManager = new ResourceManager("Chameleon_Install.Properties.Resources", typeof(Resources).Assembly);
				resourceMan = resourceManager;
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static byte[] Avldr
	{
		get
		{
			object obj = ResourceManager.GetObject("Avldr", resourceCulture);
			return (byte[])obj;
		}
	}

	internal static byte[] Avlgo
	{
		get
		{
			object obj = ResourceManager.GetObject("Avlgo", resourceCulture);
			return (byte[])obj;
		}
	}

	internal static Bitmap logo
	{
		get
		{
			object obj = ResourceManager.GetObject("logo", resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal static byte[] rc5Bootcamp
	{
		get
		{
			object obj = ResourceManager.GetObject("rc5Bootcamp", resourceCulture);
			return (byte[])obj;
		}
	}

	internal static byte[] rc5bullet
	{
		get
		{
			object obj = ResourceManager.GetObject("rc5bullet", resourceCulture);
			return (byte[])obj;
		}
	}

	internal static byte[] rc5Chamatic
	{
		get
		{
			object obj = ResourceManager.GetObject("rc5Chamatic", resourceCulture);
			return (byte[])obj;
		}
	}

	internal static byte[] rc5default
	{
		get
		{
			object obj = ResourceManager.GetObject("rc5default", resourceCulture);
			return (byte[])obj;
		}
	}

	internal static byte[] rc5iphone
	{
		get
		{
			object obj = ResourceManager.GetObject("rc5iphone", resourceCulture);
			return (byte[])obj;
		}
	}

	internal static byte[] rc5lion
	{
		get
		{
			object obj = ResourceManager.GetObject("rc5lion", resourceCulture);
			return (byte[])obj;
		}
	}

	internal static byte[] rc5lionNo
	{
		get
		{
			object obj = ResourceManager.GetObject("rc5lionNo", resourceCulture);
			return (byte[])obj;
		}
	}

	internal static byte[] rc5mint
	{
		get
		{
			object obj = ResourceManager.GetObject("rc5mint", resourceCulture);
			return (byte[])obj;
		}
	}

	internal static byte[] rc5wowpc
	{
		get
		{
			object obj = ResourceManager.GetObject("rc5wowpc", resourceCulture);
			return (byte[])obj;
		}
	}

	internal Resources()
	{
	}
}
