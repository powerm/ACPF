using System;

namespace ACPF
{
	public partial class UniformPlatform : Gtk.Window
	{
		public UniformPlatform () : base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

