# Chameleon Install 2.2.4.6

A Windows GUI installer for the **Chameleon** bootloader (Hackintosh). This source
was reconstructed by decompiling the original `Chameleon Install 2.2.4.6 (svn 2246)`
binary and recompiling it to produce a functionally equivalent output.

Original author: **wowpc.cn** (2013)

## What it does

This tool installs or uninstalls the Chameleon bootloader on Windows so you can
boot OS X / macOS on non-Apple ("Hackintosh") hardware:

- **XP / 2003 systems** – writes `wowpc.iso`, `Avldr.bin` and `Avlgo.sys` to `C:\`
  and adds a `C:\Avldr.bin=Chameleon` entry to `boot.ini`.
- **Vista / 7 / 8 systems** – writes the same three files to the active system
  partition and registers Chameleon through `bcdedit` (BCD store) so it appears
  in the Windows boot menu.
- **Theme picker** – bundles several boot themes: Default, wowpc, iphone, mint,
  Bootcamp, Chamatic, bullet, Mountain Lion, Lion (no resolution.dylib).
- **Advanced boot options editor** – generate/edit `org.chameleon.Boot.plist`
  (graphics, CPU, memory, kexts, etc.).
- **Language switch** – Chinese and English UI.

## Requirements to run

- Windows XP / 2003 / Vista / 7 / 8 (the installer targets the real system, not
  the boot volume of macOS).
- .NET Framework **2.0 or later**.
- Administrator privileges (it writes to `C:\`, `boot.ini` / BCD, and the registry).

> **Warning:** installing Chameleon modifies your Windows boot configuration
> (`boot.ini` / BCD). Test on a VM or backup your boot files first.

## Build from source

Prerequisites: .NET SDK 6+ (any recent version works).

```bash
dotnet build "Chameleon Install.csproj" -c Release
```

Output: `bin\Release\net20\Chameleon Install.exe`

The binary `.resources` files in the project root are the resources used by the
forms (`Form1.resources`, `chameleon.resources`) and the strongly-typed resource
container (`Chameleon_Install.Properties.Resources.resources`, containing the
embedded `wowpc.iso` theme images and boot files). The English satellite
resources live under `res\` and are compiled into `en-US\Chameleon
Install.resources.dll` (see below).

### Rebuilding the en-US satellite resources

```bash
# csc is shipped with the .NET SDK at sdk/<version>/Roslyn/bincore/csc.dll
dotnet "path\to\csc.dll" /nologo /target:library \
  /out:"Chameleon Install.resources.dll" \
  /nostdlib+ /r:"<net20-ref-assemblies>\mscorlib.dll" \
  /resource:"res\Chameleon_Install.Form1.en-US.resources,Chameleon_Install.Form1.en-US.resources" \
  /resource:"res\Chameleon_Install.chameleon.en-US.resources,Chameleon_Install.chameleon.en-US.resources" \
  Properties\AssemblyInfo.cs
```

Place the resulting DLL in an `en-US\` folder next to the EXE.

## Source layout

```
Properties/AssemblyInfo.cs                 Assembly metadata (version 2.2.4.6)
Chameleon_Install/Program.cs              Entry point (WinForms app start)
Chameleon_Install/Form1.cs                Main installer form + install logic
Chameleon_Install/chameleon.cs            org.chameleon.Boot.plist editor form
Chameleon_Install/Properties/Resources.cs Strongly-typed resource accessors
Chameleon_Install/Properties/Settings.cs  Application settings
*.resources                               Compiled binary resources (.resx equivalent)
res/                                      English satellite resources
```

## Notes

- `Form1.cs` switches UI culture at runtime via the two radio buttons
  (`en-US` / `zh-CN`).
- Full disk writes are performed with `FileStream`/`BinaryWriter`; hidden
  read-only attributes are set on installed boot files like the original.
- This is a reverse-engineered source tree: it is provided for study and
  interoperability, and is not the original author's code.

## License

Third-party binaries inside `Chameleon_Install.Properties.Resources.resources`
(retail themes, `Avldr.bin`/`Avlgo.sys`) are the property of their respective
owners. All trademarks belong to their holders. Use at your own risk.